﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Core.Events
{
  public abstract class Event : Message
  {
    public DateTime Timestamp { get; private set; }

    public Event()
    {
      Timestamp = DateTime.Now;
    }
  }
}
