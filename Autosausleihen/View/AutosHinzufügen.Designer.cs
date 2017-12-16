namespace Autosausleihen
{
    partial class AutosHinzufügen
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
            this.TBModell = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBBaujahr = new System.Windows.Forms.TextBox();
            this.TBSitzplätze = new System.Windows.Forms.TextBox();
            this.TBFarbe = new System.Windows.Forms.TextBox();
            this.TBHersteller = new System.Windows.Forms.TextBox();
            this.LBHersteller = new System.Windows.Forms.Label();
            this.LBModell = new System.Windows.Forms.Label();
            this.LBName = new System.Windows.Forms.Label();
            this.LBBaujahr = new System.Windows.Forms.Label();
            this.LBSitzplätze = new System.Windows.Forms.Label();
            this.LBFarbe = new System.Windows.Forms.Label();
            this.CBCabrio = new System.Windows.Forms.CheckBox();
            this.CBCombie = new System.Windows.Forms.CheckBox();
            this.CBLimousine = new System.Windows.Forms.CheckBox();
            this.BTNHinzufügen = new System.Windows.Forms.Button();
            this.lvAutos = new System.Windows.Forms.ListView();
            this.herstellerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TBModell
            // 
            this.TBModell.Location = new System.Drawing.Point(329, 150);
            this.TBModell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBModell.Name = "TBModell";
            this.TBModell.Size = new System.Drawing.Size(160, 22);
            this.TBModell.TabIndex = 1;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(329, 202);
            this.TBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(160, 22);
            this.TBName.TabIndex = 2;
            // 
            // TBBaujahr
            // 
            this.TBBaujahr.Location = new System.Drawing.Point(331, 345);
            this.TBBaujahr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBBaujahr.Name = "TBBaujahr";
            this.TBBaujahr.Size = new System.Drawing.Size(160, 22);
            this.TBBaujahr.TabIndex = 3;
            // 
            // TBSitzplätze
            // 
            this.TBSitzplätze.Location = new System.Drawing.Point(329, 414);
            this.TBSitzplätze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBSitzplätze.Name = "TBSitzplätze";
            this.TBSitzplätze.Size = new System.Drawing.Size(160, 22);
            this.TBSitzplätze.TabIndex = 4;
            this.TBSitzplätze.TextChanged += new System.EventHandler(this.TBSitzplätze_TextChanged);
            // 
            // TBFarbe
            // 
            this.TBFarbe.Location = new System.Drawing.Point(535, 343);
            this.TBFarbe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBFarbe.Name = "TBFarbe";
            this.TBFarbe.Size = new System.Drawing.Size(160, 22);
            this.TBFarbe.TabIndex = 5;
            // 
            // TBHersteller
            // 
            this.TBHersteller.Location = new System.Drawing.Point(329, 96);
            this.TBHersteller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBHersteller.Name = "TBHersteller";
            this.TBHersteller.Size = new System.Drawing.Size(160, 22);
            this.TBHersteller.TabIndex = 6;
            // 
            // LBHersteller
            // 
            this.LBHersteller.AutoSize = true;
            this.LBHersteller.Location = new System.Drawing.Point(365, 76);
            this.LBHersteller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBHersteller.Name = "LBHersteller";
            this.LBHersteller.Size = new System.Drawing.Size(69, 17);
            this.LBHersteller.TabIndex = 7;
            this.LBHersteller.Text = "Hersteller";
            // 
            // LBModell
            // 
            this.LBModell.AutoSize = true;
            this.LBModell.Location = new System.Drawing.Point(365, 132);
            this.LBModell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBModell.Name = "LBModell";
            this.LBModell.Size = new System.Drawing.Size(49, 17);
            this.LBModell.TabIndex = 8;
            this.LBModell.Text = "Modell";
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Location = new System.Drawing.Point(365, 182);
            this.LBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(45, 17);
            this.LBName.TabIndex = 9;
            this.LBName.Text = "Name";
            // 
            // LBBaujahr
            // 
            this.LBBaujahr.AutoSize = true;
            this.LBBaujahr.Location = new System.Drawing.Point(367, 326);
            this.LBBaujahr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBBaujahr.Name = "LBBaujahr";
            this.LBBaujahr.Size = new System.Drawing.Size(57, 17);
            this.LBBaujahr.TabIndex = 10;
            this.LBBaujahr.Text = "Baujahr";
            // 
            // LBSitzplätze
            // 
            this.LBSitzplätze.AutoSize = true;
            this.LBSitzplätze.Location = new System.Drawing.Point(367, 394);
            this.LBSitzplätze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBSitzplätze.Name = "LBSitzplätze";
            this.LBSitzplätze.Size = new System.Drawing.Size(69, 17);
            this.LBSitzplätze.TabIndex = 11;
            this.LBSitzplätze.Text = "Sitzplätze";
            // 
            // LBFarbe
            // 
            this.LBFarbe.AutoSize = true;
            this.LBFarbe.Location = new System.Drawing.Point(585, 324);
            this.LBFarbe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBFarbe.Name = "LBFarbe";
            this.LBFarbe.Size = new System.Drawing.Size(45, 17);
            this.LBFarbe.TabIndex = 12;
            this.LBFarbe.Text = "Farbe";
            // 
            // CBCabrio
            // 
            this.CBCabrio.AutoSize = true;
            this.CBCabrio.Location = new System.Drawing.Point(329, 262);
            this.CBCabrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBCabrio.Name = "CBCabrio";
            this.CBCabrio.Size = new System.Drawing.Size(71, 21);
            this.CBCabrio.TabIndex = 13;
            this.CBCabrio.Text = "Cabrio";
            this.CBCabrio.UseVisualStyleBackColor = true;
            // 
            // CBCombie
            // 
            this.CBCombie.AutoSize = true;
            this.CBCombie.Location = new System.Drawing.Point(456, 262);
            this.CBCombie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBCombie.Name = "CBCombie";
            this.CBCombie.Size = new System.Drawing.Size(77, 21);
            this.CBCombie.TabIndex = 14;
            this.CBCombie.Text = "Combie";
            this.CBCombie.UseVisualStyleBackColor = true;
            // 
            // CBLimousine
            // 
            this.CBLimousine.AutoSize = true;
            this.CBLimousine.Location = new System.Drawing.Point(328, 290);
            this.CBLimousine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBLimousine.Name = "CBLimousine";
            this.CBLimousine.Size = new System.Drawing.Size(94, 21);
            this.CBLimousine.TabIndex = 15;
            this.CBLimousine.Text = "Limousine";
            this.CBLimousine.UseVisualStyleBackColor = true;
            // 
            // BTNHinzufügen
            // 
            this.BTNHinzufügen.Location = new System.Drawing.Point(516, 96);
            this.BTNHinzufügen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNHinzufügen.Name = "BTNHinzufügen";
            this.BTNHinzufügen.Size = new System.Drawing.Size(209, 132);
            this.BTNHinzufügen.TabIndex = 16;
            this.BTNHinzufügen.Text = "Hinzufügen";
            this.BTNHinzufügen.UseVisualStyleBackColor = true;
            this.BTNHinzufügen.Click += new System.EventHandler(this.BTNHinzufügen_Click);
            // 
            // lvAutos
            // 
            this.lvAutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.herstellerColumn,
            this.modelColumn,
            this.nameColumn});
            this.lvAutos.Location = new System.Drawing.Point(32, 76);
            this.lvAutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvAutos.Name = "lvAutos";
            this.lvAutos.Size = new System.Drawing.Size(259, 488);
            this.lvAutos.TabIndex = 17;
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
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // AutosHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 594);
            this.Controls.Add(this.lvAutos);
            this.Controls.Add(this.BTNHinzufügen);
            this.Controls.Add(this.CBLimousine);
            this.Controls.Add(this.CBCombie);
            this.Controls.Add(this.CBCabrio);
            this.Controls.Add(this.LBFarbe);
            this.Controls.Add(this.LBSitzplätze);
            this.Controls.Add(this.LBBaujahr);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.LBModell);
            this.Controls.Add(this.LBHersteller);
            this.Controls.Add(this.TBHersteller);
            this.Controls.Add(this.TBFarbe);
            this.Controls.Add(this.TBSitzplätze);
            this.Controls.Add(this.TBBaujahr);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBModell);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AutosHinzufügen";
            this.Text = "AutosHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBModell;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBBaujahr;
        private System.Windows.Forms.TextBox TBSitzplätze;
        private System.Windows.Forms.TextBox TBFarbe;
        private System.Windows.Forms.TextBox TBHersteller;
        private System.Windows.Forms.Label LBHersteller;
        private System.Windows.Forms.Label LBModell;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBBaujahr;
        private System.Windows.Forms.Label LBSitzplätze;
        private System.Windows.Forms.Label LBFarbe;
        private System.Windows.Forms.CheckBox CBCabrio;
        private System.Windows.Forms.CheckBox CBCombie;
        private System.Windows.Forms.CheckBox CBLimousine;
        private System.Windows.Forms.Button BTNHinzufügen;
        private System.Windows.Forms.ListView lvAutos;
        private System.Windows.Forms.ColumnHeader herstellerColumn;
        private System.Windows.Forms.ColumnHeader modelColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
    }
}