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
    public partial class Form4 : Form
    {
        SQLiteConnection conn;

        public Form4(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Troops WHERE side = 'Темерия'", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(table.Rows[i].ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Таблица пуста");
            }
        }

        private void BWall_button_Click(object sender, EventArgs e)
        {

        }

        private void BTower_button_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 15)
            {
                try
                {
                    SQLiteCommand comm = new SQLiteCommand();
                    comm.Connection = conn;
                    comm.CommandText = $"SELECT Rang FROM Troops WHERE id = {textBox1.Text}";
                    int troop_rang = Convert.ToInt32(comm.ExecuteScalar());
                    comm.CommandText = $"SELECT Equipment FROM Troops WHERE id = {textBox1.Text}";
                    int troop_equip = Convert.ToInt32(comm.ExecuteScalar());
                    comm.CommandText = $"SELECT Count_of_troop FROM Troops WHERE id = {textBox1.Text}";
                    int troop_count = Convert.ToInt32(comm.ExecuteScalar());
                    double temeria_power = troop_count * troop_equip * troop_rang;

                    comm.CommandText = $"SELECT Rang FROM Troops WHERE id = {Settings.Default.Wave}";
                    int enemy_rang = Convert.ToInt32(comm.ExecuteScalar());
                    comm.CommandText = $"SELECT Equipment FROM Troops WHERE id = {Settings.Default.Wave}";
                    int enemy_equip = Convert.ToInt32(comm.ExecuteScalar());
                    comm.CommandText = $"SELECT Count_of_troop FROM Troops WHERE id = {Settings.Default.Wave}";
                    int enemy_count = Convert.ToInt32(comm.ExecuteScalar());
                    double nilf_power = enemy_rang * enemy_equip * enemy_count;
                    Settings.Default.Wave += 1;
                    comm.CommandText = $"SELECT lvl FROM buildings WHERE id = 1";
                    int id_build11 = Convert.ToInt32(comm.ExecuteScalar());
                    Settings.Default.Money = Settings.Default.Money + id_build11 * 20;
                    double result = temeria_power - nilf_power;
                    if (result < 0)
                    {
                        comm.CommandText = $"SELECT hp FROM buildings WHERE id = 1";
                        int now_hp_house = Convert.ToInt32(comm.ExecuteScalar());
                        result = result + (result * (-2));
                        int house_damage = Convert.ToInt32(Math.Round(result));
                        now_hp_house -= house_damage;
                        comm.CommandText = $"UPDATE buildings SET hp = {now_hp_house} WHERE id = 1";
                        comm.ExecuteNonQuery();
                        comm.CommandText = $"DELETE FROM Troops WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Зачем Нюк пикнули то? Вас разбили");
                        Close();
                    }
                    else if (result > 0)
                    {
                        int troop_damage = Convert.ToInt32(Math.Round(result / troop_equip / troop_rang));
                        int now_count_troop = troop_count - troop_damage;
                        comm.CommandText = $"UPDATE Troops SET Count_of_troop = {now_count_troop} WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Вы разбили Вражину");
                        Close();
                    }
                    else if (result == 0)
                    {
                        comm.CommandText = $"DELETE FROM Troops WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Ваш отряд погиб, но выполнил свой долг");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Не должно вылезти");
                    }
                    comm.CommandText = $"SELECT hp FROM buildings WHERE id = 1";
                    int hp_build = Convert.ToInt32(comm.ExecuteScalar());
                    if (hp_build <= 0)
                    {
                        MessageBox.Show("Капитолий пал, Темерия повержена ;(");
                    }
                    if (Settings.Default.Wave > 15)
                    {
                        MessageBox.Show("Ура, Темерия спасена! Все нильфы были разбиты!");
                    }

                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Это типо не ваш отряд xD");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SQLiteCommand comm = new SQLiteCommand();
            comm.Connection = conn;
            comm.CommandText = $"SELECT Rang FROM Troops WHERE id = {Settings.Default.Wave}";
            int enemy_rang = Convert.ToInt32(comm.ExecuteScalar());
            comm.CommandText = $"SELECT Equipment FROM Troops WHERE id = {Settings.Default.Wave}";
            int enemy_equip = Convert.ToInt32(comm.ExecuteScalar());
            comm.CommandText = $"SELECT Count_of_troop FROM Troops WHERE id = {Settings.Default.Wave}";
            int enemy_count = Convert.ToInt32(comm.ExecuteScalar());
            comm.CommandText = $"SELECT Type FROM Troops WHERE id = {Settings.Default.Wave}";
            string enemy_type = Convert.ToString(comm.ExecuteScalar());
            label1.Text = $"{enemy_type} в количестве {enemy_count}, со умениями уровня {enemy_rang}, и снарягой {enemy_equip}";
        }
    }
}
