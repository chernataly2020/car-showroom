using System;
using System.Windows.Forms;

namespace Автосалон
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void производителиАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Режим работы "Производители автомобилей"
            Производители_автомобилей newMDIChild = new Производители_автомобилей();

            // Установить родительское окно для дочернего окна
            newMDIChild.MdiParent = this;
            // newMDIChild.WindowState = FormWindowState.Maximized;

            // Отобразить новую форму
            newMDIChild.Show();
            toolStripStatusLabel1.Text = "Режим работы \"Производители автомобилей\"";

        }

        private void моделиАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Режим работы "Модели автомобилей"
            Модели_автомобилей newMDIChild = new Модели_автомобилей();

            // Установить родительское окно для дочернего окна
            newMDIChild.MdiParent = this;
            // newMDIChild.WindowState = FormWindowState.Maximized;

            // Отобразить новую форму
            newMDIChild.Show();
            toolStripStatusLabel1.Text = "Режим работы \"Модели автомобилей\"";
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Режим работы "Автомобили"
            Автомобили newMDIChild = new Автомобили();

            // Установить родительское окно для дочернего окна
            newMDIChild.MdiParent = this;
            // newMDIChild.WindowState = FormWindowState.Maximized;

            // Отобразить новую форму
            newMDIChild.Show();
            toolStripStatusLabel1.Text = "Режим работы \"Автомобили\"";
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Режим работы "Клиенты"
            Клиенты newMDIChild = new Клиенты();

            // Установить родительское окно для дочернего окна
            newMDIChild.MdiParent = this;
            // newMDIChild.WindowState = FormWindowState.Maximized;

            // Отобразить новую форму
            newMDIChild.Show();
            toolStripStatusLabel1.Text = "Режим работы \"Клиенты\"";
        }

        private void историяПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Режим работы "История продаж"
            Архив_покупок newMDIChild = new Архив_покупок();

            // Установить родительское окно для дочернего окна
            newMDIChild.MdiParent = this;
            // newMDIChild.WindowState = FormWindowState.Maximized;

            // Отобразить новую форму
            newMDIChild.Show();
            toolStripStatusLabel1.Text = "Режим работы \"История продаж\"";
        }
    }
}
