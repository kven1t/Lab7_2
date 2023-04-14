namespace Lab7_2
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
            this.lst = new System.Windows.Forms.ListBox();
            this.lstFromfile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(57, 67);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(193, 148);
            this.lst.TabIndex = 0;
            // 
            // lstFromfile
            // 
            this.lstFromfile.FormattingEnabled = true;
            this.lstFromfile.ItemHeight = 16;
            this.lstFromfile.Location = new System.Drawing.Point(306, 67);
            this.lstFromfile.Name = "lstFromfile";
            this.lstFromfile.Size = new System.Drawing.Size(193, 148);
            this.lstFromfile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "путь к файлу";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 3;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(57, 275);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(193, 22);
            this.txt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить список в файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Загрузить данные из файла";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить в список";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 379);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFromfile);
            this.Controls.Add(this.lst);
            this.Name = "Form1";
            this.Text = "Работа с файлами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.ListBox lstFromfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
    }
}

