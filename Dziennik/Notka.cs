using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace Dziennik
{
    class Notka
    {
        string Date { get; set; }
        string Text { get; set; }
        string Spell { get; set; }
        string Title { get; set; }


        public Notka(string ndate, string ntext, string nspell)
        {
            Date = DateTime.Parse(ndate).ToString("dd.MM.yyyy");
            Text = ntext;
            Spell = nspell;
            Title = "Dziennik Toma Riddle'a - Notatka z dnia " + Date + " r.";
            Note.date = Date;
            Note.text = Text;
            Note.title = Title;
            Note.spell = Spell;
        }
    }
}
