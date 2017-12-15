namespace Autosausleihen
{
    partial class Anmeldung
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
            this.LBName = new System.Windows.Forms.Label();
            this.LBVorname = new System.Windows.Forms.Label();
            this.TBRInsert = new System.Windows.Forms.Button();
            this.CBAGBs = new System.Windows.Forms.CheckBox();
            this.TBRName = new System.Windows.Forms.TextBox();
            this.TBRVorname = new System.Windows.Forms.TextBox();
            this.TBRTelefon = new System.Windows.Forms.TextBox();
            this.TBREmail = new System.Windows.Forms.TextBox();
            this.LBTelefon = new System.Windows.Forms.Label();
            this.LBEmail = new System.Windows.Forms.Label();
            this.TBRZahlung = new System.Windows.Forms.TextBox();
            this.TBROrt = new System.Windows.Forms.TextBox();
            this.LBZahlung = new System.Windows.Forms.Label();
            this.LBOrt = new System.Windows.Forms.Label();
            this.TBRPostleitzahl = new System.Windows.Forms.TextBox();
            this.TBRAdresse = new System.Windows.Forms.TextBox();
            this.LBPostleitzahl = new System.Windows.Forms.Label();
            this.LBAdresse = new System.Windows.Forms.Label();
            this.TBRPasswortW = new System.Windows.Forms.TextBox();
            this.TBRPasswort = new System.Windows.Forms.TextBox();
            this.LBPasswortW = new System.Windows.Forms.Label();
            this.LBPasswort = new System.Windows.Forms.Label();
            this.TBRUsername = new System.Windows.Forms.TextBox();
            this.LBUsername = new System.Windows.Forms.Label();
            this.LBSternchen = new System.Windows.Forms.Label();
            this.LBpwprüfen = new System.Windows.Forms.Label();
            this.LBpwlänge = new System.Windows.Forms.Label();
            this.BTNAgb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Location = new System.Drawing.Point(63, 54);
            this.LBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(50, 17);
            this.LBName.TabIndex = 0;
            this.LBName.Text = "Name*";
            // 
            // LBVorname
            // 
            this.LBVorname.AutoSize = true;
            this.LBVorname.Location = new System.Drawing.Point(63, 103);
            this.LBVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBVorname.Name = "LBVorname";
            this.LBVorname.Size = new System.Drawing.Size(65, 17);
            this.LBVorname.TabIndex = 1;
            this.LBVorname.Text = "Vorname";
            // 
            // TBRInsert
            // 
            this.TBRInsert.Location = new System.Drawing.Point(90, 476);
            this.TBRInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRInsert.Name = "TBRInsert";
            this.TBRInsert.Size = new System.Drawing.Size(100, 28);
            this.TBRInsert.TabIndex = 13;
            this.TBRInsert.Text = "Registrieren";
            this.TBRInsert.UseVisualStyleBackColor = true;
            this.TBRInsert.Click += new System.EventHandler(this.TBRInsert_Click);
            // 
            // CBAGBs
            // 
            this.CBAGBs.AutoSize = true;
            this.CBAGBs.Location = new System.Drawing.Point(68, 427);
            this.CBAGBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBAGBs.Name = "CBAGBs";
            this.CBAGBs.Size = new System.Drawing.Size(374, 21);
            this.CBAGBs.TabIndex = 12;
            this.CBAGBs.Text = "Ich stimme den AGBs zu und aktzeptiere ihre Kriterien.";
            this.CBAGBs.UseVisualStyleBackColor = true;
            this.CBAGBs.CheckedChanged += new System.EventHandler(this.CBAGBs_CheckedChanged);
            // 
            // TBRName
            // 
            this.TBRName.Location = new System.Drawing.Point(67, 74);
            this.TBRName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRName.Name = "TBRName";
            this.TBRName.Size = new System.Drawing.Size(132, 22);
            this.TBRName.TabIndex = 1;
            this.TBRName.TextChanged += new System.EventHandler(this.TBRName_TextChanged);
            // 
            // TBRVorname
            // 
            this.TBRVorname.Location = new System.Drawing.Point(67, 123);
            this.TBRVorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRVorname.Name = "TBRVorname";
            this.TBRVorname.Size = new System.Drawing.Size(132, 22);
            this.TBRVorname.TabIndex = 2;
            this.TBRVorname.TextChanged += new System.EventHandler(this.TBRVorname_TextChanged);
            // 
            // TBRTelefon
            // 
            this.TBRTelefon.Location = new System.Drawing.Point(228, 223);
            this.TBRTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRTelefon.Name = "TBRTelefon";
            this.TBRTelefon.Size = new System.Drawing.Size(132, 22);
            this.TBRTelefon.TabIndex = 4;
            this.TBRTelefon.TextChanged += new System.EventHandler(this.TBRTelefon_TextChanged);
            // 
            // TBREmail
            // 
            this.TBREmail.Location = new System.Drawing.Point(67, 171);
            this.TBREmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBREmail.Name = "TBREmail";
            this.TBREmail.Size = new System.Drawing.Size(132, 22);
            this.TBREmail.TabIndex = 3;
            this.TBREmail.TextChanged += new System.EventHandler(this.TBREmail_TextChanged);
            // 
            // LBTelefon
            // 
            this.LBTelefon.AutoSize = true;
            this.LBTelefon.Location = new System.Drawing.Point(224, 204);
            this.LBTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBTelefon.Name = "LBTelefon";
            this.LBTelefon.Size = new System.Drawing.Size(56, 17);
            this.LBTelefon.TabIndex = 8;
            this.LBTelefon.Text = "Telefon";
            // 
            // LBEmail
            // 
            this.LBEmail.AutoSize = true;
            this.LBEmail.Location = new System.Drawing.Point(63, 151);
            this.LBEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBEmail.Name = "LBEmail";
            this.LBEmail.Size = new System.Drawing.Size(47, 17);
            this.LBEmail.TabIndex = 7;
            this.LBEmail.Text = "Email*";
            // 
            // TBRZahlung
            // 
            this.TBRZahlung.Location = new System.Drawing.Point(227, 282);
            this.TBRZahlung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRZahlung.Name = "TBRZahlung";
            this.TBRZahlung.Size = new System.Drawing.Size(132, 22);
            this.TBRZahlung.TabIndex = 11;
            this.TBRZahlung.TextChanged += new System.EventHandler(this.TBRZahlung_TextChanged);
            // 
            // TBROrt
            // 
            this.TBROrt.Location = new System.Drawing.Point(228, 171);
            this.TBROrt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBROrt.Name = "TBROrt";
            this.TBROrt.Size = new System.Drawing.Size(132, 22);
            this.TBROrt.TabIndex = 10;
            this.TBROrt.TextChanged += new System.EventHandler(this.TBROrt_TextChanged);
            // 
            // LBZahlung
            // 
            this.LBZahlung.AutoSize = true;
            this.LBZahlung.Location = new System.Drawing.Point(223, 262);
            this.LBZahlung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBZahlung.Name = "LBZahlung";
            this.LBZahlung.Size = new System.Drawing.Size(161, 17);
            this.LBZahlung.TabIndex = 16;
            this.LBZahlung.Text = "PseudoZahlungsbetrag*";
            // 
            // LBOrt
            // 
            this.LBOrt.AutoSize = true;
            this.LBOrt.Location = new System.Drawing.Point(224, 152);
            this.LBOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBOrt.Name = "LBOrt";
            this.LBOrt.Size = new System.Drawing.Size(28, 17);
            this.LBOrt.TabIndex = 15;
            this.LBOrt.Text = "Ort";
            // 
            // TBRPostleitzahl
            // 
            this.TBRPostleitzahl.Location = new System.Drawing.Point(228, 128);
            this.TBRPostleitzahl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRPostleitzahl.Name = "TBRPostleitzahl";
            this.TBRPostleitzahl.Size = new System.Drawing.Size(132, 22);
            this.TBRPostleitzahl.TabIndex = 6;
            this.TBRPostleitzahl.TextChanged += new System.EventHandler(this.TBRPostleitzahl_TextChanged);
            // 
            // TBRAdresse
            // 
            this.TBRAdresse.Location = new System.Drawing.Point(228, 73);
            this.TBRAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRAdresse.Name = "TBRAdresse";
            this.TBRAdresse.Size = new System.Drawing.Size(132, 22);
            this.TBRAdresse.TabIndex = 5;
            this.TBRAdresse.TextChanged += new System.EventHandler(this.TBRAdresse_TextChanged);
            // 
            // LBPostleitzahl
            // 
            this.LBPostleitzahl.AutoSize = true;
            this.LBPostleitzahl.Location = new System.Drawing.Point(224, 108);
            this.LBPostleitzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBPostleitzahl.Name = "LBPostleitzahl";
            this.LBPostleitzahl.Size = new System.Drawing.Size(85, 17);
            this.LBPostleitzahl.TabIndex = 13;
            this.LBPostleitzahl.Text = "Postleitzahl*";
            // 
            // LBAdresse
            // 
            this.LBAdresse.AutoSize = true;
            this.LBAdresse.Location = new System.Drawing.Point(224, 54);
            this.LBAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBAdresse.Name = "LBAdresse";
            this.LBAdresse.Size = new System.Drawing.Size(65, 17);
            this.LBAdresse.TabIndex = 11;
            this.LBAdresse.Text = "Adresse*";
            // 
            // TBRPasswortW
            // 
            this.TBRPasswortW.Location = new System.Drawing.Point(67, 330);
            this.TBRPasswortW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRPasswortW.Name = "TBRPasswortW";
            this.TBRPasswortW.Size = new System.Drawing.Size(132, 22);
            this.TBRPasswortW.TabIndex = 9;
            this.TBRPasswortW.UseSystemPasswordChar = true;
            this.TBRPasswortW.TextChanged += new System.EventHandler(this.TBRPasswortW_TextChanged);
            // 
            // TBRPasswort
            // 
            this.TBRPasswort.Location = new System.Drawing.Point(67, 282);
            this.TBRPasswort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRPasswort.Name = "TBRPasswort";
            this.TBRPasswort.Size = new System.Drawing.Size(132, 22);
            this.TBRPasswort.TabIndex = 8;
            this.TBRPasswort.UseSystemPasswordChar = true;
            this.TBRPasswort.TextChanged += new System.EventHandler(this.TBRPasswort_TextChanged);
            // 
            // LBPasswortW
            // 
            this.LBPasswortW.AutoSize = true;
            this.LBPasswortW.Location = new System.Drawing.Point(63, 310);
            this.LBPasswortW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBPasswortW.Name = "LBPasswortW";
            this.LBPasswortW.Size = new System.Drawing.Size(150, 17);
            this.LBPasswortW.TabIndex = 21;
            this.LBPasswortW.Text = "Passwort wiederholen*";
            // 
            // LBPasswort
            // 
            this.LBPasswort.AutoSize = true;
            this.LBPasswort.Location = new System.Drawing.Point(63, 262);
            this.LBPasswort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBPasswort.Name = "LBPasswort";
            this.LBPasswort.Size = new System.Drawing.Size(70, 17);
            this.LBPasswort.TabIndex = 19;
            this.LBPasswort.Text = "Passwort*";
            // 
            // TBRUsername
            // 
            this.TBRUsername.Location = new System.Drawing.Point(67, 223);
            this.TBRUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBRUsername.Name = "TBRUsername";
            this.TBRUsername.Size = new System.Drawing.Size(132, 22);
            this.TBRUsername.TabIndex = 7;
            this.TBRUsername.TextChanged += new System.EventHandler(this.TBRUsername_TextChanged);
            // 
            // LBUsername
            // 
            this.LBUsername.AutoSize = true;
            this.LBUsername.Location = new System.Drawing.Point(63, 203);
            this.LBUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBUsername.Name = "LBUsername";
            this.LBUsername.Size = new System.Drawing.Size(78, 17);
            this.LBUsername.TabIndex = 24;
            this.LBUsername.Text = "Username*";
            // 
            // LBSternchen
            // 
            this.LBSternchen.AutoSize = true;
            this.LBSternchen.ForeColor = System.Drawing.Color.Crimson;
            this.LBSternchen.Location = new System.Drawing.Point(64, 407);
            this.LBSternchen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBSternchen.Name = "LBSternchen";
            this.LBSternchen.Size = new System.Drawing.Size(283, 17);
            this.LBSternchen.TabIndex = 25;
            this.LBSternchen.Text = "Die mit * markierten Felder sind Pflichtfelder";
            // 
            // LBpwprüfen
            // 
            this.LBpwprüfen.AutoSize = true;
            this.LBpwprüfen.ForeColor = System.Drawing.Color.Crimson;
            this.LBpwprüfen.Location = new System.Drawing.Point(64, 391);
            this.LBpwprüfen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBpwprüfen.Name = "LBpwprüfen";
            this.LBpwprüfen.Size = new System.Drawing.Size(246, 17);
            this.LBpwprüfen.TabIndex = 26;
            this.LBpwprüfen.Text = "Beide Passwörter müssen gleich sein.";
            this.LBpwprüfen.Visible = false;
            // 
            // LBpwlänge
            // 
            this.LBpwlänge.AutoSize = true;
            this.LBpwlänge.ForeColor = System.Drawing.Color.Crimson;
            this.LBpwlänge.Location = new System.Drawing.Point(64, 375);
            this.LBpwlänge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBpwlänge.Name = "LBpwlänge";
            this.LBpwlänge.Size = new System.Drawing.Size(295, 17);
            this.LBpwlänge.TabIndex = 27;
            this.LBpwlänge.Text = "Ihr Passwort muss mehr als 6 Zeichen haben,";
            this.LBpwlänge.Visible = false;
            // 
            // BTNAgb
            // 
            this.BTNAgb.Location = new System.Drawing.Point(250, 476);
            this.BTNAgb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNAgb.Name = "BTNAgb";
            this.BTNAgb.Size = new System.Drawing.Size(100, 28);
            this.BTNAgb.TabIndex = 28;
            this.BTNAgb.Text = "AGB";
            this.BTNAgb.UseVisualStyleBackColor = true;
            this.BTNAgb.Click += new System.EventHandler(this.BTNAgb_Click);
            // 
            // Anmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 545);
            this.Controls.Add(this.BTNAgb);
            this.Controls.Add(this.LBpwlänge);
            this.Controls.Add(this.LBpwprüfen);
            this.Controls.Add(this.LBSternchen);
            this.Controls.Add(this.LBUsername);
            this.Controls.Add(this.TBRUsername);
            this.Controls.Add(this.TBRPasswortW);
            this.Controls.Add(this.TBRPasswort);
            this.Controls.Add(this.LBPasswortW);
            this.Controls.Add(this.LBPasswort);
            this.Controls.Add(this.TBRZahlung);
            this.Controls.Add(this.TBROrt);
            this.Controls.Add(this.LBZahlung);
            this.Controls.Add(this.LBOrt);
            this.Controls.Add(this.TBRPostleitzahl);
            this.Controls.Add(this.TBRAdresse);
            this.Controls.Add(this.LBPostleitzahl);
            this.Controls.Add(this.LBAdresse);
            this.Controls.Add(this.TBRTelefon);
            this.Controls.Add(this.TBREmail);
            this.Controls.Add(this.LBTelefon);
            this.Controls.Add(this.LBEmail);
            this.Controls.Add(this.TBRVorname);
            this.Controls.Add(this.TBRName);
            this.Controls.Add(this.CBAGBs);
            this.Controls.Add(this.TBRInsert);
            this.Controls.Add(this.LBVorname);
            this.Controls.Add(this.LBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 592);
            this.MinimumSize = new System.Drawing.Size(510, 592);
            this.Name = "Anmeldung";
            this.ShowIcon = false;
            this.Text = "Registrieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBVorname;
        private System.Windows.Forms.Button TBRInsert;
        private System.Windows.Forms.CheckBox CBAGBs;
        private System.Windows.Forms.TextBox TBRName;
        private System.Windows.Forms.TextBox TBRVorname;
        private System.Windows.Forms.TextBox TBRTelefon;
        private System.Windows.Forms.TextBox TBREmail;
        private System.Windows.Forms.Label LBTelefon;
        private System.Windows.Forms.Label LBEmail;
        private System.Windows.Forms.TextBox TBRZahlung;
        private System.Windows.Forms.TextBox TBROrt;
        private System.Windows.Forms.Label LBZahlung;
        private System.Windows.Forms.Label LBOrt;
        private System.Windows.Forms.TextBox TBRPostleitzahl;
        private System.Windows.Forms.TextBox TBRAdresse;
        private System.Windows.Forms.Label LBPostleitzahl;
        private System.Windows.Forms.Label LBAdresse;
        private System.Windows.Forms.TextBox TBRPasswortW;
        private System.Windows.Forms.TextBox TBRPasswort;
        private System.Windows.Forms.Label LBPasswortW;
        private System.Windows.Forms.Label LBPasswort;
        private System.Windows.Forms.TextBox TBRUsername;
        private System.Windows.Forms.Label LBUsername;
        private System.Windows.Forms.Label LBSternchen;
        private System.Windows.Forms.Label LBpwprüfen;
        private System.Windows.Forms.Label LBpwlänge;
        private System.Windows.Forms.Button BTNAgb;
    }
}