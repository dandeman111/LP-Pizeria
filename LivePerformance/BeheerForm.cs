using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Logic;

namespace LivePerformance
{
    public partial class BeheerForm : Form
    {
        private Beheerlogic b;
        public BeheerForm()
        {
            InitializeComponent();
            b= new Beheerlogic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            b.ProductToevoegen(tbNaam.Text,Convert.ToDouble(tbPrijs.Text),chbAlcohol.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.ingredientToevoegen(tbInNaam.Text,Convert.ToDouble(tbInPrijs.Text),cbInHalal.Checked,cbInVeg.Checked );
        }
    }
}
