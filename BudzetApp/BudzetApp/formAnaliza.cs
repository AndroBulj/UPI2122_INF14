using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BudzetApp
{
    public partial class formAnaliza : Form
    {
        public string valutaAnaliza = "HRK";

        public formAnaliza()
        {
            InitializeComponent();
        }


        private void formAnaliza_Load(object sender, EventArgs e)
        {
            double totalPrihoda = Form1.totalPrihoda;
            double totalRashoda = Form1.totalRashoda;

            rtbAnaliza.AppendText("Prihodi: \n");
            foreach (KeyValuePair<string, double> kategorija in Form1.kategorijePrihoda)
            {
                rtbAnaliza.AppendText(kategorija.Key + " :\t\t" + kategorija.Value + " " + valutaAnaliza + 
                    "\t" + Math.Round( (kategorija.Value/totalPrihoda)*100, 2) + "%" + "\n");
            }

            rtbAnaliza.AppendText("Rashodi: \n");
            foreach (KeyValuePair<string, double> kategorija in Form1.kategorijeRashoda)
            {
                rtbAnaliza.AppendText(kategorija.Key + " :\t\t" + kategorija.Value + " " + valutaAnaliza +
                    "\t" + Math.Round( (kategorija.Value/totalRashoda)*100, 2 ) + "%" + "\n");
            }

        }
    }
}
