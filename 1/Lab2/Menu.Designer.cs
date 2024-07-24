
namespace Lab2
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроизвольнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонцеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроизвольнойТочкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрушениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заданиеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСпискаToolStripMenuItem,
            this.редактированиеСпискаToolStripMenuItem,
            this.обработкаToolStripMenuItem,
            this.разрушениеToolStripMenuItem});
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданиеToolStripMenuItem.Text = "Задание";
            // 
            // созданиеСпискаToolStripMenuItem
            // 
            this.созданиеСпискаToolStripMenuItem.Name = "созданиеСпискаToolStripMenuItem";
            this.созданиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.созданиеСпискаToolStripMenuItem.Text = "Создание списка";
            this.созданиеСпискаToolStripMenuItem.Click += new System.EventHandler(this.созданиеСпискаToolStripMenuItem_Click);
            // 
            // редактированиеСпискаToolStripMenuItem
            // 
            this.редактированиеСпискаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеЭлементаToolStripMenuItem,
            this.удалениеЭлементаToolStripMenuItem});
            this.редактированиеСпискаToolStripMenuItem.Name = "редактированиеСпискаToolStripMenuItem";
            this.редактированиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.редактированиеСпискаToolStripMenuItem.Text = "Редактирование списка";
            // 
            // добавлениеЭлементаToolStripMenuItem
            // 
            this.добавлениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалоToolStripMenuItem,
            this.вКонецToolStripMenuItem,
            this.вПроизвольнуюToolStripMenuItem});
            this.добавлениеЭлементаToolStripMenuItem.Name = "добавлениеЭлементаToolStripMenuItem";
            this.добавлениеЭлементаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.добавлениеЭлементаToolStripMenuItem.Text = "Добавление элемента";
            // 
            // вНачалоToolStripMenuItem
            // 
            this.вНачалоToolStripMenuItem.Name = "вНачалоToolStripMenuItem";
            this.вНачалоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вНачалоToolStripMenuItem.Text = "В начало";
            this.вНачалоToolStripMenuItem.Click += new System.EventHandler(this.вНачалоToolStripMenuItem_Click);
            // 
            // вКонецToolStripMenuItem
            // 
            this.вКонецToolStripMenuItem.Name = "вКонецToolStripMenuItem";
            this.вКонецToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вКонецToolStripMenuItem.Text = "В конец";
            this.вКонецToolStripMenuItem.Click += new System.EventHandler(this.вКонецToolStripMenuItem_Click);
            // 
            // вПроизвольнуюToolStripMenuItem
            // 
            this.вПроизвольнуюToolStripMenuItem.Name = "вПроизвольнуюToolStripMenuItem";
            this.вПроизвольнуюToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вПроизвольнуюToolStripMenuItem.Text = "В произвольную";
            this.вПроизвольнуюToolStripMenuItem.Click += new System.EventHandler(this.вПроизвольнуюToolStripMenuItem_Click);
            // 
            // удалениеЭлементаToolStripMenuItem
            // 
            this.удалениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалеToolStripMenuItem,
            this.вКонцеToolStripMenuItem,
            this.вПроизвольнойТочкеToolStripMenuItem});
            this.удалениеЭлементаToolStripMenuItem.Name = "удалениеЭлементаToolStripMenuItem";
            this.удалениеЭлементаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.удалениеЭлементаToolStripMenuItem.Text = "Удаление элемента";
            // 
            // вНачалеToolStripMenuItem
            // 
            this.вНачалеToolStripMenuItem.Name = "вНачалеToolStripMenuItem";
            this.вНачалеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вНачалеToolStripMenuItem.Text = "В начале";
            this.вНачалеToolStripMenuItem.Click += new System.EventHandler(this.вНачалеToolStripMenuItem_Click);
            // 
            // вКонцеToolStripMenuItem
            // 
            this.вКонцеToolStripMenuItem.Name = "вКонцеToolStripMenuItem";
            this.вКонцеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вКонцеToolStripMenuItem.Text = "В конце";
            this.вКонцеToolStripMenuItem.Click += new System.EventHandler(this.вКонцеToolStripMenuItem_Click);
            // 
            // вПроизвольнойТочкеToolStripMenuItem
            // 
            this.вПроизвольнойТочкеToolStripMenuItem.Name = "вПроизвольнойТочкеToolStripMenuItem";
            this.вПроизвольнойТочкеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вПроизвольнойТочкеToolStripMenuItem.Text = "В произвольной точке";
            this.вПроизвольнойТочкеToolStripMenuItem.Click += new System.EventHandler(this.вПроизвольнойТочкеToolStripMenuItem_Click);
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            this.обработкаToolStripMenuItem.Click += new System.EventHandler(this.обработкаToolStripMenuItem_Click);
            // 
            // разрушениеToolStripMenuItem
            // 
            this.разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            this.разрушениеToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.разрушениеToolStripMenuItem.Text = "Разрушение";
            this.разрушениеToolStripMenuItem.Click += new System.EventHandler(this.разрушениеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Лабораторная работа №1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеЭлементаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеЭлементаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вНачалоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКонецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПроизвольнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вНачалеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКонцеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПроизвольнойТочкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрушениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

