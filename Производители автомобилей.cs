using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;



namespace Автосалон
{
    public partial class Производители_автомобилей : Form
    {
        public Производители_автомобилей() 
        {
            InitializeComponent();
           
        }
        DataTable ProizvAvto = new DataTable();
        BindingSource bsProizvAvto = new BindingSource();

        private void Производители_автомобилей_Load(object sender, EventArgs e)
        {
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb";
            
            string strCmd = "SELECT * FROM Proizv_Avto";

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            if (conn.State != ConnectionState.Open)
                conn.Open();

            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, strConn);

            
            adapProizvAvto.Fill(ProizvAvto);

            dataGridView1.DataSource = ProizvAvto;
            dataGridView1.Columns[0].HeaderText = "Код производителя";
            dataGridView1.Columns[1].HeaderText = "Название производителя";
            dataGridView1.Columns[2].HeaderText = "Адрес производителя";
            dataGridView1.Columns[3].HeaderText = "Мощность двигателя";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            bsProizvAvto.DataSource = ProizvAvto.DefaultView;
            DataRowView dataRow = (DataRowView)bsProizvAvto.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Adress_proizv"].Value.ToString();
            textBox2.Text = curRow.Cells["Power_drive"].Value.ToString();
            textBox3.Text = curRow.Cells["Name_proizv"].Value.ToString();
            textBox4.Text = curRow.Cells["Kod_proizv"].Value.ToString();
        }

        private void FirstRecord_Click(object sender, EventArgs e)
        {
            // Переход на первую запись
            bsProizvAvto.MoveFirst();
            int curRecord = bsProizvAvto.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];        
        }

        private void EndRecord_Click(object sender, EventArgs e)
        {
            // Переход на последнюю запись
            bsProizvAvto.MoveLast();
            int curRecord = bsProizvAvto.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void PreviewRecord_Click(object sender, EventArgs e)
        {
            // Переход на предыдущую запись
            bsProizvAvto.MovePrevious();
            int curRecord = bsProizvAvto.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void NextRecord_Click(object sender, EventArgs e)
        {
            // Переход на следующую запись
            bsProizvAvto.MoveNext();
            int curRecord = bsProizvAvto.Position;
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, curRecord];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Выбор текущей записи
            DataRowView dataRow = (DataRowView)bsProizvAvto.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Adress_proizv"].Value.ToString();
            textBox2.Text = curRow.Cells["Power_drive"].Value.ToString();
            textBox3.Text = curRow.Cells["Name_proizv"].Value.ToString();
            textBox4.Text = curRow.Cells["Kod_proizv"].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Выбор текущей записи
            DataRowView dataRow = (DataRowView)bsProizvAvto.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Adress_proizv"].Value.ToString();
            textBox2.Text = curRow.Cells["Power_drive"].Value.ToString();
            textBox3.Text = curRow.Cells["Name_proizv"].Value.ToString();
            textBox4.Text = curRow.Cells["Kod_proizv"].Value.ToString();
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            string Kod_proizv = textBox4.Text;
            string Name_proizv = textBox3.Text;
            string Power_drive = textBox2.Text;
            string Adress_proizv = textBox1.Text;
            string curID = textBox4.Text;
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            OleDbCommand updateStr = new OleDbCommand("UPDATE Proizv_Avto SET Name_proizv = ?, Adress_proizv = ?, Power_drive = ? WHERE  Kod_proizv = ?", conn);

            updateStr.Parameters.Add(Name_proizv, OleDbType.Variant).Value = Name_proizv;
            updateStr.Parameters.Add(Adress_proizv, OleDbType.Variant).Value = Adress_proizv;
            updateStr.Parameters.Add(Power_drive, OleDbType.Variant).Value = Power_drive;
            updateStr.Parameters.Add(curID, OleDbType.Variant).Value = curID;

            if (conn.State != ConnectionState.Open)
                conn.Open();
            updateStr.ExecuteNonQuery();
            conn.Close();
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter();
            // Вывод данных обновленной таблицы
            ProizvAvto.Clear();
            string strCmd = "SELECT * FROM Proizv_Avto";

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
            if (conn.State != ConnectionState.Open)
                conn.Open();

            adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(ProizvAvto);
            DataRowView dataRow = (DataRowView)bsProizvAvto.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Adress_proizv"].Value.ToString();
            textBox2.Text = curRow.Cells["Power_drive"].Value.ToString();
            textBox3.Text = curRow.Cells["Name_proizv"].Value.ToString();
            textBox4.Text = curRow.Cells["Kod_proizv"].Value.ToString();
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            string Kod_proizv = textBox4.Text;
            string Name_proizv = textBox3.Text;
            string Power_drive = textBox2.Text;
            string Adress_proizv = textBox1.Text;
            string curID = textBox4.Text;

            if ((Kod_proizv != String.Empty) || (Name_proizv != String.Empty) || (Power_drive !=String.Empty) || (Adress_proizv != String.Empty))
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand insertStr = new OleDbCommand("INSERT INTO Proizv_Avto " +
                                          "(Kod_proizv, Name_proizv, Adress_proizv, Power_drive) VALUES (?, ?, ?, ?)", conn);

                insertStr.Parameters.Add(Kod_proizv, OleDbType.Numeric).Value = Kod_proizv;
                insertStr.Parameters.Add(Name_proizv, OleDbType.Char).Value = Name_proizv;
                insertStr.Parameters.Add(Adress_proizv, OleDbType.Char).Value = Adress_proizv;
                insertStr.Parameters.Add(Power_drive, OleDbType.Numeric).Value = Power_drive;

                insertStr.ExecuteNonQuery();

                // Вывод данных обновленной таблицы
                ProizvAvto.Clear();
                string strCmd = "SELECT * FROM Proizv_Avto";
                OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
                adapProizvAvto.Fill(ProizvAvto);
                DataRowView dataRow = (DataRowView)bsProizvAvto.Current;
                DataGridViewRow curRow = dataGridView1.CurrentRow;
                textBox1.Text = curRow.Cells["Adress_proizv"].Value.ToString();
                textBox2.Text = curRow.Cells["Power_drive"].Value.ToString();
                textBox3.Text = curRow.Cells["Name_proizv"].Value.ToString();
                textBox4.Text = curRow.Cells["Kod_proizv"].Value.ToString();
            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            string Kod_proizv = textBox4.Text;
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Автосалон.accdb");


                        OleDbCommand deleteStr = new OleDbCommand ("DELETE FROM Proizv_Avto WHERE  Kod_proizv = ?", conn);
            deleteStr.Parameters.Add(Kod_proizv, OleDbType.Variant).Value = Kod_proizv;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            deleteStr.ExecuteNonQuery();

            // Вывод данных обновленной таблицы
            ProizvAvto.Clear();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string strCmd = "SELECT * FROM Proizv_Avto";
            OleDbDataAdapter adapProizvAvto = new OleDbDataAdapter(strCmd, conn);
            adapProizvAvto.Fill(ProizvAvto);
            textBox4.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox1.Text = String.Empty;
            DataRowView dataRow = (DataRowView)bsProizvAvto.Current;
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            textBox1.Text = curRow.Cells["Adress_proizv"].Value.ToString();
            textBox2.Text = curRow.Cells["Power_drive"].Value.ToString();
            textBox3.Text = curRow.Cells["Name_proizv"].Value.ToString();
            textBox4.Text = curRow.Cells["Kod_proizv"].Value.ToString();
        }
    }
}
