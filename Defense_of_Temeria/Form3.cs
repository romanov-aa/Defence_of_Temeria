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
    public partial class Form3 : Form
    {
        SQLiteConnection conn;
        Label global_money;

        public Form3(SQLiteConnection conn, Label global_money)
        {
            this.conn = conn;
            InitializeComponent();
            updateTable(conn);
            this.global_money = global_money;
        }
        private void updateTable(SQLiteConnection conn)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM buildings", conn);
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
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            global_money.Text = Settings.Default.Money.ToString();
        }
        
        private void UpBuilf_button_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Money >= 30)
            {
                try
                {
                    SQLiteCommand comm = new SQLiteCommand();
                    comm.Connection = conn;
                    comm.CommandText = $"SELECT lvl FROM buildings WHERE id = {textBox1.Text}";
                    int id_build = Convert.ToInt32(comm.ExecuteScalar());
                    //MessageBox.Show(id_build.ToString());
                    id_build += 1;
                    //MessageBox.Show(id_build.ToString());
                    comm.CommandText = $"UPDATE buildings SET lvl = {id_build} WHERE id = {textBox1.Text}";
                    comm.ExecuteNonQuery();
                    updateTable(conn);
                    CountMoney_Iab.Text = (Settings.Default.Money -= 30).ToString();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            CountMoney_Iab.Text = Settings.Default.Money.ToString();
        }

        private void Repair_button_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Money >= 30)
            {
                try
                {
                    SQLiteCommand comm = new SQLiteCommand();
                    comm.Connection = conn;
                    comm.CommandText = $"SELECT hp FROM buildings WHERE id = {textBox1.Text}";
                    int id_build = Convert.ToInt32(comm.ExecuteScalar());
                    //MessageBox.Show(id_build.ToString());
                    id_build += 10;
                    //MessageBox.Show(id_build.ToString());
                    comm.CommandText = $"UPDATE buildings SET hp = {id_build} WHERE id = {textBox1.Text}";
                    comm.ExecuteNonQuery();
                    updateTable(conn);
                    CountMoney_Iab.Text = (Settings.Default.Money -= 30).ToString();
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
    }
}
