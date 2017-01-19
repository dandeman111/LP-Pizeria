using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LivePerformance.DAL.Models;
using LivePerformance.Logic;

namespace LivePerformance
{
    public partial class BestelForm : Form
    {
        private BestelLogic b;
        public BestelForm()
        {
            InitializeComponent();
            b = new BestelLogic();
            LaadUi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (b.plaatsBestelling())
                {
                    LaadUi();
                    Bon formbon = new Bon(b);
                    formbon.ShowDialog();
                    Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Er is iets mis gegaan met de database");
            }
            
            
        }

        private void lblOverig_Click(object sender, EventArgs e)
        {

        }

        private void BestelForm_Load(object sender, EventArgs e)
        {

        }

        private void LaadUi()
        {
            LbPizza.Items.Clear();
            LbProducts.Items.Clear();
            lbBestelling.Items.Clear();
            try
            {
                foreach (Pizza pizza in b.AllePizzas())
                {
                    LbPizza.Items.Add(pizza);
                }
                foreach (Product product in b.AlleProducts())
                {
                    LbProducts.Items.Add(product);
                }
                foreach (string s in b.GeefItems())
                {
                    lbBestelling.Items.Add(s);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Kon geen items ophalen.");
            }
            
            lblPrjs.Text = @"Prijs; " + b.geefPrijs()+ @"Euro";
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            try
            {
                b.VoegPizzaToe((Pizza) LbPizza.SelectedItem);
            }
            catch (FormatException)
            {
                MessageBox.Show("Er staat een object wat geen pizza is in de lijst");
            }
            
            LaadUi();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            try
            {
                b.VoegProductToe((Product) LbProducts.SelectedItem);
            }
            catch (FormatException)
            {
                MessageBox.Show("er staat een niet Product object in de lijst");
            }
            
            LaadUi();
        }
    }
}
