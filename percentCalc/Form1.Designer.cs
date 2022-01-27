namespace percentCalc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numstartcount = new System.Windows.Forms.NumericUpDown();
            this.numpercent = new System.Windows.Forms.NumericUpDown();
            this.numyears = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboprocess = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numstartcount
            // 
            this.numstartcount.DecimalPlaces = 2;
            this.numstartcount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numstartcount.Location = new System.Drawing.Point(222, 32);
            this.numstartcount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numstartcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numstartcount.Name = "numstartcount";
            this.numstartcount.Size = new System.Drawing.Size(218, 20);
            this.numstartcount.TabIndex = 0;
            this.numstartcount.ThousandsSeparator = true;
            this.numstartcount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numpercent
            // 
            this.numpercent.DecimalPlaces = 2;
            this.numpercent.Location = new System.Drawing.Point(222, 74);
            this.numpercent.Name = "numpercent";
            this.numpercent.Size = new System.Drawing.Size(218, 20);
            this.numpercent.TabIndex = 1;
            // 
            // numyears
            // 
            this.numyears.Location = new System.Drawing.Point(222, 123);
            this.numyears.Name = "numyears";
            this.numyears.Size = new System.Drawing.Size(218, 20);
            this.numyears.TabIndex = 2;
            this.numyears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изначальная сумма";
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc.Location = new System.Drawing.Point(446, 10);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(252, 56);
            this.calc.TabIndex = 10;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(11, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Процентная ставка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количество лет";
            // 
            // comboprocess
            // 
            this.comboprocess.BackColor = System.Drawing.SystemColors.Window;
            this.comboprocess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboprocess.FormattingEnabled = true;
            this.comboprocess.Items.AddRange(new object[] {
            "Ежедневно",
            "Ежемесячно",
            "Ежеквартально",
            "По полугодиям",
            "Ежегодно"});
            this.comboprocess.Location = new System.Drawing.Point(222, 161);
            this.comboprocess.Name = "comboprocess";
            this.comboprocess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboprocess.Size = new System.Drawing.Size(218, 21);
            this.comboprocess.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Процент начисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Итоговая сумма";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(15, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 277);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(446, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Обновить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(222, 206);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(218, 20);
            this.total.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(446, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 56);
            this.button2.TabIndex = 19;
            this.button2.Text = "Добавить в таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(446, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 56);
            this.button3.TabIndex = 20;
            this.button3.Text = "Удалить выделенную строку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::percentCalc.Properties.Resources._247125_fe4f49a5;
            this.ClientSize = new System.Drawing.Size(714, 607);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboprocess);
            this.Controls.Add(this.numyears);
            this.Controls.Add(this.numpercent);
            this.Controls.Add(this.numstartcount);
            this.Name = "Form1";
            this.Text = "Рассчёт НДФЛ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numstartcount;
        private System.Windows.Forms.NumericUpDown numpercent;
        private System.Windows.Forms.NumericUpDown numyears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboprocess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

