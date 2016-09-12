using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Usecase
{
    public partial class Form1 : Form
    {

        Graphics formGraphics;
        List<Actor> actoren = new List<Actor>();
        List<Usecase> usecases = new List<Usecase>();
        List<Lijn> lijnen = new List<Lijn>();
        Lijn line;
        bool only_once = true;
        int y = 30;
        
        public Form1()
        {
            InitializeComponent(); 
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            actoren.Clear();
            lijnen.Clear();
            usecases.Clear();
            y = 30;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs muis = (MouseEventArgs)e;

            if (tb_name.Text == "" && rad_actor.Checked || tb_name.Text == "" && rad_usecase.Checked)
            {
                MessageBox.Show("please use the textbox");
            }
            else if (rad_actor.Checked && rad_create.Checked && actoren.Count < 3)
            {
                Point p1 = new Point(20, y);
                Actor actor = new Actor(p1 ,formGraphics, tb_name.Text);
                actoren.Add(actor);
                y = y + 110;
            }
            else if (rad_usecase.Checked && rad_create.Checked)
            {
                Usecase usec = new Usecase(muis.Location, formGraphics, tb_name.Text);
                usecases.Add(usec);
            }
            else if (rad_select.Checked)
            {
                foreach (Actor actor in actoren)
                {
                    if (actor.Clicked(muis))
                    {
                        actor.Selected(); //method not yet created.
                    }
                }
                foreach(Usecase cas in usecases)
                {
                    if (cas.Selected(muis))
                    {   
                        property window = new property(cas);
                        window.Show();
                    }
                }
            }
            else if (rad_line.Checked && rad_create.Checked) 
            {
                CreateLine(muis);
            }
            else if (rad_delete.Checked)
            {
                foreach (Usecase cas in usecases)
                {
                    if (cas.Selected(muis))
                    {
                        usecases.Remove(cas);
                        break;
                    }
                }
                foreach (Lijn line in lijnen)
                {
                    if (line.Selected(muis))
                    {
                        lijnen.Remove(line);
                        break;
                    }
                }
                foreach(Actor actor in actoren)
                {
                    if (actor.Clicked(muis))
                    {
                        actoren.Remove(actor);
                        y = y - 110;
                        break;
                        
                    }
                }
                pictureBox1.Refresh();
                ReDraw();
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (only_once)
            {
                formGraphics = pictureBox1.CreateGraphics();
                line = new Lijn(formGraphics);
                only_once = false;
            }
        }
        private void ReDraw()
        {
            foreach(Actor act in actoren)
            {
                act.DrawActor(formGraphics, act.p1, act.naam);
            }
            foreach(Usecase cas in usecases)
            {
                cas.DrawCase(formGraphics);
            }
            foreach (Lijn lijn in lijnen)
            {
                lijn.Drawline();
            }
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        } //redraws everything in the picturebox
        private void CreateLine(MouseEventArgs muis)
        {

            if (line.beginpunt.X == 0 || line.eindpunt.X == 0)
            {
                foreach (Actor actor in actoren)
                {

                    if (actor.Clicked(muis))
                    {
                        //line.beginpunt = new Point(actor.armpunt.X, actor.armpunt.Y);
                        line.actor = actor;
                    }
                }
                foreach (Usecase cas in usecases)
                {
                    if (cas.Selected(muis))
                    {
                        //line.eindpunt = cas.punt;
                        //line.Eindp();
                        line.usecase = cas;
                        cas.Lijnen(line);
                    }
                }
            }
            if (line.actor != null && line.usecase != null)
            {
                line.Eindp();
                line.Drawline();
                lijnen.Add(line);
                
                line = new Lijn(formGraphics);
            }
            else
            {
                line = new Lijn(formGraphics);
                foreach (Actor actor in actoren)
                {

                    if (actor.Clicked(muis))
                    {
                        line.actor = actor;
                    }
                }
            }
            
        } //creates new lines 

        private void button1_Click(object sender, EventArgs e)
        {
            ReDraw();
        }
    }
}
