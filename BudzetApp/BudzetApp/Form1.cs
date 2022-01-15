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

        public formAnaliza frmAnaliza = new formAnaliza();

        public class Transakcija
        {
            private string vrsta;
            private string opis;
            private double iznos = 0;
            private string valuta;
            private string kategorija;

            public string Vrsta { get => vrsta; set => vrsta = value; }
            public string Opis { get => opis; set => opis = value; }
            public double Iznos { get => iznos; set => iznos = value; }
            public string Valuta { get => valuta; set => valuta = value; }
            public string Kategorija { get => kategorija; set => kategorija = value; }

            public Transakcija(string _vrsta, string _opis, double _iznos, string _valuta, string _kategorija)
            {
                this.Vrsta = _vrsta;
                this.Opis = _opis;
                this.Iznos = _iznos;
                this.Valuta = _valuta;
                this.Kategorija = _kategorija;
            }
        }

        Dictionary<string, double> kategorijePrihoda = new Dictionary<string, double>() {
            { "posao", 0 },
            { "poklon", 0 },
            { "instrukcije", 0 }
        };
        Dictionary<string, double> kategorijeRashoda = new Dictionary<string, double>() {
            { "hrana", 0 },
            { "prijevoz", 0 },
            { "tehnologija", 0 },
            { "zabava", 0 },
            { "higijena", 0 }
        };

        private double total;

        List<Transakcija> transakcije = new List<Transakcija>();

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
            string kategorija;

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

            if (cmbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite kategoriju");
                return;
            }
            else
            {
                kategorija = cmbKategorija.Text;
            }
            

            Transakcija nova = new Transakcija(vrsta, opis, iznos, valuta, kategorija);

            transakcije.Add(nova);

            if (nova.Vrsta == "Prihod")
            {
                Total += nova.Iznos;
                kategorijePrihoda[nova.Kategorija] += nova.Iznos;
            }
            else
            {
                Total -= nova.Iznos;
                kategorijeRashoda[nova.Kategorija] += nova.Iznos;
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

        private void rbtnPrihod_CheckedChanged(object sender, EventArgs e)
        {
            cmbKategorija.Items.Clear();
            if (rbtnPrihod.Checked)
            {
                cmbKategorija.Items.AddRange(kategorijePrihoda.Keys.ToArray());
            }
            else
            {
                cmbKategorija.Items.AddRange(kategorijeRashoda.Keys.ToArray());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            frmAnaliza.ShowDialog();
        }
    }
}
