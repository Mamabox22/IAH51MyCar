namespace Autosausleihen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BTRegistrierung = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTLogIN = new System.Windows.Forms.Button();
            this.BTHinzufügen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTRegistrierung
            // 
            this.BTRegistrierung.BackColor = System.Drawing.SystemColors.Window;
            this.BTRegistrierung.Location = new System.Drawing.Point(27, 363);
            this.BTRegistrierung.Name = "BTRegistrierung";
            this.BTRegistrierung.Size = new System.Drawing.Size(289, 70);
            this.BTRegistrierung.TabIndex = 0;
            this.BTRegistrierung.Text = "Jetzt Registrieren";
            this.BTRegistrierung.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BTLogIN
            // 
            this.BTLogIN.Location = new System.Drawing.Point(770, 12);
            this.BTLogIN.Name = "BTLogIN";
            this.BTLogIN.Size = new System.Drawing.Size(145, 23);
            this.BTLogIN.TabIndex = 2;
            this.BTLogIN.Text = "Einloggen";
            this.BTLogIN.UseVisualStyleBackColor = true;
            // 
            // BTHinzufügen
            // 
            this.BTHinzufügen.Location = new System.Drawing.Point(616, 363);
            this.BTHinzufügen.Name = "BTHinzufügen";
            this.BTHinzufügen.Size = new System.Drawing.Size(210, 70);
            this.BTHinzufügen.TabIndex = 3;
            this.BTHinzufügen.Text = "Autoshinzufügen (Test)";
            this.BTHinzufügen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 483);
            this.Controls.Add(this.BTHinzufügen);
            this.Controls.Add(this.BTLogIN);
            this.Controls.Add(this.BTRegistrierung);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MyCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTRegistrierung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTLogIN;
        private System.Windows.Forms.Button BTHinzufügen;
    }
}