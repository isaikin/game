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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.визуализацияBfsToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.всавитьГрафToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // новыйToolStripMenuItem
            // 
            resources.ApplyResources(this.новыйToolStripMenuItem, "новыйToolStripMenuItem");
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // всавитьГрафToolStripMenuItem
            // 
            resources.ApplyResources(this.всавитьГрафToolStripMenuItem, "всавитьГрафToolStripMenuItem");
            this.всавитьГрафToolStripMenuItem.Name = "всавитьГрафToolStripMenuItem";
            this.всавитьГрафToolStripMenuItem.Click += new System.EventHandler(this.всавитьГрафToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // визуализацияBfsToolStripMenuItem
            // 
            resources.ApplyResources(this.визуализацияBfsToolStripMenuItem, "визуализацияBfsToolStripMenuItem");
            this.визуализацияBfsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.визуализацияBfsToolStripMenuItem1,
            this.визуализацияDfsToolStripMenuItem,
            this.сбросToolStripMenuItem,
            this.проверкаBfsToolStripMenuItem,
            this.проверкаDfsToolStripMenuItem});
            this.визуализацияBfsToolStripMenuItem.Name = "визуализацияBfsToolStripMenuItem";
            // 
            // визуализацияBfsToolStripMenuItem1
            // 
            resources.ApplyResources(this.визуализацияBfsToolStripMenuItem1, "визуализацияBfsToolStripMenuItem1");
            this.визуализацияBfsToolStripMenuItem1.Name = "визуализацияBfsToolStripMenuItem1";
            this.визуализацияBfsToolStripMenuItem1.Click += new System.EventHandler(this.визуализацияBfsToolStripMenuItem1_Click);
            // 
            // визуализацияDfsToolStripMenuItem
            // 
            resources.ApplyResources(this.визуализацияDfsToolStripMenuItem, "визуализацияDfsToolStripMenuItem");
            this.визуализацияDfsToolStripMenuItem.Name = "визуализацияDfsToolStripMenuItem";
            this.визуализацияDfsToolStripMenuItem.Click += new System.EventHandler(this.визуализацияDfsToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            resources.ApplyResources(this.сбросToolStripMenuItem, "сбросToolStripMenuItem");
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // проверкаBfsToolStripMenuItem
            // 
            resources.ApplyResources(this.проверкаBfsToolStripMenuItem, "проверкаBfsToolStripMenuItem");
            this.проверкаBfsToolStripMenuItem.Name = "проверкаBfsToolStripMenuItem";
            this.проверкаBfsToolStripMenuItem.Click += new System.EventHandler(this.проверкаBfsToolStripMenuItem_Click);
            // 
            // проверкаDfsToolStripMenuItem
            // 
            resources.ApplyResources(this.проверкаDfsToolStripMenuItem, "проверкаDfsToolStripMenuItem");
            this.проверкаDfsToolStripMenuItem.Name = "проверкаDfsToolStripMenuItem";
            this.проверкаDfsToolStripMenuItem.Click += new System.EventHandler(this.проверкаDfsToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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

