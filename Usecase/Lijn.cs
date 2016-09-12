using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Usecase
{
    public class Lijn
    {
        Point Beginpunt;
        Point Eindpunt;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        Actor Actor;
        Usecase Usecase;
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
        public Actor actor
        {
            get
            {
                return Actor;
            }
            set
            {
                Actor = value;
            }
        }
        public Usecase usecase
        {
            get
            {
                return Usecase;
            }
            set
            {
                Usecase = value;
                Eindp();
            }
        }

        public Lijn(Graphics grap)
        {
            g = grap;
        }
        public void Drawline()
        {
            g.DrawLine(pen, Actor.armpunt, Eindpunt);
        }
        public bool Selected(MouseEventArgs m)
        {
            Rectangle rec = new Rectangle(
                Math.Min(Actor.armpunt.X, Usecase.punt.X),
                Math.Min(Actor.armpunt.Y, Usecase.punt.Y),
                Math.Max(Actor.armpunt.X, Usecase.punt.X),
                Math.Max(Actor.armpunt.Y, Usecase.punt.Y));
            
            return rec.Contains(m.Location);
                
        }
        public void Eindp()
        {
            Eindpunt = Usecase.punt;
            Eindpunt.X = Usecase.punt.X + 32;
        }
    }
}
