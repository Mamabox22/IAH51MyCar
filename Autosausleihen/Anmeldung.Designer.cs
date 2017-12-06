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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anmeldung));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBRInsert = new System.Windows.Forms.Button();
            this.CBAGBs = new System.Windows.Forms.CheckBox();
            this.TBRName = new System.Windows.Forms.TextBox();
            this.TBRVorname = new System.Windows.Forms.TextBox();
            this.TBRTelefon = new System.Windows.Forms.TextBox();
            this.TBREmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBRZahlung = new System.Windows.Forms.TextBox();
            this.TBROrt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBRPostleitzahl = new System.Windows.Forms.TextBox();
            this.TBRAdresse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBRPasswortW = new System.Windows.Forms.TextBox();
            this.TBRPasswort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PBWerbung = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBWerbung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname";
            // 
            // TBRInsert
            // 
            this.TBRInsert.Location = new System.Drawing.Point(421, 405);
            this.TBRInsert.Name = "TBRInsert";
            this.TBRInsert.Size = new System.Drawing.Size(75, 23);
            this.TBRInsert.TabIndex = 2;
            this.TBRInsert.Text = "Registrieren";
            this.TBRInsert.UseVisualStyleBackColor = true;
            this.TBRInsert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CBAGBs
            // 
            this.CBAGBs.AutoSize = true;
            this.CBAGBs.Location = new System.Drawing.Point(322, 357);
            this.CBAGBs.Name = "CBAGBs";
            this.CBAGBs.Size = new System.Drawing.Size(281, 17);
            this.CBAGBs.TabIndex = 4;
            this.CBAGBs.Text = "Ich stimme den AGBs zu und aktzeptiere ihre Kriterien.";
            this.CBAGBs.UseVisualStyleBackColor = true;
            this.CBAGBs.CheckedChanged += new System.EventHandler(this.CBAGBs_CheckedChanged);
            // 
            // TBRName
            // 
            this.TBRName.Location = new System.Drawing.Point(302, 70);
            this.TBRName.Name = "TBRName";
            this.TBRName.Size = new System.Drawing.Size(100, 20);
            this.TBRName.TabIndex = 1;
            // 
            // TBRVorname
            // 
            this.TBRVorname.Location = new System.Drawing.Point(302, 124);
            this.TBRVorname.Name = "TBRVorname";
            this.TBRVorname.Size = new System.Drawing.Size(100, 20);
            this.TBRVorname.TabIndex = 6;
            // 
            // TBRTelefon
            // 
            this.TBRTelefon.Location = new System.Drawing.Point(522, 294);
            this.TBRTelefon.Name = "TBRTelefon";
            this.TBRTelefon.Size = new System.Drawing.Size(100, 20);
            this.TBRTelefon.TabIndex = 10;
            // 
            // TBREmail
            // 
            this.TBREmail.Location = new System.Drawing.Point(302, 181);
            this.TBREmail.Name = "TBREmail";
            this.TBREmail.Size = new System.Drawing.Size(100, 20);
            this.TBREmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email*";
            // 
            // TBRZahlung
            // 
            this.TBRZahlung.Location = new System.Drawing.Point(522, 236);
            this.TBRZahlung.Name = "TBRZahlung";
            this.TBRZahlung.Size = new System.Drawing.Size(100, 20);
            this.TBRZahlung.TabIndex = 18;
            // 
            // TBROrt
            // 
            this.TBROrt.Location = new System.Drawing.Point(522, 181);
            this.TBROrt.Name = "TBROrt";
            this.TBROrt.Size = new System.Drawing.Size(100, 20);
            this.TBROrt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "PseudoZahlungsbetrag*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ort";
            // 
            // TBRPostleitzahl
            // 
            this.TBRPostleitzahl.Location = new System.Drawing.Point(522, 124);
            this.TBRPostleitzahl.Name = "TBRPostleitzahl";
            this.TBRPostleitzahl.Size = new System.Drawing.Size(100, 20);
            this.TBRPostleitzahl.TabIndex = 14;
            // 
            // TBRAdresse
            // 
            this.TBRAdresse.Location = new System.Drawing.Point(522, 70);
            this.TBRAdresse.Name = "TBRAdresse";
            this.TBRAdresse.Size = new System.Drawing.Size(100, 20);
            this.TBRAdresse.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Postleitzahl*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Adresse*";
            // 
            // TBRPasswortW
            // 
            this.TBRPasswortW.Location = new System.Drawing.Point(302, 294);
            this.TBRPasswortW.Name = "TBRPasswortW";
            this.TBRPasswortW.Size = new System.Drawing.Size(100, 20);
            this.TBRPasswortW.TabIndex = 22;
            // 
            // TBRPasswort
            // 
            this.TBRPasswort.Location = new System.Drawing.Point(302, 236);
            this.TBRPasswort.Name = "TBRPasswort";
            this.TBRPasswort.Size = new System.Drawing.Size(100, 20);
            this.TBRPasswort.TabIndex = 20;
            this.TBRPasswort.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Passwort wiederholen*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Passwort*";
            // 
            // PBWerbung
            // 
            this.PBWerbung.Image = ((System.Drawing.Image)(resources.GetObject("PBWerbung.Image")));
            this.PBWerbung.Location = new System.Drawing.Point(686, 12);
            this.PBWerbung.Name = "PBWerbung";
            this.PBWerbung.Size = new System.Drawing.Size(229, 459);
            this.PBWerbung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBWerbung.TabIndex = 23;
            this.PBWerbung.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Anmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBWerbung);
            this.Controls.Add(this.TBRPasswortW);
            this.Controls.Add(this.TBRPasswort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBRZahlung);
            this.Controls.Add(this.TBROrt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBRPostleitzahl);
            this.Controls.Add(this.TBRAdresse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBRTelefon);
            this.Controls.Add(this.TBREmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBRVorname);
            this.Controls.Add(this.TBRName);
            this.Controls.Add(this.CBAGBs);
            this.Controls.Add(this.TBRInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Anmeldung";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Anmeldung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBWerbung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TBRInsert;
        private System.Windows.Forms.CheckBox CBAGBs;
        private System.Windows.Forms.TextBox TBRName;
        private System.Windows.Forms.TextBox TBRVorname;
        private System.Windows.Forms.TextBox TBRTelefon;
        private System.Windows.Forms.TextBox TBREmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBRZahlung;
        private System.Windows.Forms.TextBox TBROrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBRPostleitzahl;
        private System.Windows.Forms.TextBox TBRAdresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBRPasswortW;
        private System.Windows.Forms.TextBox TBRPasswort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PBWerbung;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}