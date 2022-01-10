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
using System.Windows.Navigation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Finisar.SQLite;

namespace Dziennik
{
    /// <summary>
    /// Logika interakcji dla klasy Tworzenie.xaml
    /// </summary>
    public partial class Create : Window
    {

        public Create()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string Date_chosen = Convert.ToDateTime(Calendar1.SelectedDate).ToString("yyyy-MM-dd");
            if (SQLite_Access.Add(Date_chosen, Convert.ToString(Text.Text)))
            {
                this.Close();
                MessageBox.Show("Dodano wpis!");
            }

        }

        public void Calendar1_Loaded(object sender, RoutedEventArgs e)
        {
            Calendar1.DisplayDateEnd = DateTime.Today;
            for (int i = 0; i < SQLite_Access.Dates().Length; i++)
            {
                Calendar1.BlackoutDates.Add(new CalendarDateRange(SQLite_Access.Dates()[i]));
                if (SQLite_Access.Dates()[i] == DateTime.Today)
                    return;
            }

            Calendar1.SelectedDate = DateTime.Today;

        }
    }
}
