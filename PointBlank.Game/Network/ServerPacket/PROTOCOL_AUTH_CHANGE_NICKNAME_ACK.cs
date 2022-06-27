﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_AUTH_CHANGE_NICKNAME_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_AUTH_CHANGE_NICKNAME_ACK : SendPacket
  {
    private string name;

    public PROTOCOL_AUTH_CHANGE_NICKNAME_ACK(string name)
    {
      this.name = name;
    }

    public override void write()
    {
      this.writeH((short) 812);
      this.writeC((byte) this.name.Length);
      this.writeUnicode(this.name, this.name.Length * 2);
    }
  }
}
