﻿namespace Ingeproject
{
    partial class registrationForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeUD = new System.Windows.Forms.NumericUpDown();
            this.ValidBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeUD)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(114, 49);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 0;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // AgeUD
            // 
            this.AgeUD.Location = new System.Drawing.Point(114, 111);
            this.AgeUD.Name = "AgeUD";
            this.AgeUD.Size = new System.Drawing.Size(100, 20);
            this.AgeUD.TabIndex = 4;
            this.AgeUD.ValueChanged += new System.EventHandler(this.AgeUD_ValueChanged);
            // 
            // ValidBtn
            // 
            this.ValidBtn.Location = new System.Drawing.Point(114, 176);
            this.ValidBtn.Name = "ValidBtn";
            this.ValidBtn.Size = new System.Drawing.Size(100, 23);
            this.ValidBtn.TabIndex = 5;
            this.ValidBtn.Text = "Valider";
            this.ValidBtn.UseVisualStyleBackColor = true;
            this.ValidBtn.Click += new System.EventHandler(this.ValidBtn_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 241);
            this.Controls.Add(this.ValidBtn);
            this.Controls.Add(this.AgeUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Name = "registrationForm";
            this.Text = "registrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.AgeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AgeUD;
        private System.Windows.Forms.Button ValidBtn;
    }
}