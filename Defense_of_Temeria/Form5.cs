using Defense_of_Temeria.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defense_of_Temeria
{
    public partial class Form5 : Form
    {
        SQLiteConnection conn;
        public Form5(SQLiteConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Troops(Type, Side, Count_of_troop, Rang, Equipment) VALUES('Копейщики','Темерия', 75, 1, 1)";
                comm.ExecuteNonQuery();
                Settings.Default.Money -= 50;
                Close();
            }
            else if (radioButton2.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Troops(Type, Side, Count_of_troop, Rang, Equipment) VALUES('Лучники','Темерия', 75, 1, 1)";
                comm.ExecuteNonQuery();
                Settings.Default.Money -= 50;
                Close();
            }
            else if (radioButton3.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Troops(Type, Side, Count_of_troop, Rang, Equipment) VALUES('Кавалерия','Темерия', 75, 1, 1)";
                comm.ExecuteNonQuery();
                Settings.Default.Money -= 50;
                Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали тип");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
