
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
            "BAM",
            "USD",
            "GBP"});
            this.cmbValutaAnaliza.Location = new System.Drawing.Point(372, 44);
            this.cmbValutaAnaliza.Name = "cmbValutaAnaliza";
            this.cmbValutaAnaliza.Size = new System.Drawing.Size(121, 23);
            this.cmbValutaAnaliza.TabIndex = 1;
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
            // formAnaliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
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
    }
}