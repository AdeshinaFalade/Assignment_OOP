using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP
{
    internal abstract class Points
    {
        public int WinPoint { get; } = 3;
        public int DrawPoint { get; } = 1;
        public int LossPoint { get; } = 0;
        public abstract int TeamPoint(int win, int draw, int loss);
        public abstract float TeamPoint(int win, int loss);

    }
}
