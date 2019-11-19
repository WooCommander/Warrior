using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class SimpleUnit:INeerAtack
    {
        public int Name { get; set; }
        public int Helth { get; set; }

        public void NeerAtak(SimpleUnit unit)
        {
            unit.Helth= unit.Helth-;
        }
    }
}
