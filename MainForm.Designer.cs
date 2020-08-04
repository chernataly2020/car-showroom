namespace Автосалон
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приложениеToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.продажиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзПриложенияToolStripMenuItem});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            this.приложениеToolStripMenuItem.ToolTipText = "Режим работы с приложением";
            // 
            // выходИзПриложенияToolStripMenuItem
            // 
            this.выходИзПриложенияToolStripMenuItem.Name = "выходИзПриложенияToolStripMenuItem";
            this.выходИзПриложенияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходИзПриложенияToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.выходИзПриложенияToolStripMenuItem.Text = "Выход из приложения";
            this.выходИзПриложенияToolStripMenuItem.ToolTipText = "Завершение работы с приложением";
            this.выходИзПриложенияToolStripMenuItem.Click += new System.EventHandler(this.выходИзПриложенияToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителиАвтомобилейToolStripMenuItem,
            this.моделиАвтомобилейToolStripMenuItem,
            this.автомобилиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.ToolTipText = "Режим работы со справочниками";
            // 
            // производителиАвтомобилейToolStripMenuItem
            // 
            this.производителиАвтомобилейToolStripMenuItem.Name = "производителиАвтомобилейToolStripMenuItem";
            this.производителиАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.производителиАвтомобилейToolStripMenuItem.Text = "Производители автомобилей";
            this.производителиАвтомобилейToolStripMenuItem.ToolTipText = "Работа со справочником \"Производители автомобилей\"";
            this.производителиАвтомобилейToolStripMenuItem.Click += new System.EventHandler(this.производителиАвтомобилейToolStripMenuItem_Click);
            // 
            // моделиАвтомобилейToolStripMenuItem
            // 
            this.моделиАвтомобилейToolStripMenuItem.Name = "моделиАвтомобилейToolStripMenuItem";
            this.моделиАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.моделиАвтомобилейToolStripMenuItem.Text = "Модели автомобилей";
            this.моделиАвтомобилейToolStripMenuItem.ToolTipText = "Работа со справочником \"Модели автомобилей\"";
            this.моделиАвтомобилейToolStripMenuItem.Click += new System.EventHandler(this.моделиАвтомобилейToolStripMenuItem_Click);
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.ToolTipText = "Работа со справочником \"Автомобили\"";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.историяПродажToolStripMenuItem});
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.ToolTipText = "Режим работы с продажами";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.ToolTipText = "Работа со справочником \"Клиенты\"";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // историяПродажToolStripMenuItem
            // 
            this.историяПродажToolStripMenuItem.Name = "историяПродажToolStripMenuItem";
            this.историяПродажToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.историяПродажToolStripMenuItem.Text = "История продаж";
            this.историяПродажToolStripMenuItem.ToolTipText = "Режим работы \"История продаж\"";
            this.историяПродажToolStripMenuItem.Click += new System.EventHandler(this.историяПродажToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(309, 17);
            this.toolStripStatusLabel1.Text = "Главное окно приложения. Выберите режим работы...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 614);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Автосалон \"Крутой вираж\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem приложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяПродажToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
    }
}

