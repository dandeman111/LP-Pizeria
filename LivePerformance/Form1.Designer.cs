﻿namespace LivePerformance
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 113);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bestelling plaatsen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrToevoegen
            // 
            this.btnPrToevoegen.Location = new System.Drawing.Point(328, 121);
            this.btnPrToevoegen.Name = "btnPrToevoegen";
            this.btnPrToevoegen.Size = new System.Drawing.Size(148, 113);
            this.btnPrToevoegen.TabIndex = 1;
            this.btnPrToevoegen.Text = "Product beheer";
            this.btnPrToevoegen.UseVisualStyleBackColor = true;
            this.btnPrToevoegen.Click += new System.EventHandler(this.btnPrToevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 402);
            this.Controls.Add(this.btnPrToevoegen);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hoofdscherm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrToevoegen;
    }
}

