using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP
{
    internal class League:Points
    {

        public override int TeamPoint(int win, int draw, int loss)
        {
            var prog = new League();
            int totalPoints = (prog.WinPoint * win) + (prog.DrawPoint * draw) + (prog.LossPoint * loss);
            return totalPoints;
        }
        public override float TeamPoint(int win, int loss)
        {

            float totalPoint = (float)win / ((float)win + (float)loss);
            return totalPoint;
        }
    }
}
