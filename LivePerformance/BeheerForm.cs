using System;
using System.Data.SqlClient;
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
            try
            {
                b.ProductToevoegen(tbNaam.Text, Convert.ToDouble(tbPrijs.Text), chbAlcohol.Checked);
            }
            catch (SqlException)
            {
                MessageBox.Show("Er is iets missgegeaan in de database");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                b.ingredientToevoegen(tbInNaam.Text, Convert.ToDouble(tbInPrijs.Text), cbInHalal.Checked,
                    cbInVeg.Checked);
            }
            catch (SqlException)
            {
                MessageBox.Show("Er is iets missgegeaan in de database");
            }
           
        }
    }
}
