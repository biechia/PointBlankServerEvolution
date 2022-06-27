﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_ROOM_CHANGE_ROOM_OPTIONINFO_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_ROOM_CHANGE_ROOM_OPTIONINFO_ACK : SendPacket
  {
    private string _leader;
    private Room _room;

    public PROTOCOL_ROOM_CHANGE_ROOM_OPTIONINFO_ACK(Room room, string leader)
    {
      this._room = room;
      this._leader = leader;
    }

    public override void write()
    {
      this.writeH((short) 3874);
      this.writeC((byte) 0);
      this.writeUnicode(this._leader, 66);
      this.writeD(this._room.killtime);
      this.writeC(this._room.Limit);
      this.writeC(this._room.WatchRuleFlag);
      this.writeH(this._room.BalanceType);
      this.writeB(new byte[16]);
    }
  }
}
