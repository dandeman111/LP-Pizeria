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
            ProductMssql pd = new ProductMssql();
            MessageBox.Show(pd.GetAll()[0].Naam);
            MessageBox.Show(pd.GetAll()[1].Naam);
        }
    }
}
