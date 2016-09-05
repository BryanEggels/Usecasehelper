using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Usecase
{
    class Usecase
    {
        Pen pen = new Pen(Color.Black);
        Point Punt;
        public Point punt
        {
            get
            {
                return Punt;
            }
        }
        public Usecase(Point p1, Graphics g)
        {
            this.Punt = p1;
            Rectangle rec = new Rectangle(p1.X, p1.Y, 100, 30);
            g.DrawEllipse(pen, rec);
        }
    }
}
