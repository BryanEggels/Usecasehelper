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

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            formGraphics.Clear(Color.Transparent);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen mypen = new Pen(Color.Black);

            formGraphics = this.CreateGraphics();
            

            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            Point punt1 = new Point(x, y);
            Actor popetje = new Actor(punt1, formGraphics);
            
        }
    }
}
