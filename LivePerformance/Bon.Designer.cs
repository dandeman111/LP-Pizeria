namespace LivePerformance
{
    partial class Bon
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
            this.lblBestellingGelukt = new System.Windows.Forms.Label();
            this.btnExporteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBestellingGelukt
            // 
            this.lblBestellingGelukt.AutoSize = true;
            this.lblBestellingGelukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellingGelukt.Location = new System.Drawing.Point(131, 82);
            this.lblBestellingGelukt.Name = "lblBestellingGelukt";
            this.lblBestellingGelukt.Size = new System.Drawing.Size(269, 31);
            this.lblBestellingGelukt.TabIndex = 0;
            this.lblBestellingGelukt.Text = "Bestelling is geplaats";
            // 
            // btnExporteer
            // 
            this.btnExporteer.Location = new System.Drawing.Point(213, 228);
            this.btnExporteer.Name = "btnExporteer";
            this.btnExporteer.Size = new System.Drawing.Size(129, 66);
            this.btnExporteer.TabIndex = 1;
            this.btnExporteer.Text = "Exporteer Bon";
            this.btnExporteer.UseVisualStyleBackColor = true;
            this.btnExporteer.Click += new System.EventHandler(this.btnExporteer_Click);
            // 
            // Bon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 416);
            this.Controls.Add(this.btnExporteer);
            this.Controls.Add(this.lblBestellingGelukt);
            this.Name = "Bon";
            this.Text = "Bon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBestellingGelukt;
        private System.Windows.Forms.Button btnExporteer;
    }
}