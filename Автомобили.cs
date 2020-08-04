using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Автосалон
{
    public partial class Автомобили : Form
    {
        public Автомобили()
        {
            InitializeComponent();
        }

        DataTable ModelsAvto = new DataTable();
        string strKorzina;
        OleDbCommand cmdKorzina;

        OleDbDataAdapter adapKorzina;
        DataTable Korzina;
        BindingSource bsKorzina;



        private void Автомобили_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Models_of_avto". При необходимости она может быть перемещена или удалена.
            this.models_of_avtoTableAdapter.Fill(this.автосалонDataSet.Models_of_avto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.автосалонDataSet.Avto);
            strKorzina = "SELECT *  FROM   Bag";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            cmdKorzina = new OleDbCommand(strKorzina, conn);
            // Копирование данных в локальную таблицу
            adapKorzina = new OleDbDataAdapter(cmdKorzina);
            Korzina = new DataTable();
            adapKorzina.Fill(Korzina);
            dataGridView2.DataSource = Korzina;
            dataGridView2.Columns[0].HeaderText = "Код автомобиля";
            dataGridView2.Columns[1].HeaderText = "Название автомобиля";
            dataGridView2.Columns[2].HeaderText = "Цена";
            dataGridView2.Columns[3].HeaderText = "Количество";
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void FirstRecord_Click(object sender, EventArgs e)
        {
            // Переход на первую запись
            avtoBindingSource.MoveFirst();
            int curRecord = avtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void EndRecord_Click(object sender, EventArgs e)
        {
            // Переход на последнюю запись
            avtoBindingSource.MoveLast();
            int curRecord = avtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void PreviewRecord_Click(object sender, EventArgs e)
        {
            // Переход на предыдущую запись
            avtoBindingSource.MovePrevious();
            int curRecord = avtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void NextRecord_Click(object sender, EventArgs e)
        {
            // Переход на следующую запись
            avtoBindingSource.MoveNext();
            int curRecord = avtoBindingSource.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            this.avtoTableAdapter.Update(this.автосалонDataSet.Avto);
            this.avtoTableAdapter.Fill(this.автосалонDataSet.Avto);           
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            this.avtoTableAdapter.Update(this.автосалонDataSet.Avto);
            this.avtoTableAdapter.Fill(this.автосалонDataSet.Avto);
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = (DataRowView)avtoBindingSource.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            string Kod_avto = curRow.Cells[0].Value.ToString();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


            OleDbCommand deleteStr = new OleDbCommand("DELETE FROM Avto WHERE  Kod_avto = ?", conn);
            deleteStr.Parameters.Add(Kod_avto, OleDbType.Variant).Value = Kod_avto;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            deleteStr.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            this.автосалонDataSet.Avto.Clear();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string strCmd = "SELECT * FROM Avto";
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(this.автосалонDataSet.Avto);
        }

        private void zaprosPrice1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.avtoTableAdapter.ZaprosPrice1(this.автосалонDataSet.Avto, new System.Nullable<Int32>(((Int32)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(Int32))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void zaprosDate1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.avtoTableAdapter.ZaprosDate1(this.автосалонDataSet.Avto, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(date_vipToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void allRecordsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.avtoTableAdapter.AllRecords(this.автосалонDataSet.Avto);
                date_vipToolStripTextBox.Text = string.Empty;
                priceToolStripTextBox.Text = string.Empty;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        decimal SumTovars()
        {
            decimal Price, Sum = 0;
            int Kol;

            foreach (DataRow row in Korzina.Rows)
            {
                Price = Convert.ToDecimal(row["Price"]);
                Kol = Convert.ToInt32(row["Kol"]);
                Sum = Sum + Price * Kol;
            }
            return Sum;
        }

        private void AddToBag_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = dataGridView1.CurrentRow;

            string Kod_avto = curRow.Cells[0].Value.ToString();
            string Name_avto =curRow.Cells[1].Value.ToString();
            string Price = curRow.Cells[4].Value.ToString();
            string Kol = kol.Text;
            if (kol.Text != string.Empty)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");

                OleDbCommand insertStr = new OleDbCommand("INSERT INTO Bag "+
                                           "(Kod_avto, Name_avto, Price, Kol) VALUES (@Kod_avto, @Name_avto, @Price, @Kol)", conn);

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                insertStr.Parameters.Add("@Kod_avto", OleDbType.Numeric).Value = Kod_avto;
                insertStr.Parameters.Add("@Name_avto", OleDbType.Char).Value = Name_avto;
                insertStr.Parameters.Add("@Price", OleDbType.Numeric).Value = Price;
                insertStr.Parameters.Add("@Kol", OleDbType.Numeric).Value = Kol;

                insertStr.ExecuteNonQuery();

                // Вывод данных обновленной таблицы
                Korzina.Clear();
                string strCmd = "SELECT * FROM Bag";
                OleDbDataAdapter adapKorzina = new OleDbDataAdapter(strCmd, conn);
                adapKorzina.Fill(Korzina);
                //dataGridView2.DataSource = bsKorzina;
                Summa.Text = SumTovars().ToString();
                kol.Text=string.Empty;
            }
            else
                MessageBox.Show("Введите количество товара", "Работа с корзиной", MessageBoxButtons.OK);

        }

        private void Автомобили_FormClosed(object sender, FormClosedEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


            OleDbCommand deleteStr = new OleDbCommand("DELETE * FROM Bag", conn);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            deleteStr.ExecuteNonQuery();
        }

        private void DeleteFromBag_Click(object sender, EventArgs e)
        {
            // Код для кнопки из Корзины
            DataGridViewRow curRow = dataGridView2.CurrentRow;

            string ID = curRow.Cells[0].Value.ToString();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


            OleDbCommand deleteStr = new OleDbCommand("DELETE * FROM Bag WHERE Kod_avto=@ID", conn);
            deleteStr.Parameters.Add("@ID", OleDbType.Numeric).Value = ID;

            if (conn.State != ConnectionState.Open)
                conn.Open();
            deleteStr.ExecuteNonQuery();
            Korzina.Clear();
            // Вывод данных обновленной таблицы
            strKorzina = "SELECT *  FROM   Bag";
            cmdKorzina = new OleDbCommand(strKorzina, conn);
            // Копирование данных в локальную таблицу
            adapKorzina = new OleDbDataAdapter(cmdKorzina);
            Korzina = new DataTable();
            adapKorzina.Fill(Korzina);

            Summa.Text = SumTovars().ToString();

        }
    }
}
