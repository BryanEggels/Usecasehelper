using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Usecase
{
    public class Usecase
    {
        string Naam;
        string Samenvatting;
        List<string> Actoren = new List<string>();
        string Aannamen;
        string Beschrijving;
        string Uitzonderingen;
        string Resultaat;

        Pen pen = new Pen(Color.Black);
        Point Punt;
        Rectangle hitbox;
        List<Lijn> lijnen;
        public string naam
        {
            get
            {
                return Naam;
            }
            set
            {
                Naam = value;
            }
        }
        public string samenvatting
        {
            get
            {
                return Samenvatting;
            }
            set
            {
                Samenvatting = value;
            }
        }
        public string actors
        {
            get
            {
                StringBuilder sbuilder = new StringBuilder();
                foreach (string actor in Actoren)
                {
                    sbuilder.Append(actor+" ");
                }
                return sbuilder.ToString();
            }
            set
            {
                Actoren.Add(value);
            }
        }
        public string aannamen
        {
            get
            {
                return Aannamen;
            }
            set
            {
                Aannamen = value;
            }
        }
        public string beschrijving
        {
            get
            {
                return Beschrijving;
            }
            set
            {
                Beschrijving = value;
            }
        }
        public string uitzonderingen
        {
            get
            {
                return Uitzonderingen;
            }
            set
            {
                Uitzonderingen = value;
            }
        }
        public string resultaat
        {
            get
            {
                return Resultaat;
            }
            set
            {
                Resultaat = value;
            }
        }
        public Point punt
        {
            get
            {
                return Punt;
            }
        }
        public Usecase(Point p1, Graphics g, string name)
        {
            this.Punt = p1;
            Naam = name;
            DrawCase(g);
            DrawName(punt, g);
        }
        public bool Selected(MouseEventArgs muis)
        {
            return hitbox.Contains(muis.Location);
        }
        public void DrawName(Point p1, Graphics g)
        {
            Size grootte = new Size(10, 10);
            grootte.Height = 5;
            grootte.Width = 5;
            FontFamily family = new FontFamily("Arial");
            Font font = new Font(family, 10);
            
            if(naam != "")
            {
                g.DrawString(naam, font, Brushes.Black, PointF.Add(p1, grootte));
            }
            else
            {
                this.Naam = "Usecase";
                g.DrawString(Naam, font, Brushes.Black, PointF.Add(p1, grootte));
            }
        } //draws name of the usecase
        public void DrawCase(Graphics g)
        {
            Rectangle rec = new Rectangle(punt.X, punt.Y, 100, 30);
            g.DrawEllipse(pen, rec);
            this.hitbox = rec;
            DrawName(punt, g);
        }  //draws the graphics
        public void Lijnen(Lijn line)
        { 
            Actoren.Clear();
            if (lijnen == null)
            {
                lijnen = new List<Lijn>();
            }
            lijnen.Add(line);
            foreach (Lijn lijn in lijnen)
            {
                Actoren.Add(lijn.actor.naam);
            }

        }
    }
}
