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
        Pen streeppen = new Pen(Color.Black);
        public Actor(Point punt1, Graphics g)
        {
            DrawActor(g, punt1);
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
        private void DrawActor(Graphics g, Point p1)
        {
            DrawBody(g, p1);
            DrawHead(g, p1);
            DrawArms(g, p1);
            DrawLegs(g, p1);
        }

    }
}