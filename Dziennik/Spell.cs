using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    public class Spell
    {
        public string SpellText { get; set; }

        public Spell(string nspell)
        {
            SpellText = nspell;
            MainWindow.spell = SpellText;
        }

    }
}
