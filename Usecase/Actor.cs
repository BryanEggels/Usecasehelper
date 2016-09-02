using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Usecase
{
    class Actor
    {
        public Actor(Point punt1, Graphics g)
        {
            int test = punt1.Y;
            Point punt2 = new Point(punt1.X, test + 100);
            Pen streeppen = new Pen(Color.Black);
            g.DrawLine(streeppen, punt1, punt2);
            
        }

    }
}
