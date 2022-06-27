﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_BASE_QUEST_ACTIVE_IDX_CHANGE_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;
using PointBlank.Game.Data.Model;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_BASE_QUEST_ACTIVE_IDX_CHANGE_ACK : SendPacket
  {
    private Account p;
    private uint erro;
    private int type;

    public PROTOCOL_BASE_QUEST_ACTIVE_IDX_CHANGE_ACK(uint erro, int type, Account p)
    {
      this.erro = erro;
      this.type = type;
      this.p = p;
    }

    public override void write()
    {
      this.writeH((short) 569);
      this.writeD(this.erro);
      this.writeC((byte) this.type);
      if (((int) this.erro & 1) != 1)
        return;
      this.writeD(this.p._exp);
      this.writeD(this.p._gp);
      this.writeD(this.p.brooch);
      this.writeD(this.p.insignia);
      this.writeD(this.p.medal);
      this.writeD(this.p.blue_order);
      this.writeD(this.p._rank);
    }
  }
}
