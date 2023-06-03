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
    public partial class Form2 : Form
    {
        SQLiteConnection conn;
        Label global_money;
        public Form2(SQLiteConnection conn, Label global_money)
        {
            this.global_money= global_money;
            this.conn = conn;
            InitializeComponent();
            updateTable(conn);
        }
        private void updateTable(SQLiteConnection conn)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            global_money.Text = Settings.Default.Money.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CountMoney_Iab.Text = Settings.Default.Money.ToString();
        }

        private void Training_button_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Money >= 30)
            {
                try
                {
                    SQLiteCommand comm = new SQLiteCommand();
                    comm.Connection = conn;
                    comm.CommandText = $"SELECT Rang FROM Troops WHERE id = {textBox1.Text}";
                    int id_troop = Convert.ToInt32(comm.ExecuteScalar());
                    comm.CommandText = $"SELECT lvl FROM buildings WHERE id = 4";
                    int lvl_Traningn = Convert.ToInt32(comm.ExecuteScalar());
                    if (lvl_Traningn > id_troop)
                    {
                        //MessageBox.Show(id_troop.ToString());
                        id_troop += 1;
                        //MessageBox.Show(id_troop.ToString());
                        comm.CommandText = $"UPDATE Troops SET Rang = {id_troop} WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        updateTable(conn);
                        CountMoney_Iab.Text = (Settings.Default.Money -= 30).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно прокачен центр подготовки");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Некоректное значение");
                }
                
            }
            else
            {
                MessageBox.Show("Недостаточно оренов");
            }
            
        }

        private void UpEquip_button_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Money >= 20)
            {
                try
                {
                    SQLiteCommand comm = new SQLiteCommand();
                    comm.Connection = conn;
                    comm.CommandText = $"SELECT Equipment FROM Troops WHERE id = {textBox1.Text}";
                    int id_troop = Convert.ToInt32(comm.ExecuteScalar());
                    comm.CommandText = $"SELECT lvl FROM buildings WHERE id = 5";
                    int lvl_Traningn = Convert.ToInt32(comm.ExecuteScalar());
                    if (lvl_Traningn > id_troop)
                    {
                        //MessageBox.Show(id_troop.ToString());
                        id_troop += 1;
                        //MessageBox.Show(id_troop.ToString());
                        comm.CommandText = $"UPDATE Troops SET Equipment = {id_troop} WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        updateTable(conn);
                        CountMoney_Iab.Text = (Settings.Default.Money -= 20).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно прокачена кузница");
                    }

                }
                catch
                {
                    MessageBox.Show("Некоректное значение");
                }

            }
            else
            {
                MessageBox.Show("Недостаточно оренов");
            }
        }

        private void Heal_button_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Money >= 10)
            {
                try
                {
                    SQLiteCommand comm = new SQLiteCommand();
                    comm.Connection = conn;
                    comm.CommandText = $"SELECT count_of_troop FROM Troops WHERE id = {textBox1.Text}";
                    int id_troop = Convert.ToInt32(comm.ExecuteScalar());
                    int max_count = 75;
                    if (max_count >= (id_troop + 10))
                    {
                        id_troop += 10;
                        comm.CommandText = $"UPDATE Troops SET count_of_troop = {id_troop} WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        updateTable(conn);
                        CountMoney_Iab.Text = (Settings.Default.Money -= 10).ToString();
                    }
                    else if (max_count == id_troop)
                    {
                        MessageBox.Show("Отряд укомплектован");
                    }
                    else if (max_count < (id_troop + 10))
                    {                      
                        comm.CommandText = $"UPDATE Troops SET count_of_troop = {max_count} WHERE id = {textBox1.Text}";
                        comm.ExecuteNonQuery();
                        updateTable(conn);
                        CountMoney_Iab.Text = (Settings.Default.Money -= 10).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Не должно вылезти");
                    }
                }
                catch
                {
                    MessageBox.Show("Некоректное значение");
                }

            }
            else
            {
                MessageBox.Show("Недостаточно оренов");
            }
        }

        private void buyTroop_button_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Money >= 50)
            {
                Form5 fr5 = new Form5(conn);
                fr5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно оренов");
            }
            
        }
    }
}
