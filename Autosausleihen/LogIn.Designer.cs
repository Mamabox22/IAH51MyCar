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
            this.label1 = new System.Windows.Forms.Label();
            this.TBLUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBLPasswort = new System.Windows.Forms.TextBox();
            this.lPasswort = new System.Windows.Forms.Label();
            this.BTLEinlogen = new System.Windows.Forms.Button();
            this.BTLRegistrierung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // TBLUsername
            // 
            this.TBLUsername.Location = new System.Drawing.Point(53, 94);
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
            this.TBLPasswort.Location = new System.Drawing.Point(191, 94);
            this.TBLPasswort.Name = "TBLPasswort";
            this.TBLPasswort.Size = new System.Drawing.Size(100, 20);
            this.TBLPasswort.TabIndex = 4;
            // 
            // lPasswort
            // 
            this.lPasswort.AutoSize = true;
            this.lPasswort.Location = new System.Drawing.Point(188, 78);
            this.lPasswort.Name = "lPasswort";
            this.lPasswort.Size = new System.Drawing.Size(50, 13);
            this.lPasswort.TabIndex = 3;
            this.lPasswort.Text = "Passwort";
            // 
            // BTLEinlogen
            // 
            this.BTLEinlogen.Location = new System.Drawing.Point(138, 139);
            this.BTLEinlogen.Name = "BTLEinlogen";
            this.BTLEinlogen.Size = new System.Drawing.Size(75, 23);
            this.BTLEinlogen.TabIndex = 5;
            this.BTLEinlogen.Text = "Einloggen";
            this.BTLEinlogen.UseVisualStyleBackColor = true;
            this.BTLEinlogen.Click += new System.EventHandler(this.BTLEinlogen_Click);
            // 
            // BTLRegistrierung
            // 
            this.BTLRegistrierung.Location = new System.Drawing.Point(238, 12);
            this.BTLRegistrierung.Name = "BTLRegistrierung";
            this.BTLRegistrierung.Size = new System.Drawing.Size(108, 23);
            this.BTLRegistrierung.TabIndex = 6;
            this.BTLRegistrierung.Text = "Noch kein Konto ?";
            this.BTLRegistrierung.UseVisualStyleBackColor = true;
            this.BTLRegistrierung.Click += new System.EventHandler(this.BTLRegistrierung_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 193);
            this.Controls.Add(this.BTLRegistrierung);
            this.Controls.Add(this.BTLEinlogen);
            this.Controls.Add(this.TBLPasswort);
            this.Controls.Add(this.lPasswort);
            this.Controls.Add(this.TBLUsername);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLUsername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TBLPasswort;
        private System.Windows.Forms.Label lPasswort;
        private System.Windows.Forms.Button BTLEinlogen;
        private System.Windows.Forms.Button BTLRegistrierung;
    }
}