
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
            this.rbtnPrihod.Location = new System.Drawing.Point(46, 82);
            this.rbtnPrihod.Name = "rbtnPrihod";
            this.rbtnPrihod.Size = new System.Drawing.Size(73, 24);
            this.rbtnPrihod.TabIndex = 0;
            this.rbtnPrihod.TabStop = true;
            this.rbtnPrihod.Text = "Prihod";
            this.rbtnPrihod.UseVisualStyleBackColor = true;
            this.rbtnPrihod.CheckedChanged += new System.EventHandler(this.rbtnPrihod_CheckedChanged);
            // 
            // rbtnRashod
            // 
            this.rbtnRashod.AutoSize = true;
            this.rbtnRashod.Location = new System.Drawing.Point(46, 112);
            this.rbtnRashod.Name = "rbtnRashod";
            this.rbtnRashod.Size = new System.Drawing.Size(79, 24);
            this.rbtnRashod.TabIndex = 1;
            this.rbtnRashod.TabStop = true;
            this.rbtnRashod.Text = "Rashod";
            this.rbtnRashod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta troška:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iznos:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(70, 163);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(42, 20);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
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
            this.cmbValuta.Location = new System.Drawing.Point(118, 256);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(151, 28);
            this.cmbValuta.TabIndex = 6;
            this.cmbValuta.Text = "HRK";
            // 
            // txtBoxIznos
            // 
            this.txtBoxIznos.Location = new System.Drawing.Point(118, 209);
            this.txtBoxIznos.Name = "txtBoxIznos";
            this.txtBoxIznos.Size = new System.Drawing.Size(151, 27);
            this.txtBoxIznos.TabIndex = 7;
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.Location = new System.Drawing.Point(118, 159);
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(151, 27);
            this.txtBoxOpis.TabIndex = 8;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Enabled = false;
            this.rtbIspis.Location = new System.Drawing.Point(335, 12);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(429, 387);
            this.rtbIspis.TabIndex = 9;
            this.rtbIspis.Text = "";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(59, 319);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(94, 29);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(175, 319);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(94, 29);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ukupno:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(405, 415);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(0, 20);
            this.lblUkupno.TabIndex = 13;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(162, 79);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(125, 28);
            this.cmbKategorija.TabIndex = 14;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kategorija troška:";
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.Location = new System.Drawing.Point(118, 376);
            this.btnAnaliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(96, 41);
            this.btnAnaliza.TabIndex = 16;
            this.btnAnaliza.Text = "Analiza";
            this.btnAnaliza.UseVisualStyleBackColor = true;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 453);
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
            this.Name = "Form1";
            this.Text = "BudgetApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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

