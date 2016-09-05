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
    public partial class property : Form
    {
        

        Usecase Usecase;
        public Usecase usecase
        {
            get
            {
                return Usecase;
            }
        }
        public property()
        {
            InitializeComponent();
        }
        public property(Usecase ucase)
        {
            InitializeComponent();
            if (ucase.naam != null)
            {
                tb_naam.Text = ucase.naam;
                tb_aannamen.Text = ucase.aannamen;
                tb_actoren.Text = ucase.actors;
                tb_resultaat.Text = ucase.resultaat;
                tb_samenvatting.Text = ucase.samenvatting;
                tb_beschrijving.Text = ucase.beschrijving;
                tb_uitzonderingen.Text = ucase.uitzonderingen;
                
            }
            this.Usecase = ucase;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            usecase.naam = tb_naam.Text;
            usecase.aannamen = tb_aannamen.Text;
            usecase.actors = tb_actoren.Text;
            usecase.resultaat = tb_resultaat.Text;
            usecase.samenvatting = tb_samenvatting.Text;
            usecase.beschrijving = tb_beschrijving.Text;
            usecase.uitzonderingen = tb_uitzonderingen.Text;
            
        }
    }
}
