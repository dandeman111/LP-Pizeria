using System;
using System.Windows.Forms;
using LivePerformance.Logic;

namespace LivePerformance
{
    public partial class Bon : Form
    {
        private BestelLogic bl;
        public Bon(BestelLogic bestelLogic)
        {
            InitializeComponent();
            bl = bestelLogic;
        }

        private void btnExporteer_Click(object sender, EventArgs e)
        { 
            bl.ExporteerBon();
            MessageBox.Show("De bon is opgeslagen als bon.txt");
        }
    }
}
