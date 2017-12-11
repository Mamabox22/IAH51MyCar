using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Autosausleihen.Controller;

namespace Autosausleihen
{
    public partial class AutoAnzeige : Form
    {

        public AutoAnzeige(MainForm form, AutoAnzeigeController autoausleihencontroller)
        {
            InitializeComponent();
            autoausleihencontroller.InitializeAutoListbox();
        }


    }
}
