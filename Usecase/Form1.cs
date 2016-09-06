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
        int y = 30;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Refresh();
            pictureBox1.BackColor = Color.Red;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            actoren.Clear();
            y = 30;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs muis = (MouseEventArgs)e;
            if (rad_actor.Checked && rad_create.Checked && actoren.Count < 3)
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
                        actor.Selected();
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
                Lijn line = new Lijn(formGraphics); //moet boven in de class komen?

                while(line.beginpunt.X == 0 || line.eindpunt.X == 0) //hangt vast omdat hij blijft checken met 1 klik, fix it
                {
                    foreach (Actor actor in actoren)
                    {

                        if (actor.Clicked(muis))
                        {
                            line.beginpunt = actor.Selected();
                        }
                    }
                    foreach (Usecase cas in usecases)
                    {
                        if (cas.Selected(muis))
                        {
                            line.eindpunt = cas.punt;
                        }
                    }
                }
                line.Drawline();
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bool only_once = true;
            if (only_once)
            {
                formGraphics = pictureBox1.CreateGraphics();
                
                only_once = false;
                
            }
            
        }

    }
}
