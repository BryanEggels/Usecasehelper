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
        int id;
        string Naam;
        string Samenvatting;
        string Actoren;
        string Aannamen;
        string Beschrijving;
        string Uitzonderingen;
        string Resultaat;

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
                return Actoren;
            }
            set
            {
                Actoren = value;
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

        Pen pen = new Pen(Color.Black);
        Point Punt;
        Rectangle hitbox;
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
            Rectangle rec = new Rectangle(p1.X, p1.Y, 100, 30);
            g.DrawEllipse(pen, rec);
            this.hitbox = rec;
            Naam = name;
            DrawName(punt, g);
            
        }
        public bool selected(MouseEventArgs muis)
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
        }
    }
}
