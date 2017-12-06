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
            this.lvAutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lvAutos
            // 
            this.lvAutos.FormattingEnabled = true;
            this.lvAutos.Location = new System.Drawing.Point(24, 64);
            this.lvAutos.Name = "lvAutos";
            this.lvAutos.Size = new System.Drawing.Size(195, 394);
            this.lvAutos.TabIndex = 0;
            // 
            // AutosHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 483);
            this.Controls.Add(this.lvAutos);
            this.Name = "AutosHinzufügen";
            this.Text = "AutosHinzufügen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lvAutos;
    }
}