using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Usecase
{
    class Lijn
    {
        Point Beginpunt;
        Point Eindpunt;
        Graphics g;   

        public Point beginpunt
        {
            get
            {
                return Beginpunt;
            }
            set
            {
                Beginpunt = value;
            }
        }
        public Point eindpunt
        {
            get
            {
                return Eindpunt;
            }
            set
            {
                Eindpunt = value;
            }
        }
        public Lijn(Graphics grap)
        {
            g = grap;
        }
        public void Drawline()
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, Beginpunt, Eindpunt);
        }
    }
}
