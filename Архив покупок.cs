using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Автосалон
{
    public partial class Архив_покупок : Form
    {
        public Архив_покупок()
        {
            InitializeComponent();
        }

        private void Архив_покупок_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.автосалонDataSet.Avto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Klients". При необходимости она может быть перемещена или удалена.
            this.klientsTableAdapter.Fill(this.автосалонDataSet.Klients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Prodazhi". При необходимости она может быть перемещена или удалена.
            this.prodazhiTableAdapter.Fill(this.автосалонDataSet.Prodazhi);

        }

        private void FirstRecord_Click(object sender, EventArgs e)
        {
            // Переход на первую запись
            prodazhiBindingSource.MoveFirst();
            int curRecord = prodazhiBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void EndRecord_Click(object sender, EventArgs e)
        {
            // Переход на последнюю запись
            prodazhiBindingSource.MoveLast();
            int curRecord = prodazhiBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void PreviewRecord_Click(object sender, EventArgs e)
        {
            // Переход на предыдущую запись
            prodazhiBindingSource.MovePrevious();
            int curRecord = prodazhiBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void NextRecord_Click(object sender, EventArgs e)
        {
            // Переход на следующую запись
            prodazhiBindingSource.MoveNext();
            int curRecord = prodazhiBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            this.prodazhiTableAdapter.Update(this.автосалонDataSet.Prodazhi);
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            this.prodazhiTableAdapter.Update(this.автосалонDataSet.Prodazhi);
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = (DataRowView)prodazhiBindingSource.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            string Kod_prodazh = curRow.Cells[0].Value.ToString();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


            OleDbCommand deleteStr = new OleDbCommand("DELETE FROM Prodazhi WHERE  Kod_prodazh = ?", conn);
            deleteStr.Parameters.Add(Kod_prodazh, OleDbType.Variant).Value = Kod_prodazh;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            deleteStr.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            this.автосалонDataSet.Prodazhi.Clear();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string strCmd = "SELECT * FROM Prodazhi";
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(this.автосалонDataSet.Prodazhi);
        }
    }
}
