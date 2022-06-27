﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ClientPacket.PROTOCOL_CLAN_WAR_MATCH_TEAM_LIST_REQ
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
  public class PROTOCOL_CLAN_WAR_MATCH_TEAM_LIST_REQ : ReceivePacket
  {
    private int page;

    public PROTOCOL_CLAN_WAR_MATCH_TEAM_LIST_REQ(GameClient client, byte[] data)
    {
      this.makeme(client, data);
    }

    public override void read()
    {
      this.page = (int) this.readH();
    }

    public override void run()
    {
      try
      {
        Account player = this._client._player;
        if (player == null || player._match == null)
          return;
        Channel channel = player.getChannel();
        if (channel == null || channel._type != 4)
          return;
        this._client.SendPacket((SendPacket) new PROTOCOL_CLAN_WAR_MATCH_TEAM_LIST_ACK(this.page, channel._matchs, player._match._matchId));
      }
      catch (Exception ex)
      {
        Logger.info(ex.ToString());
      }
    }
  }
}
