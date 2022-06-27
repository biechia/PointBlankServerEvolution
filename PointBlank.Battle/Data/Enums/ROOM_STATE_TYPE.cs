﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Enums.ROOM_STATE_TYPE
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using System;

namespace PointBlank.Battle.Data.Enums
{
  [Flags]
  public enum ROOM_STATE_TYPE
  {
    None = 0,
    DeathMatch = 4,
    Bomb = 8,
    Destroy = Bomb | DeathMatch, // 0x0000000C
    Annihilation = 16, // 0x00000010
    Defense = Annihilation | DeathMatch, // 0x00000014
    FreeForAll = Annihilation | Bomb, // 0x00000018
    Boss = FreeForAll | DeathMatch, // 0x0000001C
    Ace = 32, // 0x00000020
    StepUp = Ace | DeathMatch, // 0x00000024
    Tutorial = Ace | Bomb, // 0x00000028
    Domination = Tutorial | DeathMatch, // 0x0000002C
    CrossCounter = Ace | Annihilation, // 0x00000030
    Convoy = CrossCounter | DeathMatch, // 0x00000034
    Runaway = CrossCounter | Bomb, // 0x00000038
  }
}
