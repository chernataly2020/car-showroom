using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Автосалон
{
    public partial class Клиенты : Form
    {
        public Клиенты()
        {
            InitializeComponent();
        }

        DataTable Data_Klients = new DataTable();
        BindingSource bsKlients = new BindingSource();

        private void Клиенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосалонDataSet.Klients". При необходимости она может быть перемещена или удалена.
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb";

            string strCmd = "SELECT * FROM Klients";

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            if (conn.State != ConnectionState.Open)
                conn.Open();

            OleDbDataAdapter adapKlients = new OleDbDataAdapter(strCmd, strConn);
            

            adapKlients.Fill(Data_Klients);

            dataGridView1.DataSource = Data_Klients;
            dataGridView1.Columns[0].HeaderText = "Код клиента";
            dataGridView1.Columns[1].HeaderText = "ФИО клиента";
            dataGridView1.Columns[2].HeaderText = "Адрес клиента";
            dataGridView1.Columns[3].HeaderText = "Номер телефона";
            dataGridView1.Columns[4].HeaderText = "Паспортные данные";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            bsKlients.DataSource = Data_Klients.DefaultView;
            DataRowView dataRow = (DataRowView)bsKlients.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Kod_klient"].Value.ToString();
            textBox2.Text = curRow.Cells["FIO_klient"].Value.ToString();
            textBox3.Text = curRow.Cells["Address_klient"].Value.ToString();
            textBox4.Text = curRow.Cells["Number_of_phone"].Value.ToString();
            textBox5.Text = curRow.Cells["Pasport"].Value.ToString();
        }

        private void FirstRecord_Click(object sender, EventArgs e)
        {
            // Переход на первую запись
            bsKlients.MoveFirst();
            int curRecord = bsKlients.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void EndRecord_Click(object sender, EventArgs e)
        {
            // Переход на последнюю запись
            bsKlients.MoveLast();
            int curRecord = bsKlients.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void PreviewRecord_Click(object sender, EventArgs e)
        {
            // Переход на предыдущую запись
            bsKlients.MovePrevious();
            int curRecord = bsKlients.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void NextRecord_Click(object sender, EventArgs e)
        {
            // Переход на следующую запись
            bsKlients.MoveNext();
            int curRecord = bsKlients.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            string Kod_klient = textBox1.Text;
            string FIO_klient = textBox2.Text;
            string Address_klient = textBox3.Text;
            string Number_of_phone = textBox4.Text;
            string Pasport = textBox5.Text;


            if ((Kod_klient != String.Empty) || (FIO_klient != String.Empty) || (Address_klient != String.Empty) || (Number_of_phone != String.Empty)||(Pasport!=String.Empty))
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand insertStr = new OleDbCommand("INSERT INTO Klients (Kod_klient, FIO_klient, Address_klient, Number_of_phone, Pasport) VALUES (?, ?, ?, ?, ?)", conn);

                insertStr.Parameters.Add(Kod_klient, OleDbType.Numeric).Value = Kod_klient;
                insertStr.Parameters.Add(FIO_klient, OleDbType.Char).Value = FIO_klient;
                insertStr.Parameters.Add(Address_klient, OleDbType.Char).Value = Address_klient;
                insertStr.Parameters.Add(Number_of_phone, OleDbType.Char).Value = Number_of_phone;
                insertStr.Parameters.Add(Pasport, OleDbType.Char).Value = Pasport;

                insertStr.ExecuteNonQuery();

                // Вывод данных обновленной таблицы
                Data_Klients.Clear();
                string strCmd = "SELECT * FROM Klients";
                OleDbDataAdapter adapKlients = new OleDbDataAdapter(strCmd, conn);
                adapKlients.Fill(Data_Klients);
                DataRowView dataRow = (DataRowView)bsKlients.Current;
                DataGridViewRow curRow = dataGridView1.CurrentRow;
                textBox1.Text = curRow.Cells["Kod_klient"].Value.ToString();
                textBox2.Text = curRow.Cells["FIO_klient"].Value.ToString();
                textBox3.Text = curRow.Cells["Address_klient"].Value.ToString();
                textBox4.Text = curRow.Cells["Number_of_phone"].Value.ToString();
                textBox5.Text = curRow.Cells["Pasport"].Value.ToString();

            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            string Kod_klient = textBox1.Text;
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


            OleDbCommand deleteStr = new OleDbCommand("DELETE FROM Klients WHERE  Kod_klient = ?", conn);
            deleteStr.Parameters.Add(Kod_klient, OleDbType.Variant).Value = Kod_klient;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            deleteStr.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            Data_Klients.Clear();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string strCmd = "SELECT * FROM Klients";
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(Data_Klients);
            textBox5.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox1.Text = String.Empty;
            DataRowView dataRow = (DataRowView)bsKlients.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Kod_klient"].Value.ToString();
            textBox2.Text = curRow.Cells["FIO_klient"].Value.ToString();
            textBox3.Text = curRow.Cells["Address_klient"].Value.ToString();
            textBox4.Text = curRow.Cells["Number_of_phone"].Value.ToString();
            textBox5.Text = curRow.Cells["Pasport"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Выбор текущей записи
            DataRowView dataRow = (DataRowView)bsKlients.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Kod_klient"].Value.ToString();
            textBox2.Text = curRow.Cells["FIO_klient"].Value.ToString();
            textBox3.Text = curRow.Cells["Address_klient"].Value.ToString();
            textBox4.Text = curRow.Cells["Number_of_phone"].Value.ToString();
            textBox5.Text = curRow.Cells["Pasport"].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Выбор текущей записи
            DataRowView dataRow = (DataRowView)bsKlients.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Kod_klient"].Value.ToString();
            textBox2.Text = curRow.Cells["FIO_klient"].Value.ToString();
            textBox3.Text = curRow.Cells["Address_klient"].Value.ToString();
            textBox4.Text = curRow.Cells["Number_of_phone"].Value.ToString();
            textBox5.Text = curRow.Cells["Pasport"].Value.ToString();
        }
    }
}
