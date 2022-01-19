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
            
            rtbAnaliza.AppendText("\"Prihodi\" \n");
            foreach (KeyValuePair<string, double> kategorija in Form1.kategorijePrihoda)
            {
                rtbAnaliza.AppendText(kategorija.Key + ":\n" 
                    + Math.Round(kategorija.Value*koeficijentKonverzije, 2) + " " + valutaAnaliza + "     " 
                    + Math.Round((kategorija.Value / totalPrihoda) * 100, 2) + "%" + "\n\n");
            }

            rtbAnaliza.AppendText("________________________________\n\n\"Rashodi\" \n");
            foreach (KeyValuePair<string, double> kategorija in Form1.kategorijeRashoda)
            {
                rtbAnaliza.AppendText(kategorija.Key + " :\n" 
                    + Math.Round(kategorija.Value*koeficijentKonverzije, 2) + " " + valutaAnaliza + "     " 
                    + Math.Round((kategorija.Value / totalRashoda) * 100, 2) + "%" + "\n\n");
            }
        }

        string valutaAnaliza = "HRK";
        double koeficijentKonverzije = 1;

        private void formAnaliza_Load(object sender, EventArgs e)
        {
            
            koeficijentKonverzije = 1;
            valutaAnaliza = "HRK";
            rbtnKatPrihodi.Checked = true;
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

        private void rbtnKatPrihodi_CheckedChanged(object sender, EventArgs e)
        {
            cmbKategorije.Items.Clear();

            if (rbtnKatPrihodi.Checked)
            {
                foreach (KeyValuePair<string, double> kategorija in Form1.kategorijePrihoda)
                {
                    cmbKategorije.Items.Add(kategorija.Key);
                }
            }
            else
            {
                foreach (KeyValuePair<string, double> kategorija in Form1.kategorijeRashoda)
                {
                    cmbKategorije.Items.Add(kategorija.Key);
                }
            }
        }

        private void btnIzbrisiKat_Click(object sender, EventArgs e)
        {
            if (cmbKategorije.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite kategoriju za brisanje!");
                return;
            }

            string kategorijaZaBrisanje = cmbKategorije.SelectedItem.ToString();

            if (rbtnKatPrihodi.Checked)
            {
                if (Form1.kategorijePrihoda[kategorijaZaBrisanje] != 0)
                {
                    MessageBox.Show("Nije moguće izbrisati kategoriju koja nije prazna!");
                    return;
                }
                else
                {
                    Form1.kategorijePrihoda.Remove(kategorijaZaBrisanje);
                    MessageBox.Show("Kategorija uspješno izbrisana!");
                }
            }
            else
            {
                if (Form1.kategorijeRashoda[kategorijaZaBrisanje] != 0)
                {
                    MessageBox.Show("Nije moguće izbrisati kategoriju koja nije prazna!");
                    return;
                }
                else
                {
                    Form1.kategorijeRashoda.Remove(kategorijaZaBrisanje);
                    MessageBox.Show("Kategorija uspješno izbrisana!");
                }
            }

            rbtnKatPrihodi.Checked = false;
            rbtnKatPrihodi.Checked = true;
            cmbKategorije.Text = "";
            txtDodajKat.Text = "";
            IspisAnalize();
        }

        public void btnDodajKat_Click(object sender, EventArgs e)
        {
            if (txtDodajKat.Text == "")
            {
                MessageBox.Show("Napišite ime kategorije koju želite dodati");
                return;
            }

            string kategorijaZaDodati = txtDodajKat.Text;

            if (rbtnKatPrihodi.Checked)
            {
                if (Form1.kategorijePrihoda.ContainsKey(kategorijaZaDodati))
                {
                    MessageBox.Show("Kategorija već postoji!");
                    return;
                }
                else
                {
                    Form1.kategorijePrihoda.Add(kategorijaZaDodati, 0);
                    MessageBox.Show("Kategorija uspješno dodana!");
                }
            }
            else
            {
                if (Form1.kategorijeRashoda.ContainsKey(kategorijaZaDodati))
                {
                    MessageBox.Show("Kategorija već postoji!");
                    return;
                }
                else
                {
                    Form1.kategorijeRashoda.Add(kategorijaZaDodati, 0);
                    MessageBox.Show("Kategorija uspješno dodana!");
                }
            }

            rbtnKatPrihodi.Checked = false;
            rbtnKatRashodi.Checked = false;
            cmbKategorije.Text = "";
            txtDodajKat.Text = "";
            IspisAnalize();
        }
    }
}
