using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Автосалон
{
    public partial class Модели_автомобилей : Form
    {
        public Модели_автомобилей()
        {
            InitializeComponent();
        }
        DataTable ModelsAvto = new DataTable();

        private void Модели_автомобилей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Proizv_Avto". При необходимости она может быть перемещена или удалена.
            this.proizv_AvtoTableAdapter.Fill(this.автосалонDataSet.Proizv_Avto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Models_of_avto". При необходимости она может быть перемещена или удалена.
            this.models_of_avtoTableAdapter.Fill(this.автосалонDataSet.Models_of_avto);
        }

        private void FirstRecord_Click(object sender, EventArgs e)
        {
            // Переход на первую запись
            modelsofavtoBindingSource.MoveFirst();
            int curRecord = modelsofavtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void EndRecord_Click(object sender, EventArgs e)
        {
            // Переход на последнюю запись
            modelsofavtoBindingSource.MoveLast();
            int curRecord = modelsofavtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void PreviewRecord_Click(object sender, EventArgs e)
        {
            // Переход на предыдущую запись
            modelsofavtoBindingSource.MovePrevious();
            int curRecord = modelsofavtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void NextRecord_Click(object sender, EventArgs e)
        {
            // Переход на следующую запись
            modelsofavtoBindingSource.MoveNext();
            int curRecord = modelsofavtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            OleDbCommand insertStr;
            DataRowView dataRow = (DataRowView)modelsofavtoBindingSource.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            string Kod_model = curRow.Cells[0].Value.ToString();
            string Kod_proizv = curRow.Cells[1].Value.ToString();
            string Model = curRow.Cells[2].Value.ToString();
            string Obem_drive = curRow.Cells[3].Value.ToString();
            string Power_drive = curRow.Cells[4].Value.ToString();

            if ((Kod_model != String.Empty) || (Kod_proizv != String.Empty) || (Model != String.Empty) || (Power_drive != String.Empty) || (Obem_drive != String.Empty))
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                try
                {
                    insertStr = new OleDbCommand("INSERT INTO Models_of_avto " +
                                              "(Kod_model, Kod_proizv, Model, Obem_drive, Power_drive) VALUES (?, ?, ?, ?, ?)", conn);

                    insertStr.Parameters.Add(Kod_model, OleDbType.Numeric).Value = Kod_model;
                    insertStr.Parameters.Add(Kod_proizv, OleDbType.Numeric).Value = Kod_proizv;
                    insertStr.Parameters.Add(Model, OleDbType.Char).Value = Model;
                    insertStr.Parameters.Add(Obem_drive, OleDbType.Numeric).Value = Obem_drive;
                    insertStr.Parameters.Add(Power_drive, OleDbType.Numeric).Value = Power_drive;

                    insertStr.ExecuteNonQuery();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MessageBox.Show("Не удалось внести изменения из-за повторения в ключевом поле \"Код модели\". Ключевое поле должно быть уникальным..","Ошибка", MessageBoxButtons.OK);
                }
                // Вывод данных обновленной таблицы
                this.автосалонDataSet.Models_of_avto.Clear();
                string strCmd = "SELECT * FROM Models_of_avto";
                OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
                adapProizvAvto.Fill(this.автосалонDataSet.Models_of_avto);
            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = (DataRowView)modelsofavtoBindingSource.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            string Kod_model = curRow.Cells[0].Value.ToString();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


            OleDbCommand deleteStr = new OleDbCommand("DELETE FROM Models_of_avto WHERE  Kod_model = ?", conn);
            deleteStr.Parameters.Add(Kod_model, OleDbType.Variant).Value = Kod_model;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            deleteStr.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            this.автосалонDataSet.Models_of_avto.Clear();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string strCmd = "SELECT * FROM Models_of_avto";
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(this.автосалонDataSet.Models_of_avto);
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {

            DataRowView dataRow = (DataRowView)modelsofavtoBindingSource.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            string Kod_model = curRow.Cells[0].Value.ToString();
            string Kod_proizv = curRow.Cells[1].Value.ToString();
            string Model = curRow.Cells[2].Value.ToString();
            string Obem_drive = curRow.Cells[3].Value.ToString();
            string Power_drive = curRow.Cells[4].Value.ToString();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            OleDbCommand updateStr = new OleDbCommand("UPDATE Models_of_avto SET Kod_proizv = ?, Model = ?, Obem_drive = ?, Power_drive = ? WHERE  Kod_model = ?", conn);

            updateStr.Parameters.Add(Kod_proizv, OleDbType.Variant).Value = Kod_proizv;
            updateStr.Parameters.Add(Model, OleDbType.Variant).Value = Model;
            updateStr.Parameters.Add(Obem_drive, OleDbType.Variant).Value = Obem_drive;
            updateStr.Parameters.Add(Power_drive, OleDbType.Variant).Value = Power_drive;
            updateStr.Parameters.Add(Kod_model, OleDbType.Variant).Value = Kod_model;

            if (conn.State != ConnectionState.Open)
                conn.Open();
            updateStr.ExecuteNonQuery();
            conn.Close();
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter();
            // Вывод данных обновленной таблицы
            this.автосалонDataSet.Models_of_avto.Clear();
            string strCmd = "SELECT * FROM Models_of_avto";

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            if (conn.State != ConnectionState.Open)
                conn.Open();

            adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(this.автосалонDataSet.Models_of_avto);
        }
    }
}
