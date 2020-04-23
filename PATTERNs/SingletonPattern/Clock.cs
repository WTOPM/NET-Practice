using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SingletonPattern
{
    class Clock
    {
        DateTime dateTime = new DateTime(1990, 11, 09);
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }

 
   
}

