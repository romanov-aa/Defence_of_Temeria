using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Defense_of_Temeria.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Defense_of_Temeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SQLiteConnection conn;

        
        public void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(@"Data Source=E:\SQLiteStudio\DefTemeria");
            conn.Open();
            Settings.Default.Money = 100;
            CountMoney_Iab.Text = Settings.Default.Money.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 fr2 = new Form2(conn, CountMoney_Iab);
            fr2.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(conn, CountMoney_Iab);
            fr3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4(conn);
            fr4.ShowDialog();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            Settings.Default.Money = 100;
            Settings.Default.Wave = 1;
            SQLiteCommand comm = new SQLiteCommand();
            comm.Connection = conn;
            comm.CommandText = $"UPDATE buildings SET lvl = 1";
            comm.ExecuteNonQuery();
            comm.CommandText = $"UPDATE buildings SET hp = 100";
            comm.ExecuteNonQuery();
            comm.CommandText = $"DROP TABLE Troops";
            comm.ExecuteNonQuery();
            comm.CommandText = $"CREATE TABLE Troops (\r\n    id             INTEGER   PRIMARY KEY AUTOINCREMENT,\r\n    Type           TEXT (50),\r\n    Side           TEXT (50),\r\n    Count_of_troop INTEGER,\r\n    Rang           INTEGER,\r\n    Equipment      INTEGER\r\n);";
            comm.ExecuteNonQuery();
            comm.CommandText = $"INSERT INTO Troops(Type, Side, Count_of_troop, Rang, Equipment) VALUES('Лучники','Нильфгаард', 30, 1, 1), "+
                "('Копейщики','Нильфгаард', 30, 1, 1), ('Кавалерия','Нильфгаард', 30, 1, 1), ('Копейщики','Нильфгаард', 40, 2, 1), ('Кавалерия','Нильфгаард', 45, 1, 1), " +
                "('Лучники','Нильфгаард', 45, 2, 1), ('Лучники','Нильфгаард', 50, 2, 1), ('Копейщики','Нильфгаард', 55, 2, 2), ('Кавалерия','Нильфгаард', 60, 2, 2)," +
                "('Кавалерия','Нильфгаард', 60, 2, 2), ('Лучники','Нильфгаард', 40, 3, 2), ('Копейщики','Нильфгаард', 50, 3, 2), ('Кавалерия','Нильфгаард', 60, 3, 2)," +
                "('Лучники','Нильфгаард', 40, 3, 3), ('Кавалерия','Нильфгаард', 60, 3, 3), ('Копейщики','Темерия', 75, 1, 1)";
            comm.ExecuteNonQuery();
        }
    }
}
