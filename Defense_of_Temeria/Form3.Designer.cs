namespace Defense_of_Temeria
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountMoney_Iab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UpBuilf_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Repair_button = new System.Windows.Forms.Button();
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
            this.title,
            this.lvl,
            this.hp});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Строение";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // lvl
            // 
            this.lvl.HeaderText = "Уровень";
            this.lvl.Name = "lvl";
            this.lvl.ReadOnly = true;
            // 
            // hp
            // 
            this.hp.HeaderText = "Запас прочности";
            this.hp.Name = "hp";
            this.hp.ReadOnly = true;
            // 
            // CountMoney_Iab
            // 
            this.CountMoney_Iab.AutoSize = true;
            this.CountMoney_Iab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CountMoney_Iab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMoney_Iab.Location = new System.Drawing.Point(544, 12);
            this.CountMoney_Iab.Name = "CountMoney_Iab";
            this.CountMoney_Iab.Size = new System.Drawing.Size(19, 20);
            this.CountMoney_Iab.TabIndex = 11;
            this.CountMoney_Iab.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(469, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Орены:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(470, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "№ постройки, с которой работаем\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // UpBuilf_button
            // 
            this.UpBuilf_button.BackColor = System.Drawing.Color.Gray;
            this.UpBuilf_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpBuilf_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpBuilf_button.Location = new System.Drawing.Point(469, 129);
            this.UpBuilf_button.Name = "UpBuilf_button";
            this.UpBuilf_button.Size = new System.Drawing.Size(124, 49);
            this.UpBuilf_button.TabIndex = 17;
            this.UpBuilf_button.Text = "Улучшить";
            this.UpBuilf_button.UseVisualStyleBackColor = false;
            this.UpBuilf_button.Click += new System.EventHandler(this.UpBuilf_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Repair_button
            // 
            this.Repair_button.BackColor = System.Drawing.Color.Gray;
            this.Repair_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Repair_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repair_button.Location = new System.Drawing.Point(469, 184);
            this.Repair_button.Name = "Repair_button";
            this.Repair_button.Size = new System.Drawing.Size(124, 49);
            this.Repair_button.TabIndex = 19;
            this.Repair_button.Text = "Починить на 10";
            this.Repair_button.UseVisualStyleBackColor = false;
            this.Repair_button.Click += new System.EventHandler(this.Repair_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Repair_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpBuilf_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CountMoney_Iab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn hp;
        private System.Windows.Forms.Label CountMoney_Iab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UpBuilf_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Repair_button;
    }
}