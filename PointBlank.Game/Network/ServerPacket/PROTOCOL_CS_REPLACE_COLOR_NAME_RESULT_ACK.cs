﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Game.Network.ServerPacket.PROTOCOL_CS_REPLACE_COLOR_NAME_RESULT_ACK
// Assembly: PointBlank.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72688AFF-38A7-4220-8B49-8D2CFF6AFFF7
// Assembly location: D:\Servers\Debug\PointBlank.Game.exe

using PointBlank.Core.Network;

namespace PointBlank.Game.Network.ServerPacket
{
  public class PROTOCOL_CS_REPLACE_COLOR_NAME_RESULT_ACK : SendPacket
  {
    private byte color;

    public PROTOCOL_CS_REPLACE_COLOR_NAME_RESULT_ACK(byte color)
    {
      this.color = color;
    }

    public override void write()
    {
      this.writeH((short) 1926);
      this.writeC(this.color);
    }
  }
}
