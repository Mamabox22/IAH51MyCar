using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosausleihen
{
    abstract class Controller
    {
        //Instanz von View
        protected Form view;

        //Instanz von Model
        protected object model;

        public Controller(Form view, object model)
        {
            this.view = view;
            this.model = model;
        }

        //Methode aus dem View die Controlles rausliest
        protected Control getControl(string name)
        {
            return view.Controls.Find(name, false).First();
        }
    }
}
