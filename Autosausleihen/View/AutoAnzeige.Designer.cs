namespace Autosausleihen
{
    partial class AutoAnzeige
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoAnzeige));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hersteller = new System.Windows.Forms.Label();
            this.CBCabrio = new System.Windows.Forms.CheckBox();
            this.CBLimousine = new System.Windows.Forms.CheckBox();
            this.CBCombie = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BSuche = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComBHersteller = new System.Windows.Forms.ComboBox();
            this.ComBModell = new System.Windows.Forms.ComboBox();
            this.ComBName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBAHersteller = new System.Windows.Forms.TextBox();
            this.TBAModell = new System.Windows.Forms.TextBox();
            this.TBAName = new System.Windows.Forms.TextBox();
            this.TBAFarbe = new System.Windows.Forms.TextBox();
            this.TBABaujahr = new System.Windows.Forms.TextBox();
            this.TBAVerfügbar = new System.Windows.Forms.TextBox();
            this.BTMieten = new System.Windows.Forms.Button();
            this.ComBSitzplätze = new System.Windows.Forms.ComboBox();
            this.ComBFarbe = new System.Windows.Forms.ComboBox();
            this.ComBBaujahr = new System.Windows.Forms.ComboBox();
            this.lvAutos = new System.Windows.Forms.ListView();
            this.herstellerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBAVariante = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TBASitzplatz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(365, 182);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modell";
            // 
            // Hersteller
            // 
            this.Hersteller.AutoSize = true;
            this.Hersteller.Location = new System.Drawing.Point(365, 76);
            this.Hersteller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hersteller.Name = "Hersteller";
            this.Hersteller.Size = new System.Drawing.Size(69, 17);
            this.Hersteller.TabIndex = 10;
            this.Hersteller.Text = "Hersteller";
            // 
            // CBCabrio
            // 
            this.CBCabrio.AutoSize = true;
            this.CBCabrio.Location = new System.Drawing.Point(329, 262);
            this.CBCabrio.Margin = new System.Windows.Forms.Padding(4);
            this.CBCabrio.Name = "CBCabrio";
            this.CBCabrio.Size = new System.Drawing.Size(71, 21);
            this.CBCabrio.TabIndex = 3;
            this.CBCabrio.Text = "Cabrio";
            this.CBCabrio.UseVisualStyleBackColor = true;
            // 
            // CBLimousine
            // 
            this.CBLimousine.AutoSize = true;
            this.CBLimousine.Location = new System.Drawing.Point(328, 290);
            this.CBLimousine.Margin = new System.Windows.Forms.Padding(4);
            this.CBLimousine.Name = "CBLimousine";
            this.CBLimousine.Size = new System.Drawing.Size(94, 21);
            this.CBLimousine.TabIndex = 5;
            this.CBLimousine.Text = "Limousine";
            this.CBLimousine.UseVisualStyleBackColor = true;
            // 
            // CBCombie
            // 
            this.CBCombie.AutoSize = true;
            this.CBCombie.Location = new System.Drawing.Point(456, 262);
            this.CBCombie.Margin = new System.Windows.Forms.Padding(4);
            this.CBCombie.Name = "CBCombie";
            this.CBCombie.Size = new System.Drawing.Size(77, 21);
            this.CBCombie.TabIndex = 4;
            this.CBCombie.Text = "Combie";
            this.CBCombie.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sitzplätze";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Baujahr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Farbe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1172, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Farbe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1171, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Sitzplätze";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1172, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Baujahr";
            // 
            // BSuche
            // 
            this.BSuche.Location = new System.Drawing.Point(516, 96);
            this.BSuche.Margin = new System.Windows.Forms.Padding(4);
            this.BSuche.Name = "BSuche";
            this.BSuche.Size = new System.Drawing.Size(209, 132);
            this.BSuche.TabIndex = 11;
            this.BSuche.Text = "Filtern";
            this.BSuche.UseVisualStyleBackColor = true;
            this.BSuche.Click += new System.EventHandler(this.BSuche_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(815, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 164);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // ComBHersteller
            // 
            this.ComBHersteller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBHersteller.FormattingEnabled = true;
            this.ComBHersteller.Location = new System.Drawing.Point(329, 96);
            this.ComBHersteller.Margin = new System.Windows.Forms.Padding(4);
            this.ComBHersteller.Name = "ComBHersteller";
            this.ComBHersteller.Size = new System.Drawing.Size(160, 24);
            this.ComBHersteller.TabIndex = 103;
            // 
            // ComBModell
            // 
            this.ComBModell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBModell.FormattingEnabled = true;
            this.ComBModell.Location = new System.Drawing.Point(329, 150);
            this.ComBModell.Margin = new System.Windows.Forms.Padding(4);
            this.ComBModell.Name = "ComBModell";
            this.ComBModell.Size = new System.Drawing.Size(160, 24);
            this.ComBModell.TabIndex = 104;
            // 
            // ComBName
            // 
            this.ComBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBName.FormattingEnabled = true;
            this.ComBName.Location = new System.Drawing.Point(329, 202);
            this.ComBName.Margin = new System.Windows.Forms.Padding(4);
            this.ComBName.Name = "ComBName";
            this.ComBName.Size = new System.Drawing.Size(160, 24);
            this.ComBName.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(891, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 108;
            this.label8.Text = "Hersteller";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(891, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Modell";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(891, 393);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 106;
            this.label10.Text = "Name";
            // 
            // TBAHersteller
            // 
            this.TBAHersteller.Location = new System.Drawing.Point(840, 304);
            this.TBAHersteller.Margin = new System.Windows.Forms.Padding(4);
            this.TBAHersteller.Name = "TBAHersteller";
            this.TBAHersteller.Size = new System.Drawing.Size(160, 22);
            this.TBAHersteller.TabIndex = 119;
            // 
            // TBAModell
            // 
            this.TBAModell.Location = new System.Drawing.Point(840, 360);
            this.TBAModell.Margin = new System.Windows.Forms.Padding(4);
            this.TBAModell.Name = "TBAModell";
            this.TBAModell.Size = new System.Drawing.Size(160, 22);
            this.TBAModell.TabIndex = 120;
            // 
            // TBAName
            // 
            this.TBAName.Location = new System.Drawing.Point(840, 414);
            this.TBAName.Margin = new System.Windows.Forms.Padding(4);
            this.TBAName.Name = "TBAName";
            this.TBAName.Size = new System.Drawing.Size(160, 22);
            this.TBAName.TabIndex = 121;
            // 
            // TBAFarbe
            // 
            this.TBAFarbe.Location = new System.Drawing.Point(1132, 414);
            this.TBAFarbe.Margin = new System.Windows.Forms.Padding(4);
            this.TBAFarbe.Name = "TBAFarbe";
            this.TBAFarbe.Size = new System.Drawing.Size(171, 22);
            this.TBAFarbe.TabIndex = 124;
            // 
            // TBABaujahr
            // 
            this.TBABaujahr.Location = new System.Drawing.Point(1132, 360);
            this.TBABaujahr.Margin = new System.Windows.Forms.Padding(4);
            this.TBABaujahr.Name = "TBABaujahr";
            this.TBABaujahr.Size = new System.Drawing.Size(171, 22);
            this.TBABaujahr.TabIndex = 125;
            // 
            // TBAVerfügbar
            // 
            this.TBAVerfügbar.Location = new System.Drawing.Point(815, 519);
            this.TBAVerfügbar.Margin = new System.Windows.Forms.Padding(4);
            this.TBAVerfügbar.Name = "TBAVerfügbar";
            this.TBAVerfügbar.Size = new System.Drawing.Size(488, 22);
            this.TBAVerfügbar.TabIndex = 126;
            // 
            // BTMieten
            // 
            this.BTMieten.Location = new System.Drawing.Point(983, 551);
            this.BTMieten.Margin = new System.Windows.Forms.Padding(4);
            this.BTMieten.Name = "BTMieten";
            this.BTMieten.Size = new System.Drawing.Size(197, 28);
            this.BTMieten.TabIndex = 127;
            this.BTMieten.Text = "Dieses Auto mieten";
            this.BTMieten.UseVisualStyleBackColor = true;
            this.BTMieten.Click += new System.EventHandler(this.BTMieten_Click);
            // 
            // ComBSitzplätze
            // 
            this.ComBSitzplätze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBSitzplätze.FormattingEnabled = true;
            this.ComBSitzplätze.Location = new System.Drawing.Point(329, 414);
            this.ComBSitzplätze.Margin = new System.Windows.Forms.Padding(4);
            this.ComBSitzplätze.Name = "ComBSitzplätze";
            this.ComBSitzplätze.Size = new System.Drawing.Size(160, 24);
            this.ComBSitzplätze.TabIndex = 128;
            // 
            // ComBFarbe
            // 
            this.ComBFarbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBFarbe.FormattingEnabled = true;
            this.ComBFarbe.Location = new System.Drawing.Point(535, 343);
            this.ComBFarbe.Margin = new System.Windows.Forms.Padding(4);
            this.ComBFarbe.Name = "ComBFarbe";
            this.ComBFarbe.Size = new System.Drawing.Size(160, 24);
            this.ComBFarbe.TabIndex = 129;
            // 
            // ComBBaujahr
            // 
            this.ComBBaujahr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBBaujahr.FormattingEnabled = true;
            this.ComBBaujahr.Location = new System.Drawing.Point(331, 345);
            this.ComBBaujahr.Margin = new System.Windows.Forms.Padding(4);
            this.ComBBaujahr.Name = "ComBBaujahr";
            this.ComBBaujahr.Size = new System.Drawing.Size(160, 24);
            this.ComBBaujahr.TabIndex = 130;
            // 
            // lvAutos
            // 
            this.lvAutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.herstellerColumn,
            this.modelColumn,
            this.nameColum});
            this.lvAutos.FullRowSelect = true;
            this.lvAutos.Location = new System.Drawing.Point(32, 76);
            this.lvAutos.Margin = new System.Windows.Forms.Padding(4);
            this.lvAutos.MultiSelect = false;
            this.lvAutos.Name = "lvAutos";
            this.lvAutos.Size = new System.Drawing.Size(259, 488);
            this.lvAutos.TabIndex = 131;
            this.lvAutos.UseCompatibleStateImageBehavior = false;
            this.lvAutos.View = System.Windows.Forms.View.Details;
            // 
            // herstellerColumn
            // 
            this.herstellerColumn.Text = "Hersteller";
            // 
            // modelColumn
            // 
            this.modelColumn.Text = "Model";
            // 
            // nameColum
            // 
            this.nameColum.Text = "Name";
            // 
            // TBAVariante
            // 
            this.TBAVariante.Location = new System.Drawing.Point(1132, 304);
            this.TBAVariante.Name = "TBAVariante";
            this.TBAVariante.Size = new System.Drawing.Size(171, 22);
            this.TBAVariante.TabIndex = 132;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1172, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 133;
            this.label13.Text = "Variante";
            // 
            // TBASitzplatz
            // 
            this.TBASitzplatz.Location = new System.Drawing.Point(1133, 469);
            this.TBASitzplatz.Name = "TBASitzplatz";
            this.TBASitzplatz.Size = new System.Drawing.Size(170, 22);
            this.TBASitzplatz.TabIndex = 134;
            // 
            // AutoAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 594);
            this.Controls.Add(this.TBASitzplatz);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TBAVariante);
            this.Controls.Add(this.lvAutos);
            this.Controls.Add(this.ComBBaujahr);
            this.Controls.Add(this.ComBFarbe);
            this.Controls.Add(this.ComBSitzplätze);
            this.Controls.Add(this.BTMieten);
            this.Controls.Add(this.TBAVerfügbar);
            this.Controls.Add(this.TBABaujahr);
            this.Controls.Add(this.TBAFarbe);
            this.Controls.Add(this.TBAName);
            this.Controls.Add(this.TBAModell);
            this.Controls.Add(this.TBAHersteller);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ComBName);
            this.Controls.Add(this.ComBModell);
            this.Controls.Add(this.ComBHersteller);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BSuche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBCombie);
            this.Controls.Add(this.CBLimousine);
            this.Controls.Add(this.CBCabrio);
            this.Controls.Add(this.Hersteller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoAnzeige";
            this.Text = "Autos leihen ";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hersteller;
        private System.Windows.Forms.CheckBox CBCabrio;
        private System.Windows.Forms.CheckBox CBLimousine;
        private System.Windows.Forms.CheckBox CBCombie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BSuche;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ComBHersteller;
        private System.Windows.Forms.ComboBox ComBModell;
        private System.Windows.Forms.ComboBox ComBName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBAHersteller;
        private System.Windows.Forms.TextBox TBAModell;
        private System.Windows.Forms.TextBox TBAName;
        private System.Windows.Forms.TextBox TBAFarbe;
        private System.Windows.Forms.TextBox TBABaujahr;
        private System.Windows.Forms.TextBox TBAVerfügbar;
        private System.Windows.Forms.Button BTMieten;
        private System.Windows.Forms.ComboBox ComBSitzplätze;
        private System.Windows.Forms.ComboBox ComBFarbe;
        private System.Windows.Forms.ComboBox ComBBaujahr;
        private System.Windows.Forms.ListView lvAutos;
        private System.Windows.Forms.ColumnHeader herstellerColumn;
        private System.Windows.Forms.ColumnHeader modelColumn;
        private System.Windows.Forms.ColumnHeader nameColum;
        private System.Windows.Forms.TextBox TBAVariante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBASitzplatz;
    }
}

