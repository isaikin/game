namespace оно
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всавитьГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.визуализацияBfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.визуализацияBfsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.визуализацияDfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаBfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаDfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Построить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Колличесво веришн";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(577, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 4);
            this.listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.визуализацияBfsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.всавитьГрафToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // всавитьГрафToolStripMenuItem
            // 
            this.всавитьГрафToolStripMenuItem.Name = "всавитьГрафToolStripMenuItem";
            this.всавитьГрафToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.всавитьГрафToolStripMenuItem.Text = "Вставить граф";
            this.всавитьГрафToolStripMenuItem.Click += new System.EventHandler(this.всавитьГрафToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // визуализацияBfsToolStripMenuItem
            // 
            this.визуализацияBfsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.визуализацияBfsToolStripMenuItem1,
            this.визуализацияDfsToolStripMenuItem,
            this.сбросToolStripMenuItem,
            this.проверкаBfsToolStripMenuItem,
            this.проверкаDfsToolStripMenuItem});
            this.визуализацияBfsToolStripMenuItem.Name = "визуализацияBfsToolStripMenuItem";
            this.визуализацияBfsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.визуализацияBfsToolStripMenuItem.Text = "Выбор";
            // 
            // визуализацияBfsToolStripMenuItem1
            // 
            this.визуализацияBfsToolStripMenuItem1.Name = "визуализацияBfsToolStripMenuItem1";
            this.визуализацияBfsToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.визуализацияBfsToolStripMenuItem1.Text = "Визуализация bfs";
            this.визуализацияBfsToolStripMenuItem1.Click += new System.EventHandler(this.визуализацияBfsToolStripMenuItem1_Click);
            // 
            // визуализацияDfsToolStripMenuItem
            // 
            this.визуализацияDfsToolStripMenuItem.Name = "визуализацияDfsToolStripMenuItem";
            this.визуализацияDfsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.визуализацияDfsToolStripMenuItem.Text = "Визуализация dfs";
            this.визуализацияDfsToolStripMenuItem.Click += new System.EventHandler(this.визуализацияDfsToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // проверкаBfsToolStripMenuItem
            // 
            this.проверкаBfsToolStripMenuItem.Name = "проверкаBfsToolStripMenuItem";
            this.проверкаBfsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.проверкаBfsToolStripMenuItem.Text = "Проверка bfs";
            this.проверкаBfsToolStripMenuItem.Click += new System.EventHandler(this.проверкаBfsToolStripMenuItem_Click);
            // 
            // проверкаDfsToolStripMenuItem
            // 
            this.проверкаDfsToolStripMenuItem.Name = "проверкаDfsToolStripMenuItem";
            this.проверкаDfsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.проверкаDfsToolStripMenuItem.Text = "Проверка dfs";
            this.проверкаDfsToolStripMenuItem.Click += new System.EventHandler(this.проверкаDfsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 404);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Визуализвция BFS";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem всавитьГрафToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem визуализацияBfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem визуализацияDfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаBfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаDfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem визуализацияBfsToolStripMenuItem1;
    }
}

