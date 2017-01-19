namespace LivePerformance
{
    partial class BeheerForm
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.chbAlcohol = new System.Windows.Forms.CheckBox();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.Toevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInNaam = new System.Windows.Forms.TextBox();
            this.tbInPrijs = new System.Windows.Forms.TextBox();
            this.cbInHalal = new System.Windows.Forms.CheckBox();
            this.cbInVeg = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(20, 27);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(45, 17);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(20, 89);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(35, 17);
            this.lblPrijs.TabIndex = 1;
            this.lblPrijs.Text = "Prijs";
            this.lblPrijs.Click += new System.EventHandler(this.label1_Click);
            // 
            // chbAlcohol
            // 
            this.chbAlcohol.AutoSize = true;
            this.chbAlcohol.Location = new System.Drawing.Point(156, 142);
            this.chbAlcohol.Name = "chbAlcohol";
            this.chbAlcohol.Size = new System.Drawing.Size(18, 17);
            this.chbAlcohol.TabIndex = 2;
            this.chbAlcohol.UseVisualStyleBackColor = true;
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Location = new System.Drawing.Point(20, 142);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(93, 17);
            this.lblAlcohol.TabIndex = 3;
            this.lblAlcohol.Text = "Bevat alcohol";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(156, 27);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 22);
            this.tbNaam.TabIndex = 4;
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(156, 86);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 22);
            this.tbPrijs.TabIndex = 5;
            // 
            // Toevoegen
            // 
            this.Toevoegen.Location = new System.Drawing.Point(37, 232);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(149, 60);
            this.Toevoegen.TabIndex = 6;
            this.Toevoegen.Text = "Product toevoegen";
            this.Toevoegen.UseVisualStyleBackColor = true;
            this.Toevoegen.Click += new System.EventHandler(this.Toevoegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Halal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Veganistisch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prijs";
            // 
            // tbInNaam
            // 
            this.tbInNaam.Location = new System.Drawing.Point(504, 51);
            this.tbInNaam.Name = "tbInNaam";
            this.tbInNaam.Size = new System.Drawing.Size(100, 22);
            this.tbInNaam.TabIndex = 12;
            // 
            // tbInPrijs
            // 
            this.tbInPrijs.Location = new System.Drawing.Point(504, 112);
            this.tbInPrijs.Name = "tbInPrijs";
            this.tbInPrijs.Size = new System.Drawing.Size(100, 22);
            this.tbInPrijs.TabIndex = 13;
            // 
            // cbInHalal
            // 
            this.cbInHalal.AutoSize = true;
            this.cbInHalal.Location = new System.Drawing.Point(523, 191);
            this.cbInHalal.Name = "cbInHalal";
            this.cbInHalal.Size = new System.Drawing.Size(18, 17);
            this.cbInHalal.TabIndex = 14;
            this.cbInHalal.UseVisualStyleBackColor = true;
            // 
            // cbInVeg
            // 
            this.cbInVeg.AutoSize = true;
            this.cbInVeg.Location = new System.Drawing.Point(523, 259);
            this.cbInVeg.Name = "cbInVeg";
            this.cbInVeg.Size = new System.Drawing.Size(18, 17);
            this.cbInVeg.TabIndex = 15;
            this.cbInVeg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ingredient toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.AccessibleName = "";
            this.pnlProduct.Controls.Add(this.Toevoegen);
            this.pnlProduct.Controls.Add(this.tbPrijs);
            this.pnlProduct.Controls.Add(this.tbNaam);
            this.pnlProduct.Controls.Add(this.lblAlcohol);
            this.pnlProduct.Controls.Add(this.chbAlcohol);
            this.pnlProduct.Controls.Add(this.lblPrijs);
            this.pnlProduct.Controls.Add(this.lblNaam);
            this.pnlProduct.Location = new System.Drawing.Point(28, 21);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(314, 365);
            this.pnlProduct.TabIndex = 17;
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 436);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbInVeg);
            this.Controls.Add(this.cbInHalal);
            this.Controls.Add(this.tbInPrijs);
            this.Controls.Add(this.tbInNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BeheerForm";
            this.Text = "BeheerForm";
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.CheckBox chbAlcohol;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.Button Toevoegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInNaam;
        private System.Windows.Forms.TextBox tbInPrijs;
        private System.Windows.Forms.CheckBox cbInHalal;
        private System.Windows.Forms.CheckBox cbInVeg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlProduct;
    }
}