﻿// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Models.Account.Title.TitleQ
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

namespace PointBlank.Core.Models.Account.Title
{
  public class TitleQ
  {
    public int _id;
    public int _classId;
    public int _medals;
    public int _brooch;
    public int _blueOrder;
    public int _insignia;
    public int _rank;
    public int _slot;
    public int _req1;
    public int _req2;
    public long _flag;

    public TitleQ()
    {
    }

    public TitleQ(int titleId)
    {
      this._id = titleId;
      this._flag = 1L << titleId;
    }
  }
}
