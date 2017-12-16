﻿namespace Autosausleihen
{
    partial class MainForm
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
            this.BTRegistrierung = new System.Windows.Forms.Button();
            this.BTLogIN = new System.Windows.Forms.Button();
            this.BTHinzufügen = new System.Windows.Forms.Button();
            this.TBLUsername = new System.Windows.Forms.TextBox();
            this.TBLPasswort = new System.Windows.Forms.TextBox();
            this.LBUsername = new System.Windows.Forms.Label();
            this.LBPasswort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTRegistrierung
            // 
            this.BTRegistrierung.BackColor = System.Drawing.Color.Transparent;
            this.BTRegistrierung.Location = new System.Drawing.Point(191, 302);
            this.BTRegistrierung.Margin = new System.Windows.Forms.Padding(4);
            this.BTRegistrierung.Name = "BTRegistrierung";
            this.BTRegistrierung.Size = new System.Drawing.Size(193, 32);
            this.BTRegistrierung.TabIndex = 4;
            this.BTRegistrierung.Text = "Jetzt Registrieren";
            this.BTRegistrierung.UseVisualStyleBackColor = false;
            this.BTRegistrierung.Click += new System.EventHandler(this.BTRegistrierung_Click);
            // 
            // BTLogIN
            // 
            this.BTLogIN.Location = new System.Drawing.Point(191, 266);
            this.BTLogIN.Margin = new System.Windows.Forms.Padding(4);
            this.BTLogIN.Name = "BTLogIN";
            this.BTLogIN.Size = new System.Drawing.Size(193, 28);
            this.BTLogIN.TabIndex = 3;
            this.BTLogIN.Text = "Einloggen";
            this.BTLogIN.UseVisualStyleBackColor = true;
            this.BTLogIN.Click += new System.EventHandler(this.BTLogIN_Click);
            // 
            // BTHinzufügen
            // 
            this.BTHinzufügen.Location = new System.Drawing.Point(224, 202);
            this.BTHinzufügen.Margin = new System.Windows.Forms.Padding(4);
            this.BTHinzufügen.Name = "BTHinzufügen";
            this.BTHinzufügen.Size = new System.Drawing.Size(131, 57);
            this.BTHinzufügen.TabIndex = 6;
            this.BTHinzufügen.Text = "Autos hinzufügen (Test)";
            this.BTHinzufügen.UseVisualStyleBackColor = true;
            this.BTHinzufügen.Click += new System.EventHandler(this.BTHinzufügen_Click);
            // 
            // TBLUsername
            // 
            this.TBLUsername.Location = new System.Drawing.Point(191, 68);
            this.TBLUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TBLUsername.Name = "TBLUsername";
            this.TBLUsername.Size = new System.Drawing.Size(192, 22);
            this.TBLUsername.TabIndex = 1;
            // 
            // TBLPasswort
            // 
            this.TBLPasswort.Location = new System.Drawing.Point(191, 138);
            this.TBLPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.TBLPasswort.Name = "TBLPasswort";
            this.TBLPasswort.Size = new System.Drawing.Size(192, 22);
            this.TBLPasswort.TabIndex = 2;
            this.TBLPasswort.UseSystemPasswordChar = true;
            // 
            // LBUsername
            // 
            this.LBUsername.AutoSize = true;
            this.LBUsername.BackColor = System.Drawing.Color.Transparent;
            this.LBUsername.Location = new System.Drawing.Point(105, 71);
            this.LBUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBUsername.Name = "LBUsername";
            this.LBUsername.Size = new System.Drawing.Size(77, 17);
            this.LBUsername.TabIndex = 6;
            this.LBUsername.Text = "Username:";
            // 
            // LBPasswort
            // 
            this.LBPasswort.AutoSize = true;
            this.LBPasswort.BackColor = System.Drawing.Color.Transparent;
            this.LBPasswort.Location = new System.Drawing.Point(112, 142);
            this.LBPasswort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBPasswort.Name = "LBPasswort";
            this.LBPasswort.Size = new System.Drawing.Size(69, 17);
            this.LBPasswort.TabIndex = 7;
            this.LBPasswort.Text = "Passwort:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Autosausleihen.Properties.Resources.AutoMainForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 383);
            this.Controls.Add(this.LBPasswort);
            this.Controls.Add(this.LBUsername);
            this.Controls.Add(this.TBLPasswort);
            this.Controls.Add(this.TBLUsername);
            this.Controls.Add(this.BTHinzufügen);
            this.Controls.Add(this.BTLogIN);
            this.Controls.Add(this.BTRegistrierung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 430);
            this.MinimumSize = new System.Drawing.Size(573, 430);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTRegistrierung;
        private System.Windows.Forms.Button BTLogIN;
        private System.Windows.Forms.Button BTHinzufügen;
        private System.Windows.Forms.TextBox TBLUsername;
        private System.Windows.Forms.TextBox TBLPasswort;
        private System.Windows.Forms.Label LBUsername;
        private System.Windows.Forms.Label LBPasswort;
    }
}