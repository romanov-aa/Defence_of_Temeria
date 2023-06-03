namespace Defense_of_Temeria
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count_of_troop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountMoney_Iab = new System.Windows.Forms.Label();
            this.Heal_button = new System.Windows.Forms.Button();
            this.UpEquip_button = new System.Windows.Forms.Button();
            this.Training_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buyTroop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Type,
            this.Side,
            this.Count_of_troop,
            this.Rang,
            this.Equipment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип войска";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Side
            // 
            this.Side.HeaderText = "Фракция";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            // 
            // Count_of_troop
            // 
            this.Count_of_troop.HeaderText = "Количество солдат";
            this.Count_of_troop.Name = "Count_of_troop";
            this.Count_of_troop.ReadOnly = true;
            // 
            // Rang
            // 
            this.Rang.HeaderText = "Мастерство";
            this.Rang.Name = "Rang";
            this.Rang.ReadOnly = true;
            // 
            // Equipment
            // 
            this.Equipment.HeaderText = "Качество снаряги";
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 49);
            this.button4.TabIndex = 7;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(665, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Орены:";
            // 
            // CountMoney_Iab
            // 
            this.CountMoney_Iab.AutoSize = true;
            this.CountMoney_Iab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CountMoney_Iab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMoney_Iab.Location = new System.Drawing.Point(740, 12);
            this.CountMoney_Iab.Name = "CountMoney_Iab";
            this.CountMoney_Iab.Size = new System.Drawing.Size(19, 20);
            this.CountMoney_Iab.TabIndex = 9;
            this.CountMoney_Iab.Text = "0";
            // 
            // Heal_button
            // 
            this.Heal_button.BackColor = System.Drawing.Color.Gray;
            this.Heal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Heal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heal_button.Location = new System.Drawing.Point(673, 162);
            this.Heal_button.Name = "Heal_button";
            this.Heal_button.Size = new System.Drawing.Size(140, 49);
            this.Heal_button.TabIndex = 10;
            this.Heal_button.Text = "Полечить";
            this.Heal_button.UseVisualStyleBackColor = false;
            this.Heal_button.Click += new System.EventHandler(this.Heal_button_Click);
            // 
            // UpEquip_button
            // 
            this.UpEquip_button.BackColor = System.Drawing.Color.Gray;
            this.UpEquip_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpEquip_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpEquip_button.Location = new System.Drawing.Point(673, 217);
            this.UpEquip_button.Name = "UpEquip_button";
            this.UpEquip_button.Size = new System.Drawing.Size(140, 49);
            this.UpEquip_button.TabIndex = 11;
            this.UpEquip_button.Text = "Прокачать снарягу";
            this.UpEquip_button.UseVisualStyleBackColor = false;
            this.UpEquip_button.Click += new System.EventHandler(this.UpEquip_button_Click);
            // 
            // Training_button
            // 
            this.Training_button.BackColor = System.Drawing.Color.Gray;
            this.Training_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Training_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Training_button.Location = new System.Drawing.Point(673, 272);
            this.Training_button.Name = "Training_button";
            this.Training_button.Size = new System.Drawing.Size(140, 49);
            this.Training_button.TabIndex = 12;
            this.Training_button.Text = "Потренировать";
            this.Training_button.UseVisualStyleBackColor = false;
            this.Training_button.Click += new System.EventHandler(this.Training_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(671, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 48);
            this.label2.TabIndex = 14;
            this.label2.Text = "id Отряда, с \r\nкоторым \r\nвзаимодействуем";
            // 
            // buyTroop_button
            // 
            this.buyTroop_button.BackColor = System.Drawing.Color.Gray;
            this.buyTroop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyTroop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyTroop_button.Location = new System.Drawing.Point(674, 381);
            this.buyTroop_button.Name = "buyTroop_button";
            this.buyTroop_button.Size = new System.Drawing.Size(140, 49);
            this.buyTroop_button.TabIndex = 15;
            this.buyTroop_button.Text = "Нанять новый отряд";
            this.buyTroop_button.UseVisualStyleBackColor = false;
            this.buyTroop_button.Click += new System.EventHandler(this.buyTroop_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 513);
            this.Controls.Add(this.buyTroop_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Training_button);
            this.Controls.Add(this.UpEquip_button);
            this.Controls.Add(this.Heal_button);
            this.Controls.Add(this.CountMoney_Iab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count_of_troop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountMoney_Iab;
        private System.Windows.Forms.Button Heal_button;
        private System.Windows.Forms.Button UpEquip_button;
        private System.Windows.Forms.Button Training_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buyTroop_button;
    }
}