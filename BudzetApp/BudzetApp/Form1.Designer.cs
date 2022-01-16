
namespace BudzetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnPrihod = new System.Windows.Forms.RadioButton();
            this.rbtnRashod = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.txtBoxIznos = new System.Windows.Forms.TextBox();
            this.txtBoxOpis = new System.Windows.Forms.TextBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnPrihod
            // 
            this.rbtnPrihod.AutoSize = true;
            this.rbtnPrihod.Location = new System.Drawing.Point(61, 62);
            this.rbtnPrihod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPrihod.Name = "rbtnPrihod";
            this.rbtnPrihod.Size = new System.Drawing.Size(60, 19);
            this.rbtnPrihod.TabIndex = 0;
            this.rbtnPrihod.TabStop = true;
            this.rbtnPrihod.Text = "Prihod";
            this.rbtnPrihod.UseVisualStyleBackColor = true;
            this.rbtnPrihod.CheckedChanged += new System.EventHandler(this.rbtnPrihod_CheckedChanged);
            // 
            // rbtnRashod
            // 
            this.rbtnRashod.AutoSize = true;
            this.rbtnRashod.Location = new System.Drawing.Point(61, 84);
            this.rbtnRashod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnRashod.Name = "rbtnRashod";
            this.rbtnRashod.Size = new System.Drawing.Size(64, 19);
            this.rbtnRashod.TabIndex = 1;
            this.rbtnRashod.TabStop = true;
            this.rbtnRashod.Text = "Rashod";
            this.rbtnRashod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta troška:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iznos:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(61, 122);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(34, 15);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valuta:";
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Items.AddRange(new object[] {
            "HRK",
            "EUR",
            "USD",
            "GBP"});
            this.cmbValuta.Location = new System.Drawing.Point(103, 192);
            this.cmbValuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(133, 23);
            this.cmbValuta.TabIndex = 6;
            this.cmbValuta.Text = "HRK";
            // 
            // txtBoxIznos
            // 
            this.txtBoxIznos.Location = new System.Drawing.Point(103, 157);
            this.txtBoxIznos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxIznos.Name = "txtBoxIznos";
            this.txtBoxIznos.Size = new System.Drawing.Size(110, 23);
            this.txtBoxIznos.TabIndex = 7;
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.Location = new System.Drawing.Point(103, 119);
            this.txtBoxOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(110, 23);
            this.txtBoxOpis.TabIndex = 8;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Enabled = false;
            this.rtbIspis.Location = new System.Drawing.Point(293, 9);
            this.rtbIspis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(376, 291);
            this.rtbIspis.TabIndex = 9;
            this.rtbIspis.Text = "";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(52, 239);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 22);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(153, 239);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 22);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ukupno:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(354, 311);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(0, 15);
            this.lblUkupno.TabIndex = 13;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(142, 62);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(94, 23);
            this.cmbKategorija.TabIndex = 14;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kategorija troška:";
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.Location = new System.Drawing.Point(103, 277);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(75, 23);
            this.btnAnaliza.TabIndex = 16;
            this.btnAnaliza.Text = "Analiza";
            this.btnAnaliza.UseVisualStyleBackColor = true;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 340);
            this.Controls.Add(this.btnAnaliza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.txtBoxOpis);
            this.Controls.Add(this.txtBoxIznos);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnRashod);
            this.Controls.Add(this.rbtnPrihod);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BudgetApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnPrihod;
        private System.Windows.Forms.RadioButton rbtnRashod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.TextBox txtBoxIznos;
        private System.Windows.Forms.TextBox txtBoxOpis;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnaliza;
    }
}

