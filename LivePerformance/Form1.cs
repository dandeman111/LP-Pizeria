using System;
using System.Windows.Forms;

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


    }
}
