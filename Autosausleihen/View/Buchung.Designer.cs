namespace Autosausleihen.View
{
    partial class Buchung
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
            this.pBAuto = new System.Windows.Forms.PictureBox();
            this.TBModell = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBHersteller = new System.Windows.Forms.TextBox();
            this.TBBaujahr = new System.Windows.Forms.TextBox();
            this.TBPreis = new System.Windows.Forms.TextBox();
            this.TBFarbe = new System.Windows.Forms.TextBox();
            this.LBHersteller = new System.Windows.Forms.Label();
            this.LBModell = new System.Windows.Forms.Label();
            this.LBBaujahr = new System.Windows.Forms.Label();
            this.LBName = new System.Windows.Forms.Label();
            this.LBFarbe = new System.Windows.Forms.Label();
            this.LBPreis = new System.Windows.Forms.Label();
            this.BTNBuchen = new System.Windows.Forms.Button();
            this.TBA_ID = new System.Windows.Forms.TextBox();
            this.LBA_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // pBAuto
            // 
            this.pBAuto.Location = new System.Drawing.Point(12, 12);
            this.pBAuto.Name = "pBAuto";
            this.pBAuto.Size = new System.Drawing.Size(224, 133);
            this.pBAuto.TabIndex = 0;
            this.pBAuto.TabStop = false;
            // 
            // TBModell
            // 
            this.TBModell.Location = new System.Drawing.Point(136, 176);
            this.TBModell.Name = "TBModell";
            this.TBModell.Size = new System.Drawing.Size(100, 20);
            this.TBModell.TabIndex = 4;
            this.TBModell.TextChanged += new System.EventHandler(this.TBModell_TextChanged);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(12, 228);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 2;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            // 
            // TBHersteller
            // 
            this.TBHersteller.Location = new System.Drawing.Point(12, 176);
            this.TBHersteller.Name = "TBHersteller";
            this.TBHersteller.Size = new System.Drawing.Size(100, 20);
            this.TBHersteller.TabIndex = 1;
            this.TBHersteller.TextChanged += new System.EventHandler(this.TBHersteller_TextChanged);
            // 
            // TBBaujahr
            // 
            this.TBBaujahr.Location = new System.Drawing.Point(136, 228);
            this.TBBaujahr.Name = "TBBaujahr";
            this.TBBaujahr.Size = new System.Drawing.Size(100, 20);
            this.TBBaujahr.TabIndex = 5;
            this.TBBaujahr.TextChanged += new System.EventHandler(this.TBBaujahr_TextChanged);
            // 
            // TBPreis
            // 
            this.TBPreis.Location = new System.Drawing.Point(136, 275);
            this.TBPreis.Name = "TBPreis";
            this.TBPreis.Size = new System.Drawing.Size(100, 20);
            this.TBPreis.TabIndex = 6;
            this.TBPreis.TextChanged += new System.EventHandler(this.TBPreis_TextChanged);
            // 
            // TBFarbe
            // 
            this.TBFarbe.Location = new System.Drawing.Point(12, 275);
            this.TBFarbe.Name = "TBFarbe";
            this.TBFarbe.Size = new System.Drawing.Size(100, 20);
            this.TBFarbe.TabIndex = 3;
            this.TBFarbe.TextChanged += new System.EventHandler(this.TBFarbe_TextChanged);
            // 
            // LBHersteller
            // 
            this.LBHersteller.AutoSize = true;
            this.LBHersteller.Location = new System.Drawing.Point(41, 160);
            this.LBHersteller.Name = "LBHersteller";
            this.LBHersteller.Size = new System.Drawing.Size(51, 13);
            this.LBHersteller.TabIndex = 7;
            this.LBHersteller.Text = "Hersteller";
            // 
            // LBModell
            // 
            this.LBModell.AutoSize = true;
            this.LBModell.Location = new System.Drawing.Point(168, 160);
            this.LBModell.Name = "LBModell";
            this.LBModell.Size = new System.Drawing.Size(38, 13);
            this.LBModell.TabIndex = 8;
            this.LBModell.Text = "Modell";
            // 
            // LBBaujahr
            // 
            this.LBBaujahr.AutoSize = true;
            this.LBBaujahr.Location = new System.Drawing.Point(168, 212);
            this.LBBaujahr.Name = "LBBaujahr";
            this.LBBaujahr.Size = new System.Drawing.Size(43, 13);
            this.LBBaujahr.TabIndex = 9;
            this.LBBaujahr.Text = "Baujahr";
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Location = new System.Drawing.Point(41, 212);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(35, 13);
            this.LBName.TabIndex = 10;
            this.LBName.Text = "Name";
            // 
            // LBFarbe
            // 
            this.LBFarbe.AutoSize = true;
            this.LBFarbe.Location = new System.Drawing.Point(41, 259);
            this.LBFarbe.Name = "LBFarbe";
            this.LBFarbe.Size = new System.Drawing.Size(34, 13);
            this.LBFarbe.TabIndex = 11;
            this.LBFarbe.Text = "Farbe";
            // 
            // LBPreis
            // 
            this.LBPreis.AutoSize = true;
            this.LBPreis.Location = new System.Drawing.Point(168, 259);
            this.LBPreis.Name = "LBPreis";
            this.LBPreis.Size = new System.Drawing.Size(30, 13);
            this.LBPreis.TabIndex = 12;
            this.LBPreis.Text = "Preis";
            // 
            // BTNBuchen
            // 
            this.BTNBuchen.Location = new System.Drawing.Point(136, 316);
            this.BTNBuchen.Name = "BTNBuchen";
            this.BTNBuchen.Size = new System.Drawing.Size(100, 36);
            this.BTNBuchen.TabIndex = 8;
            this.BTNBuchen.Text = "Buchen";
            this.BTNBuchen.UseVisualStyleBackColor = true;
            this.BTNBuchen.Click += new System.EventHandler(this.BTNBuchen_Click);
            // 
            // TBA_ID
            // 
            this.TBA_ID.Location = new System.Drawing.Point(12, 316);
            this.TBA_ID.Name = "TBA_ID";
            this.TBA_ID.Size = new System.Drawing.Size(100, 20);
            this.TBA_ID.TabIndex = 13;
            // 
            // LBA_ID
            // 
            this.LBA_ID.AutoSize = true;
            this.LBA_ID.Location = new System.Drawing.Point(41, 300);
            this.LBA_ID.Name = "LBA_ID";
            this.LBA_ID.Size = new System.Drawing.Size(43, 13);
            this.LBA_ID.TabIndex = 14;
            this.LBA_ID.Text = "Auto ID";
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 364);
            this.Controls.Add(this.LBA_ID);
            this.Controls.Add(this.TBA_ID);
            this.Controls.Add(this.BTNBuchen);
            this.Controls.Add(this.LBPreis);
            this.Controls.Add(this.LBFarbe);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.LBBaujahr);
            this.Controls.Add(this.LBModell);
            this.Controls.Add(this.LBHersteller);
            this.Controls.Add(this.TBFarbe);
            this.Controls.Add(this.TBPreis);
            this.Controls.Add(this.TBBaujahr);
            this.Controls.Add(this.TBHersteller);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBModell);
            this.Controls.Add(this.pBAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 403);
            this.MinimumSize = new System.Drawing.Size(265, 403);
            this.Name = "Buchung";
            this.ShowIcon = false;
            this.Text = "Buchung";
            ((System.ComponentModel.ISupportInitialize)(this.pBAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBAuto;
        private System.Windows.Forms.TextBox TBModell;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBHersteller;
        private System.Windows.Forms.TextBox TBBaujahr;
        private System.Windows.Forms.TextBox TBPreis;
        private System.Windows.Forms.TextBox TBFarbe;
        private System.Windows.Forms.Label LBHersteller;
        private System.Windows.Forms.Label LBModell;
        private System.Windows.Forms.Label LBBaujahr;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBFarbe;
        private System.Windows.Forms.Label LBPreis;
        private System.Windows.Forms.Button BTNBuchen;
        private System.Windows.Forms.TextBox TBA_ID;
        private System.Windows.Forms.Label LBA_ID;
    }
}