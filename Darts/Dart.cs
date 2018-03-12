using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {

        private Random _random;
        public int Point { get; set; }
        public bool OuterBand { get; set; }
        public bool InnerBand { get; set; }
        public int Multiplier { get; set; }

        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            this.Point = _random.Next(0, 21);

            this.Multiplier = _random.Next(1, 101);
            if (Multiplier > 95) OuterBand = true;
            else if (Multiplier > 90) InnerBand = true;
        }
    }
}
