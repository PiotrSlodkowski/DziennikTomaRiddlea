using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Threading;
using Finisar.SQLite;

namespace Dziennik
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string date_now = DateTime.Today.ToString("yyyy-MM-dd");
        public static string spell;

        public MainWindow()
        {
            InitializeComponent();
            Spell_Write(date_now);
        }


        private void Spell_Write(string date)
        {
            SQLite_Access.Spell_Today(date);
            Spell.Text = spell;          
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            string Date_chosen = Convert.ToDateTime(Calendar1.SelectedDate).ToString("yyyy-MM-dd");
            if (SQLite_Access.Load(Date_chosen))
            {
                Note wnd = new Note();
                wnd.ShowDialog();
                Load_Dates();
            }
        }
               
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Create wnd = new Create();
            wnd.ShowDialog();
            Load_Dates();
        }

        private void Rand_Click(object sender, RoutedEventArgs e)
        {
            if (spell == "Nie wylosowano żadnego zaklęcia na ten dzień.")
            {
                SQLite_Access.Rand_Spell(Humor.Text);
                Spell_Write(date_now);
            }
            else
            {
                MessageBox.Show("Wylosowano już zaklęcie na ten dzień!");
            }

        }

        public void Load_Dates()
        {
            int count = SQLite_Access.Dates().Length - 1;
            Calendar1.BlackoutDates.Clear();
            Calendar1.DisplayDateStart = SQLite_Access.Dates()[0];
            Calendar1.DisplayDateEnd = SQLite_Access.Dates()[count];
            for (int i = 0; i < count; i++)
            {
                if (SQLite_Access.Dates()[i] < SQLite_Access.Dates()[i + 1].AddDays(-1))
                    Calendar1.BlackoutDates.Add(new CalendarDateRange(SQLite_Access.Dates()[i].AddDays(1), SQLite_Access.Dates()[i + 1].AddDays(-1)));         
            }
            Calendar1.DisplayDate = SQLite_Access.Dates()[count];
            Calendar1.SelectedDate = SQLite_Access.Dates()[count];


        }
        public void Calendar1_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Dates();
        }
    }
}
