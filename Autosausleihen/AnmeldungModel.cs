using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosausleihen
{
    class AnmeldungModel
    {
        public bool AGB { get; set; }

        public MainForm MainForm { get; set; }

        public MySQL MySQL = new MySQL();
    }
}
