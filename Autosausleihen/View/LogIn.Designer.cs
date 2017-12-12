namespace Autosausleihen
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            this.LBUsername = new System.Windows.Forms.Label();
            this.TBLUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBLPasswort = new System.Windows.Forms.TextBox();
            this.LBPasswort = new System.Windows.Forms.Label();
            this.BTLEinlogen = new System.Windows.Forms.Button();
            this.BTLRegistrierung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBUsername
            // 
            this.LBUsername.AutoSize = true;
            this.LBUsername.Location = new System.Drawing.Point(42, 27);
            this.LBUsername.Name = "LBUsername";
            this.LBUsername.Size = new System.Drawing.Size(55, 13);
            this.LBUsername.TabIndex = 0;
            this.LBUsername.Text = "Username";
            // 
            // TBLUsername
            // 
            this.TBLUsername.Location = new System.Drawing.Point(45, 43);
            this.TBLUsername.Name = "TBLUsername";
            this.TBLUsername.Size = new System.Drawing.Size(100, 20);
            this.TBLUsername.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TBLPasswort
            // 
            this.TBLPasswort.Location = new System.Drawing.Point(45, 82);
            this.TBLPasswort.Name = "TBLPasswort";
            this.TBLPasswort.Size = new System.Drawing.Size(100, 20);
            this.TBLPasswort.TabIndex = 4;
            // 
            // LBPasswort
            // 
            this.LBPasswort.AutoSize = true;
            this.LBPasswort.Location = new System.Drawing.Point(42, 66);
            this.LBPasswort.Name = "LBPasswort";
            this.LBPasswort.Size = new System.Drawing.Size(50, 13);
            this.LBPasswort.TabIndex = 3;
            this.LBPasswort.Text = "Passwort";
            // 
            // BTLEinlogen
            // 
            this.BTLEinlogen.Location = new System.Drawing.Point(54, 119);
            this.BTLEinlogen.Name = "BTLEinlogen";
            this.BTLEinlogen.Size = new System.Drawing.Size(75, 23);
            this.BTLEinlogen.TabIndex = 5;
            this.BTLEinlogen.Text = "Einloggen";
            this.BTLEinlogen.UseVisualStyleBackColor = true;
            this.BTLEinlogen.Click += new System.EventHandler(this.BTLEinlogen_Click);
            // 
            // BTLRegistrierung
            // 
            this.BTLRegistrierung.Location = new System.Drawing.Point(54, 148);
            this.BTLRegistrierung.Name = "BTLRegistrierung";
            this.BTLRegistrierung.Size = new System.Drawing.Size(75, 23);
            this.BTLRegistrierung.TabIndex = 6;
            this.BTLRegistrierung.Text = "Registrieren";
            this.BTLRegistrierung.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 193);
            this.Controls.Add(this.BTLRegistrierung);
            this.Controls.Add(this.BTLEinlogen);
            this.Controls.Add(this.TBLPasswort);
            this.Controls.Add(this.LBPasswort);
            this.Controls.Add(this.TBLUsername);
            this.Controls.Add(this.LBUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(204, 232);
            this.MinimumSize = new System.Drawing.Size(204, 232);
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBUsername;
        private System.Windows.Forms.TextBox TBLUsername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TBLPasswort;
        private System.Windows.Forms.Label LBPasswort;
        private System.Windows.Forms.Button BTLEinlogen;
        private System.Windows.Forms.Button BTLRegistrierung;
    }
}