﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormCore
{
  public class OSection : IComparable<OSection>
  {
    public int Id { get; set; }
    public double Position { get; set; }
    public string Title { get; set; }

    public OSection(Section x)
    {
      Id = x.Id;
      Position = x.Position;
      Title = x.Title;
    }
    
    public int CompareTo(OSection other)
    {
      return Position.CompareTo(other.Position);
    }
  }
}