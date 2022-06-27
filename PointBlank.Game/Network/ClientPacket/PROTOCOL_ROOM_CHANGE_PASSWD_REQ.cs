﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_ROOM_CHANGE_PASSWD_REQ
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core;
using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;
using PointBlank.Game.Network.ServerPacket;
using System;

namespace PointBlank.Game.Network.ClientPacket
{
  public class PROTOCOL_ROOM_CHANGE_PASSWD_REQ : ReceivePacket
  {
    private string pass;

    public PROTOCOL_ROOM_CHANGE_PASSWD_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.pass = this.readS(4);
    }

    public override void run()
    {
      try
      {
        Account player = this._client._player;
        if (player == null)
          return;
        Room room = player._room;
        if (room == null || room._leader != player._slotId || !(room.password != this.pass))
          return;
        room.password = this.pass;
        using (PROTOCOL_ROOM_CHANGE_PASSWD_ACK roomChangePasswdAck = new PROTOCOL_ROOM_CHANGE_PASSWD_ACK(this.pass))
          room.SendPacketToPlayers((SendPacket) roomChangePasswdAck);
      }
      catch (Exception ex)
      {
        Logger.info(ex.ToString());
      }
    }
  }
}
