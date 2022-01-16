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
        public formAnaliza()
        {
            InitializeComponent();
        }

        public void IspisAnalize()
        {
            double totalPrihoda = Form1.totalPrihoda;
            double totalRashoda = Form1.totalRashoda;

            rtbAnaliza.Clear();
            
            rtbAnaliza.AppendText("Prihodi: \n");
            foreach (KeyValuePair<string, double> kategorija in Form1.kategorijePrihoda)
            {
                rtbAnaliza.AppendText(kategorija.Key + " :\t" 
                    + Math.Round(kategorija.Value*koeficijentKonverzije, 2) + " " + valutaAnaliza + "\t" 
                    + Math.Round((kategorija.Value / totalPrihoda) * 100, 2) + "%" + "\n");
            }

            rtbAnaliza.AppendText("Rashodi: \n");
            foreach (KeyValuePair<string, double> kategorija in Form1.kategorijeRashoda)
            {
                rtbAnaliza.AppendText(kategorija.Key + " :\t" 
                    + Math.Round(kategorija.Value*koeficijentKonverzije, 2) + " " + valutaAnaliza + "\t" 
                    + Math.Round((kategorija.Value / totalRashoda) * 100, 2) + "%" + "\n");
            }
        }

        string valutaAnaliza = "HRK";
        double koeficijentKonverzije = 1;

        private void formAnaliza_Load(object sender, EventArgs e)
        {
            
            double totalPrihoda = Form1.totalPrihoda;
            double totalRashoda = Form1.totalRashoda;
            koeficijentKonverzije = 1;
            valutaAnaliza = "HRK";
            IspisAnalize();

        }

        private void cmbValutaAnaliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbValutaAnaliza.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                rtbAnaliza.Clear();
                string novaValuta = cmbValutaAnaliza.Items[cmbValutaAnaliza.SelectedIndex].ToString();
                koeficijentKonverzije = Form1.konverzije["HRK" + novaValuta];
                valutaAnaliza = novaValuta;
                IspisAnalize();

            }

        }
    }
}
