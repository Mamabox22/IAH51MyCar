using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosausleihen
{
    public partial class LogIn : Form
    {
        private MainForm form;

        public LogIn(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void BTLEinlogen_Click(object sender, EventArgs e)
        {
            
            AutoAnzeige Anzeige = new AutoAnzeige(form);
            Anzeige.Show();
            Close();
        }

        private void BTLRegistrierung_Click(object sender, EventArgs e)
        {
            Anmeldung anmeldung = new Anmeldung();
            anmeldung.Show();
            Close();
        }
    }
}
