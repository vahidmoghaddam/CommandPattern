﻿using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class StockCommand : AbstractCommand
    {
        public override List<string> SubscribeISINs()
        {
            return new List<string>() { "IRO1", "IRO3", "IRO7" };
        }
    }
}
