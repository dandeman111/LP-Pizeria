using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.DAL.Contexten.Mssql;
using LivePerformance.DAL.Models;
using LivePerformance.DAL.Repositories;
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
            b.plaatsBestelling();
            LaadUi();
            Bon formbon = new Bon(b);
            formbon.ShowDialog();
            this.Close();
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
            lblPrjs.Text = "Prijs; " + b.geefPrijs()+ "Euro";
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            b.VoegPizzaToe((Pizza)LbPizza.SelectedItem);
            LaadUi();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            b.VoegProductToe((Product)LbProducts.SelectedItem);
            LaadUi();
        }
    }
}
