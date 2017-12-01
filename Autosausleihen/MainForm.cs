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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTRegistrierung_Click(object sender, EventArgs e)
        {
            Anmeldung login = new Anmeldung();
            login.Show();
        }

        private void Anmeldung_Load(object sender, EventArgs e)
        {

        }

        private void BTLogIN_Click(object sender, EventArgs e)
        {

        }
    }
}
