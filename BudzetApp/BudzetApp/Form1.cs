using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudzetApp
{
    

    public partial class Form1 : Form
    {
        public class Transakcija
        {
            private string vrsta;
            private string opis;
            private double iznos = 0;
            private string valuta;

            public string Vrsta { get => vrsta; set => vrsta = value; }
            public string Opis { get => opis; set => opis = value; }
            public double Iznos { get => iznos; set => iznos = value; }
            public string Valuta { get => valuta; set => valuta = value; }

            public Transakcija(string _vrsta, string _opis, double _iznos, string _valuta)
            {
                this.Vrsta = _vrsta;
                this.Opis = _opis;
                this.Iznos = _iznos;
                this.Valuta = _valuta;
            }
        }

        private double total;

        Dictionary<int, Transakcija> transakcije = new Dictionary<int, Transakcija>();

        public double Total { get => total; set => total = value; }

        public Form1()
        {
            InitializeComponent();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string vrsta;
            string opis;
            double iznos;
            string valuta;

            if (rbtnPrihod.Checked)
            {
                vrsta = "Prihod";
            }
            else if (rbtnRashod.Checked)
            {
                vrsta = "Rashod";
            }
            else
            {
                MessageBox.Show("Niste odabrali vrstu prihoda.");
                return;
            }

            opis = txtBoxOpis.Text;

            try
            {
                iznos = Math.Round(double.Parse(txtBoxIznos.Text),2);
            }
            catch
            {
                MessageBox.Show("Krivi unos iznosa.");
                return;
            }

            try
            {
                valuta = cmbValuta.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Krivi odabir valute.");
                return;
            }

            Transakcija nova = new Transakcija(vrsta, opis, iznos, valuta);

            transakcije.Add(transakcije.Count, nova);

            if (nova.Vrsta == "Prihod")
            {
                Total += nova.Iznos;
            }
            else
            {
                Total -= nova.Iznos;
            }

            rtbIspis.AppendText(nova.Vrsta + "\t " + nova.Opis + "\t " + nova.Iznos + "\t "+ nova.Valuta+"\n");
            lblUkupno.Text = Total + " HRK";

            rbtnPrihod.Checked = false;
            rbtnRashod.Checked = false;
            txtBoxOpis.Clear();
            txtBoxIznos.Clear();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {

        }
    }
}
