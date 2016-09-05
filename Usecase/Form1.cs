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
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Refresh();
            pictureBox1.BackColor = Color.Red;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs muis = (MouseEventArgs)e;
            if (rad_actor.Checked && rad_create.Checked)
            {
                Actor actor = new Actor(muis.Location, formGraphics, richTextBox1.Text);
                actoren.Add(actor);
            }
            else if (rad_usecase.Checked && rad_create.Checked)
            {
                Usecase usec = new Usecase(muis.Location, formGraphics);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            formGraphics = pictureBox1.CreateGraphics();
        }
    }
}
