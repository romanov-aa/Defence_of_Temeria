namespace Defense_of_Temeria
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.CountMoney_Iab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WavesCount_Ind = new System.Windows.Forms.Label();
            this.Wave_remaining_Ind = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Power_Tem_Ind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Орены:";
            // 
            // CountMoney_Iab
            // 
            this.CountMoney_Iab.AutoSize = true;
            this.CountMoney_Iab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CountMoney_Iab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMoney_Iab.Location = new System.Drawing.Point(93, 53);
            this.CountMoney_Iab.Name = "CountMoney_Iab";
            this.CountMoney_Iab.Size = new System.Drawing.Size(19, 20);
            this.CountMoney_Iab.TabIndex = 1;
            this.CountMoney_Iab.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Защита Темерии от Вражины (Нильфгаарда)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(618, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Посмотреть войска";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(97, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Приготовьтесь в битве";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(618, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "Строительство";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_restart
            // 
            this.button_restart.BackColor = System.Drawing.Color.Gray;
            this.button_restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_restart.Location = new System.Drawing.Point(664, 389);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(124, 49);
            this.button_restart.TabIndex = 6;
            this.button_restart.Text = "Начать сначала";
            this.button_restart.UseVisualStyleBackColor = false;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Волн пережито:";
            // 
            // WavesCount_Ind
            // 
            this.WavesCount_Ind.AutoSize = true;
            this.WavesCount_Ind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WavesCount_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WavesCount_Ind.Location = new System.Drawing.Point(165, 89);
            this.WavesCount_Ind.Name = "WavesCount_Ind";
            this.WavesCount_Ind.Size = new System.Drawing.Size(19, 20);
            this.WavesCount_Ind.TabIndex = 8;
            this.WavesCount_Ind.Text = "0";
            this.WavesCount_Ind.Click += new System.EventHandler(this.label4_Click);
            // 
            // Wave_remaining_Ind
            // 
            this.Wave_remaining_Ind.AutoSize = true;
            this.Wave_remaining_Ind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Wave_remaining_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wave_remaining_Ind.Location = new System.Drawing.Point(165, 128);
            this.Wave_remaining_Ind.Name = "Wave_remaining_Ind";
            this.Wave_remaining_Ind.Size = new System.Drawing.Size(19, 20);
            this.Wave_remaining_Ind.TabIndex = 9;
            this.Wave_remaining_Ind.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Волн осталось:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сила Темерии:";
            // 
            // Power_Tem_Ind
            // 
            this.Power_Tem_Ind.AutoSize = true;
            this.Power_Tem_Ind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Power_Tem_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power_Tem_Ind.Location = new System.Drawing.Point(158, 171);
            this.Power_Tem_Ind.Name = "Power_Tem_Ind";
            this.Power_Tem_Ind.Size = new System.Drawing.Size(146, 20);
            this.Power_Tem_Ind.TabIndex = 12;
            this.Power_Tem_Ind.Text = "Жалкие остатки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Power_Tem_Ind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wave_remaining_Ind);
            this.Controls.Add(this.WavesCount_Ind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountMoney_Iab);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Defenseof_Temeria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountMoney_Iab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WavesCount_Ind;
        private System.Windows.Forms.Label Wave_remaining_Ind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Power_Tem_Ind;
    }
}

