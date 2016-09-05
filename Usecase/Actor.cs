using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Usecase
{
    class Actor
    {
        Point P1;
        public Point p1
        {
            get
            {
                return P1;
            }
        }
        Pen streeppen = new Pen(Color.Black);
        public Actor(Point punt1, Graphics g, string naam)
        {
            DrawActor(g, punt1, naam);
            this.P1 = punt1;
        }

        private void DrawHead(Graphics g, Point p1)
        {
            Rectangle rec = new Rectangle(p1.X - 10, p1.Y - 20, 20, 20);
            g.DrawEllipse(streeppen, rec);
        }
        private void DrawArms(Graphics g, Point p1)
        {
            Point punt1 = new Point(p1.X - 10, p1.Y + 12);
            Point punt2 = new Point(p1.X + 10, p1.Y + 12);
            g.DrawLine(streeppen, punt1, punt2);
        }
        private void DrawLegs(Graphics g, Point p1)
        {
            Point legpoint1 = new Point(p1.X, p1.Y + 30);
            Point legpoint2 = new Point(p1.X + 10, p1.Y + 45);
            g.DrawLine(streeppen, legpoint1, legpoint2);
            legpoint2.X = legpoint2.X - 20;
            g.DrawLine(streeppen, legpoint1, legpoint2);
        }
        private void DrawBody(Graphics g, Point p1)
        {
            int hoogte = p1.Y + 30;
            Point punt2 = new Point(p1.X, hoogte);
            g.DrawLine(streeppen, p1, punt2);
        }
        private void DrawActor(Graphics g, Point p1, string naam)
        {
            
            DrawBody(g, p1);
            DrawHead(g, p1);
            DrawArms(g, p1);
            DrawLegs(g, p1);
            DrawName(g, p1, naam);
             
        }
        private void DrawName(Graphics g, Point p1,string naam)
        {
            p1.Y = p1.Y + 40;
            p1.X = p1.X - 20;
            Size grootte = new Size(10, 10);
            grootte.Height = 5;
            grootte.Width = 5;
            FontFamily family = new FontFamily("Arial");
            Font font = new Font(family, 10);
            if (naam == "")
            {
                g.DrawString("Actor", font, Brushes.Black, PointF.Add(p1, grootte));
            }
            else
            {
                g.DrawString(naam, font, Brushes.Black, PointF.Add(p1, grootte));
            }
            
        }

    }
}