using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;
using Finisar.SQLite;

namespace Dziennik
{

    static class SQLite_Access
    {
        static SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=Note.db;Version=3;");
        static SQLiteCommand sqlite_cmd;
        static SQLiteDataReader sqlite_datareader;
        static string date_new;
        static string Checked_Date;
        static string date_time;
        static string Text;
        static string Spell;
        static bool a;



        public static bool Load(string date)
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT Note.*, Spell.spell FROM Note LEFT JOIN SpellOfDay ON Note.date = SpellOfDay.date LEFT JOIN Spell ON Spell.id = SpellOfDay.id_spell WHERE Note.date = '" + date + "'"; ;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (!sqlite_datareader.Read())
            {
                MessageBox.Show("Brak notatki do wyświetlenia!");
                a = false;
            }
            else
            {
                Text = sqlite_datareader["text"].ToString();
                if (sqlite_datareader["spell"].ToString() != "")
                    Spell = sqlite_datareader["spell"].ToString();
                else
                    Spell = "Nie wylosowano żadnego zaklęcia.";           
                Notka not = new Notka(date, Text, Spell);
                a = true;
            }
            sqlite_conn.Close();
            return a; 
        }

        public static DateTime[] Dates()
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT count(*) as ile FROM Note";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            int count = Convert.ToInt32(sqlite_datareader["ile"]);
            DateTime[] dates = new DateTime[count];
            int i = 0;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT date FROM Note ORDER BY date ASC";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                dates[i] = DateTime.Parse(sqlite_datareader["date"].ToString());
                i++;
            }
            sqlite_conn.Close();
            return dates;
        } 

        public static void Spell_Today(string date)
        {
            sqlite_conn.Open();
            string spell;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT spell FROM SpellOfDay JOIN Spell ON SpellOfDay.id_spell = Spell.id WHERE date = '" + date + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (sqlite_datareader.Read())
            {
                spell = sqlite_datareader["spell"].ToString();
            }
            else
            {
                spell = "Nie wylosowano żadnego zaklęcia na ten dzień.";
            }
            Spell spell_object = new Spell(spell);
            sqlite_conn.Close();
        }

        public static void Change_And_Del(string comm)
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = comm;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public static bool Add(string date, string text)
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT date FROM Note WHERE date = '" + date + "'"; ;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (sqlite_datareader.Read())
            {
                MessageBox.Show("Notatka z tego dnia już istnieje!");
                a = false;
            }
            else
            {
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO Note (date, text) VALUES ('" + date + "', '" + text + "')";
                sqlite_cmd.ExecuteNonQuery();
                a = true;
            }
            sqlite_conn.Close();
            return a;
        }
        
        public static void Rand_Spell(string humor)
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT id FROM Spell WHERE humor = '" + humor + "' ORDER BY RANDOM() LIMIT 1";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            Spell = sqlite_datareader["id"].ToString();
            sqlite_cmd = sqlite_conn.CreateCommand();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            sqlite_cmd.CommandText = "INSERT INTO SpellOfDay (date, humor, id_spell) VALUES ('" + date + "', " + Int32.Parse(humor) + ", '" + Spell + "')";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();

        }
        public static void New_Text(string date, int what)
        {
            date_time = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Note ORDER BY date ASC";
            sqlite_cmd.ExecuteNonQuery();
            string[] Dates = new string[3];
            sqlite_datareader = sqlite_cmd.ExecuteReader();           
            while (sqlite_datareader.Read())
            {
                Checked_Date = sqlite_datareader["date"].ToString();
                if (date_time == Checked_Date)
                    Dates[1] = Checked_Date;
                else if (Dates[0] == Dates[1])
                {
                    Dates[1] = Checked_Date;
                    Dates[0] = Dates[1];
                }
                else
                {
                    Dates[2] = Checked_Date;
                    break;
                }
            }
            date_new = Dates[1 + what];
            sqlite_conn.Close();
            Load(date_new);
        }
    }
}
