
namespace BudzetApp
{
    partial class formAnaliza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAnaliza = new System.Windows.Forms.RichTextBox();
            this.cmbValutaAnaliza = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnKatPrihodi = new System.Windows.Forms.RadioButton();
            this.rbtnKatRashodi = new System.Windows.Forms.RadioButton();
            this.btnIzbrisiKat = new System.Windows.Forms.Button();
            this.btnDodajKat = new System.Windows.Forms.Button();
            this.txtDodajKat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbAnaliza
            // 
            this.rtbAnaliza.Location = new System.Drawing.Point(14, 13);
            this.rtbAnaliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbAnaliza.Name = "rtbAnaliza";
            this.rtbAnaliza.ReadOnly = true;
            this.rtbAnaliza.Size = new System.Drawing.Size(405, 375);
            this.rtbAnaliza.TabIndex = 0;
            this.rtbAnaliza.Text = "";
            // 
            // cmbValutaAnaliza
            // 
            this.cmbValutaAnaliza.FormattingEnabled = true;
            this.cmbValutaAnaliza.Items.AddRange(new object[] {
            "HRK",
            "EUR",
            "USD",
            "GBP"});
            this.cmbValutaAnaliza.Location = new System.Drawing.Point(281, 415);
            this.cmbValutaAnaliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbValutaAnaliza.Name = "cmbValutaAnaliza";
            this.cmbValutaAnaliza.Size = new System.Drawing.Size(138, 28);
            this.cmbValutaAnaliza.TabIndex = 1;
            this.cmbValutaAnaliza.SelectedIndexChanged += new System.EventHandler(this.cmbValutaAnaliza_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valuta:";
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(14, 496);
            this.cmbKategorije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(136, 28);
            this.cmbKategorije.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorije:";
            // 
            // rbtnKatPrihodi
            // 
            this.rbtnKatPrihodi.AutoSize = true;
            this.rbtnKatPrihodi.Location = new System.Drawing.Point(14, 416);
            this.rbtnKatPrihodi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnKatPrihodi.Name = "rbtnKatPrihodi";
            this.rbtnKatPrihodi.Size = new System.Drawing.Size(77, 24);
            this.rbtnKatPrihodi.TabIndex = 5;
            this.rbtnKatPrihodi.TabStop = true;
            this.rbtnKatPrihodi.Text = "Prihodi";
            this.rbtnKatPrihodi.UseVisualStyleBackColor = true;
            this.rbtnKatPrihodi.CheckedChanged += new System.EventHandler(this.rbtnKatPrihodi_CheckedChanged);
            // 
            // rbtnKatRashodi
            // 
            this.rbtnKatRashodi.AutoSize = true;
            this.rbtnKatRashodi.Location = new System.Drawing.Point(14, 448);
            this.rbtnKatRashodi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnKatRashodi.Name = "rbtnKatRashodi";
            this.rbtnKatRashodi.Size = new System.Drawing.Size(83, 24);
            this.rbtnKatRashodi.TabIndex = 6;
            this.rbtnKatRashodi.TabStop = true;
            this.rbtnKatRashodi.Text = "Rashodi";
            this.rbtnKatRashodi.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiKat
            // 
            this.btnIzbrisiKat.Location = new System.Drawing.Point(12, 532);
            this.btnIzbrisiKat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzbrisiKat.Name = "btnIzbrisiKat";
            this.btnIzbrisiKat.Size = new System.Drawing.Size(138, 55);
            this.btnIzbrisiKat.TabIndex = 7;
            this.btnIzbrisiKat.Text = "Izbriši kategoriju";
            this.btnIzbrisiKat.UseVisualStyleBackColor = true;
            this.btnIzbrisiKat.Click += new System.EventHandler(this.btnIzbrisiKat_Click);
            // 
            // btnDodajKat
            // 
            this.btnDodajKat.Location = new System.Drawing.Point(183, 532);
            this.btnDodajKat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajKat.Name = "btnDodajKat";
            this.btnDodajKat.Size = new System.Drawing.Size(138, 55);
            this.btnDodajKat.TabIndex = 8;
            this.btnDodajKat.Text = "Dodaj kategoriju";
            this.btnDodajKat.UseVisualStyleBackColor = true;
            this.btnDodajKat.Click += new System.EventHandler(this.btnDodajKat_Click);
            // 
            // txtDodajKat
            // 
            this.txtDodajKat.Location = new System.Drawing.Point(183, 497);
            this.txtDodajKat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDodajKat.Name = "txtDodajKat";
            this.txtDodajKat.Size = new System.Drawing.Size(138, 27);
            this.txtDodajKat.TabIndex = 9;
            // 
            // formAnaliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 600);
            this.Controls.Add(this.txtDodajKat);
            this.Controls.Add(this.btnDodajKat);
            this.Controls.Add(this.btnIzbrisiKat);
            this.Controls.Add(this.rbtnKatRashodi);
            this.Controls.Add(this.rbtnKatPrihodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbValutaAnaliza);
            this.Controls.Add(this.rtbAnaliza);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formAnaliza";
            this.Text = "Analiza";
            this.Load += new System.EventHandler(this.formAnaliza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAnaliza;
        private System.Windows.Forms.ComboBox cmbValutaAnaliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnKatPrihodi;
        private System.Windows.Forms.RadioButton rbtnKatRashodi;
        private System.Windows.Forms.Button btnIzbrisiKat;
        private System.Windows.Forms.Button btnDodajKat;
        private System.Windows.Forms.TextBox txtDodajKat;
    }
}