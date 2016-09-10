using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        public bool Selected(MouseEventArgs m)
        {
            Rectangle rec = new Rectangle(
                Math.Min(Beginpunt.X, Eindpunt.X),
                Math.Min(Beginpunt.Y, Eindpunt.Y),
                Math.Max(Beginpunt.X, Eindpunt.X),
                Math.Max(Beginpunt.Y, Eindpunt.Y));
            return rec.Contains(m.Location);
                
        }
    }
}
