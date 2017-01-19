using System;
using System.IO;
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
            try
            {
                bl.ExporteerBon();
                MessageBox.Show("De bon is opgeslagen als bon.txt");
            }
            catch (IOException)
            {
                MessageBox.Show("Het bestand kon niet worden weggeschreven");
            }
            
        }
    }
}
