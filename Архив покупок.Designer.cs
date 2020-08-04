namespace Автосалон
{
    partial class Архив_покупок
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Архив_покупок));
            this.автосалонDataSet = new Автосалон.АвтосалонDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextRecord = new System.Windows.Forms.Button();
            this.PreviewRecord = new System.Windows.Forms.Button();
            this.EndRecord = new System.Windows.Forms.Button();
            this.FirstRecord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.AddRecord = new System.Windows.Forms.Button();
            this.prodazhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodazhiTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.ProdazhiTableAdapter();
            this.klientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientsTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.KlientsTableAdapter();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.AvtoTableAdapter();
            this.kodprodazhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kodavtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateprodazhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceprodazhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.автосалонDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // автосалонDataSet
            // 
            this.автосалонDataSet.DataSetName = "АвтосалонDataSet";
            this.автосалонDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodprodazhDataGridViewTextBoxColumn,
            this.kodklientDataGridViewTextBoxColumn,
            this.kodavtoDataGridViewTextBoxColumn,
            this.dateprodazhDataGridViewTextBoxColumn,
            this.priceprodazhDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodazhiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(855, 483);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NextRecord);
            this.groupBox1.Controls.Add(this.PreviewRecord);
            this.groupBox1.Controls.Add(this.EndRecord);
            this.groupBox1.Controls.Add(this.FirstRecord);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перемещение по записям";
            // 
            // NextRecord
            // 
            this.NextRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NextRecord.Location = new System.Drawing.Point(202, 57);
            this.NextRecord.Name = "NextRecord";
            this.NextRecord.Size = new System.Drawing.Size(180, 23);
            this.NextRecord.TabIndex = 3;
            this.NextRecord.Text = "Следующая запись";
            this.NextRecord.UseVisualStyleBackColor = true;
            this.NextRecord.Click += new System.EventHandler(this.NextRecord_Click);
            // 
            // PreviewRecord
            // 
            this.PreviewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviewRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PreviewRecord.Location = new System.Drawing.Point(7, 57);
            this.PreviewRecord.Name = "PreviewRecord";
            this.PreviewRecord.Size = new System.Drawing.Size(189, 23);
            this.PreviewRecord.TabIndex = 2;
            this.PreviewRecord.Text = "Предыдущая запись";
            this.PreviewRecord.UseVisualStyleBackColor = true;
            this.PreviewRecord.Click += new System.EventHandler(this.PreviewRecord_Click);
            // 
            // EndRecord
            // 
            this.EndRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EndRecord.Location = new System.Drawing.Point(202, 27);
            this.EndRecord.Name = "EndRecord";
            this.EndRecord.Size = new System.Drawing.Size(180, 23);
            this.EndRecord.TabIndex = 1;
            this.EndRecord.Text = "Последняя запись";
            this.EndRecord.UseVisualStyleBackColor = true;
            this.EndRecord.Click += new System.EventHandler(this.EndRecord_Click);
            // 
            // FirstRecord
            // 
            this.FirstRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstRecord.Location = new System.Drawing.Point(6, 27);
            this.FirstRecord.Name = "FirstRecord";
            this.FirstRecord.Size = new System.Drawing.Size(190, 23);
            this.FirstRecord.TabIndex = 0;
            this.FirstRecord.Text = "Первая запись";
            this.FirstRecord.UseVisualStyleBackColor = true;
            this.FirstRecord.Click += new System.EventHandler(this.FirstRecord_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditRecord);
            this.groupBox2.Controls.Add(this.DeleteRecord);
            this.groupBox2.Controls.Add(this.AddRecord);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(406, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции с записями";
            // 
            // EditRecord
            // 
            this.EditRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditRecord.Location = new System.Drawing.Point(69, 56);
            this.EditRecord.Name = "EditRecord";
            this.EditRecord.Size = new System.Drawing.Size(320, 23);
            this.EditRecord.TabIndex = 2;
            this.EditRecord.Text = "Редактировать запись";
            this.EditRecord.UseVisualStyleBackColor = true;
            this.EditRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteRecord.Location = new System.Drawing.Point(254, 27);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(177, 23);
            this.DeleteRecord.TabIndex = 1;
            this.DeleteRecord.Text = "Удалить запись";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // AddRecord
            // 
            this.AddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddRecord.Location = new System.Drawing.Point(6, 27);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(200, 23);
            this.AddRecord.TabIndex = 0;
            this.AddRecord.Text = "Добавить запись";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // prodazhiBindingSource
            // 
            this.prodazhiBindingSource.DataMember = "Prodazhi";
            this.prodazhiBindingSource.DataSource = this.автосалонDataSet;
            // 
            // prodazhiTableAdapter
            // 
            this.prodazhiTableAdapter.ClearBeforeFill = true;
            // 
            // klientsBindingSource
            // 
            this.klientsBindingSource.DataMember = "Klients";
            this.klientsBindingSource.DataSource = this.автосалонDataSet;
            // 
            // klientsTableAdapter
            // 
            this.klientsTableAdapter.ClearBeforeFill = true;
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "Avto";
            this.avtoBindingSource.DataSource = this.автосалонDataSet;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // kodprodazhDataGridViewTextBoxColumn
            // 
            this.kodprodazhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodprodazhDataGridViewTextBoxColumn.DataPropertyName = "Kod_prodazh";
            this.kodprodazhDataGridViewTextBoxColumn.HeaderText = "Кода продажи";
            this.kodprodazhDataGridViewTextBoxColumn.Name = "kodprodazhDataGridViewTextBoxColumn";
            // 
            // kodklientDataGridViewTextBoxColumn
            // 
            this.kodklientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodklientDataGridViewTextBoxColumn.DataPropertyName = "Kod_klient";
            this.kodklientDataGridViewTextBoxColumn.DataSource = this.klientsBindingSource;
            this.kodklientDataGridViewTextBoxColumn.DisplayMember = "FIO_klient";
            this.kodklientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.kodklientDataGridViewTextBoxColumn.Name = "kodklientDataGridViewTextBoxColumn";
            this.kodklientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kodklientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kodklientDataGridViewTextBoxColumn.ValueMember = "Kod_klient";
            // 
            // kodavtoDataGridViewTextBoxColumn
            // 
            this.kodavtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodavtoDataGridViewTextBoxColumn.DataPropertyName = "Kod_avto";
            this.kodavtoDataGridViewTextBoxColumn.DataSource = this.avtoBindingSource;
            this.kodavtoDataGridViewTextBoxColumn.DisplayMember = "Name_avto";
            this.kodavtoDataGridViewTextBoxColumn.HeaderText = "Автомобиль";
            this.kodavtoDataGridViewTextBoxColumn.Name = "kodavtoDataGridViewTextBoxColumn";
            this.kodavtoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kodavtoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kodavtoDataGridViewTextBoxColumn.ValueMember = "Kod_avto";
            // 
            // dateprodazhDataGridViewTextBoxColumn
            // 
            this.dateprodazhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateprodazhDataGridViewTextBoxColumn.DataPropertyName = "Date_prodazh";
            this.dateprodazhDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.dateprodazhDataGridViewTextBoxColumn.Name = "dateprodazhDataGridViewTextBoxColumn";
            // 
            // priceprodazhDataGridViewTextBoxColumn
            // 
            this.priceprodazhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceprodazhDataGridViewTextBoxColumn.DataPropertyName = "Price_prodazh";
            this.priceprodazhDataGridViewTextBoxColumn.HeaderText = "Цена продажи";
            this.priceprodazhDataGridViewTextBoxColumn.Name = "priceprodazhDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // Архив_покупок
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 483);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Архив_покупок";
            this.Text = "История продаж";
            this.Load += new System.EventHandler(this.Архив_покупок_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автосалонDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private АвтосалонDataSet автосалонDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextRecord;
        private System.Windows.Forms.Button PreviewRecord;
        private System.Windows.Forms.Button EndRecord;
        private System.Windows.Forms.Button FirstRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.BindingSource prodazhiBindingSource;
        private АвтосалонDataSetTableAdapters.ProdazhiTableAdapter prodazhiTableAdapter;
        private System.Windows.Forms.BindingSource klientsBindingSource;
        private АвтосалонDataSetTableAdapters.KlientsTableAdapter klientsTableAdapter;
        private System.Windows.Forms.BindingSource avtoBindingSource;
        private АвтосалонDataSetTableAdapters.AvtoTableAdapter avtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodprodazhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kodklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kodavtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateprodazhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceprodazhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}