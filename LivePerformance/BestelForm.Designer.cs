namespace LivePerformance
{
    partial class BestelForm
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
            this.LbPizza = new System.Windows.Forms.ListBox();
            this.LbProducts = new System.Windows.Forms.ListBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblOverig = new System.Windows.Forms.Label();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.lblBestelling = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrjs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbPizza
            // 
            this.LbPizza.FormattingEnabled = true;
            this.LbPizza.ItemHeight = 16;
            this.LbPizza.Location = new System.Drawing.Point(12, 40);
            this.LbPizza.Name = "LbPizza";
            this.LbPizza.Size = new System.Drawing.Size(285, 180);
            this.LbPizza.TabIndex = 0;
            // 
            // LbProducts
            // 
            this.LbProducts.FormattingEnabled = true;
            this.LbProducts.ItemHeight = 16;
            this.LbProducts.Location = new System.Drawing.Point(16, 266);
            this.LbProducts.Name = "LbProducts";
            this.LbProducts.Size = new System.Drawing.Size(281, 180);
            this.LbProducts.TabIndex = 1;
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(13, 13);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(56, 17);
            this.lblPizza.TabIndex = 2;
            this.lblPizza.Text = "Pizza\'s;";
            // 
            // lblOverig
            // 
            this.lblOverig.AutoSize = true;
            this.lblOverig.Location = new System.Drawing.Point(15, 246);
            this.lblOverig.Name = "lblOverig";
            this.lblOverig.Size = new System.Drawing.Size(54, 17);
            this.lblOverig.TabIndex = 3;
            this.lblOverig.Text = "Overig;";
            this.lblOverig.Click += new System.EventHandler(this.lblOverig_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(324, 178);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(88, 42);
            this.btnPizza.TabIndex = 4;
            this.btnPizza.Text = "Voeg toe";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(324, 404);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(88, 42);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Voeg toe";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lbBestelling
            // 
            this.lbBestelling.FormattingEnabled = true;
            this.lbBestelling.ItemHeight = 16;
            this.lbBestelling.Location = new System.Drawing.Point(486, 31);
            this.lbBestelling.Name = "lbBestelling";
            this.lbBestelling.Size = new System.Drawing.Size(312, 372);
            this.lbBestelling.TabIndex = 6;
            // 
            // lblBestelling
            // 
            this.lblBestelling.AutoSize = true;
            this.lblBestelling.Location = new System.Drawing.Point(483, 13);
            this.lblBestelling.Name = "lblBestelling";
            this.lblBestelling.Size = new System.Drawing.Size(73, 17);
            this.lblBestelling.TabIndex = 7;
            this.lblBestelling.Text = "Bestelling;";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Plaats bestelling";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrjs
            // 
            this.lblPrjs.AutoSize = true;
            this.lblPrjs.Location = new System.Drawing.Point(483, 419);
            this.lblPrjs.Name = "lblPrjs";
            this.lblPrjs.Size = new System.Drawing.Size(35, 17);
            this.lblPrjs.TabIndex = 9;
            this.lblPrjs.Text = "Prijs";
            // 
            // BestelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 461);
            this.Controls.Add(this.lblPrjs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBestelling);
            this.Controls.Add(this.lbBestelling);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.lblOverig);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.LbProducts);
            this.Controls.Add(this.LbPizza);
            this.Name = "BestelForm";
            this.Text = "BestelForm";
            this.Load += new System.EventHandler(this.BestelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbPizza;
        private System.Windows.Forms.ListBox LbProducts;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblOverig;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.ListBox lbBestelling;
        private System.Windows.Forms.Label lblBestelling;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrjs;
    }
}