using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autosausleihen.Model;

namespace Autosausleihen
{
    class MainFormController : Controller.Controller
    {
        public MainFormController(Form view, MainForm mainform) : base(view, new MainFormModel())
        {
            getControl("BTRegistrierung").Click += BTRegistrierung_Click;
        }

        private void BTRegistrierung_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm(this);
            mainform.Show();
            view.Hide();
        }
        private void BTLogIN_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn(this);
            login.Show();
            this.Hide();
        }
    }
}
