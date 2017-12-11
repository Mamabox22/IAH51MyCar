using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autosausleihen.Model;
using Autosausleihen;

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


        }
        private void BTLogIN_Click(object sender, EventArgs e)
        {

        }
    }
}
