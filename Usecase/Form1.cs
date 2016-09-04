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
        public Form1()
        {
            InitializeComponent();
            panel1.Refresh();
            panel1.BackColor = Color.Red;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            formGraphics = panel1.CreateGraphics();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs muis = (MouseEventArgs)e;
            if (rad_actor.Checked && rad_create.Checked)
            {
                Actor popetje = new Actor(muis.Location, formGraphics);
                Label label = new Label();
                try
                {
                    label.Text = richTextBox1.Text;
                }
                catch
                {
                    label.Text = "Actor";
                    
                }
                finally
                {
                    label.Visible = true;
                    label.Location = muis.Location;
                    this.Controls.Add(label);
                }
            }
            else if (rad_usecase.Checked && rad_create.Checked)
            {
                Usecase usec = new Usecase(muis.Location, formGraphics);
            }
        }
    }
}
