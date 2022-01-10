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
using System.IO;
using System.Globalization;
using Finisar.SQLite;

namespace Dziennik
{
    /// <summary>
    /// Logika interakcji dla klasy Notatka.xaml
    /// </summary>
    /// 
    public partial class Note : Window
    {


        string comm;
        public static string date;
        public static string text;
        public static string spell;
        public static string title;

        public void Write()
        {
            Date.Content = date + " r.";
            Text.Text = text;
            Spell.Text = spell;
            Title = title;
        }

        public Note()
        {
            InitializeComponent();
            Write();
        }


        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            SQLite_Access.New_Text(date, -1);
            Write();

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            SQLite_Access.New_Text(date, 1);
            Write();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            comm = "UPDATE Note SET text = '" + Convert.ToString(Text.Text) + "' WHERE date = '" + DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") + "'";
            SQLite_Access.Change_And_Del(comm);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            comm = "DELETE FROM Note WHERE text = '" + Convert.ToString(Text.Text) + "' AND date = '" + DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") + "'";
            SQLite_Access.Change_And_Del(comm);
            this.Close();
            MessageBox.Show("Usunięto wpis!");

        }
    }
}
