
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
            this.rtbAnaliza.Location = new System.Drawing.Point(12, 21);
            this.rtbAnaliza.Name = "rtbAnaliza";
            this.rtbAnaliza.Size = new System.Drawing.Size(326, 244);
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
            this.cmbValutaAnaliza.Location = new System.Drawing.Point(372, 44);
            this.cmbValutaAnaliza.Name = "cmbValutaAnaliza";
            this.cmbValutaAnaliza.Size = new System.Drawing.Size(121, 23);
            this.cmbValutaAnaliza.TabIndex = 1;
            this.cmbValutaAnaliza.SelectedIndexChanged += new System.EventHandler(this.cmbValutaAnaliza_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valuta:";
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(12, 357);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(121, 23);
            this.cmbKategorije.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorije:";
            // 
            // rbtnKatPrihodi
            // 
            this.rbtnKatPrihodi.AutoSize = true;
            this.rbtnKatPrihodi.Location = new System.Drawing.Point(12, 307);
            this.rbtnKatPrihodi.Name = "rbtnKatPrihodi";
            this.rbtnKatPrihodi.Size = new System.Drawing.Size(63, 19);
            this.rbtnKatPrihodi.TabIndex = 5;
            this.rbtnKatPrihodi.TabStop = true;
            this.rbtnKatPrihodi.Text = "Prihodi";
            this.rbtnKatPrihodi.UseVisualStyleBackColor = true;
            this.rbtnKatPrihodi.CheckedChanged += new System.EventHandler(this.rbtnKatPrihodi_CheckedChanged);
            // 
            // rbtnKatRashodi
            // 
            this.rbtnKatRashodi.AutoSize = true;
            this.rbtnKatRashodi.Location = new System.Drawing.Point(12, 332);
            this.rbtnKatRashodi.Name = "rbtnKatRashodi";
            this.rbtnKatRashodi.Size = new System.Drawing.Size(67, 19);
            this.rbtnKatRashodi.TabIndex = 6;
            this.rbtnKatRashodi.TabStop = true;
            this.rbtnKatRashodi.Text = "Rashodi";
            this.rbtnKatRashodi.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiKat
            // 
            this.btnIzbrisiKat.Location = new System.Drawing.Point(12, 397);
            this.btnIzbrisiKat.Name = "btnIzbrisiKat";
            this.btnIzbrisiKat.Size = new System.Drawing.Size(75, 41);
            this.btnIzbrisiKat.TabIndex = 7;
            this.btnIzbrisiKat.Text = "Izbriši kategoriju";
            this.btnIzbrisiKat.UseVisualStyleBackColor = true;
            this.btnIzbrisiKat.Click += new System.EventHandler(this.btnIzbrisiKat_Click);
            // 
            // btnDodajKat
            // 
            this.btnDodajKat.Location = new System.Drawing.Point(160, 397);
            this.btnDodajKat.Name = "btnDodajKat";
            this.btnDodajKat.Size = new System.Drawing.Size(75, 41);
            this.btnDodajKat.TabIndex = 8;
            this.btnDodajKat.Text = "Dodaj kategoriju";
            this.btnDodajKat.UseVisualStyleBackColor = true;
            this.btnDodajKat.Click += new System.EventHandler(this.btnDodajKat_Click);
            // 
            // txtDodajKat
            // 
            this.txtDodajKat.Location = new System.Drawing.Point(160, 357);
            this.txtDodajKat.Name = "txtDodajKat";
            this.txtDodajKat.Size = new System.Drawing.Size(100, 23);
            this.txtDodajKat.TabIndex = 9;
            // 
            // formAnaliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
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
            this.Name = "formAnaliza";
            this.Text = "formAnaliza";
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