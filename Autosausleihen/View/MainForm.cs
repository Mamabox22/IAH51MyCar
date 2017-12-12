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
            Anmeldung anmeldung = new Anmeldung();                          //Aus irgendwelchen Gründen wurde die Registrierung als Anmeldung benannt
            anmeldung.Show();
            Hide();

        }

        private void BTLogIN_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            Hide();
        }
    }
}
