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

namespace LivePerformance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BestelForm b = new BestelForm();
            b.ShowDialog();
        }

        private void btnPrToevoegen_Click(object sender, EventArgs e)
        {
            BeheerForm form = new BeheerForm();
            form.ShowDialog();
        }

        private void btnInToevoegen_Click(object sender, EventArgs e)
        {

        }
    }
}
