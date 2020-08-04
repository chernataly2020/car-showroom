namespace Автосалон
{
    partial class Автомобили
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Автомобили));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodavtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameavtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.modelsofavtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автосалонDataSet = new Автосалон.АвтосалонDataSet();
            this.datevipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Summa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteFromBag = new System.Windows.Forms.Button();
            this.AddToBag = new System.Windows.Forms.Button();
            this.kol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextRecord = new System.Windows.Forms.Button();
            this.PreviewRecord = new System.Windows.Forms.Button();
            this.EndRecord = new System.Windows.Forms.Button();
            this.FirstRecord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.AddRecord = new System.Windows.Forms.Button();
            this.zaprosPrice1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.priceToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.priceToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.zaprosPrice1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zaprosDate1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.date_vipToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.date_vipToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.zaprosDate1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.allRecordsToolStrip = new System.Windows.Forms.ToolStrip();
            this.allRecordsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtoTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.AvtoTableAdapter();
            this.models_of_avtoTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.Models_of_avtoTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsofavtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автосалонDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.zaprosPrice1ToolStrip.SuspendLayout();
            this.zaprosDate1ToolStrip.SuspendLayout();
            this.allRecordsToolStrip.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 486);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodavtoDataGridViewTextBoxColumn,
            this.nameavtoDataGridViewTextBoxColumn,
            this.kodmodelDataGridViewTextBoxColumn,
            this.datevipDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avtoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // kodavtoDataGridViewTextBoxColumn
            // 
            this.kodavtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodavtoDataGridViewTextBoxColumn.DataPropertyName = "Kod_avto";
            this.kodavtoDataGridViewTextBoxColumn.HeaderText = "Код автомобиля";
            this.kodavtoDataGridViewTextBoxColumn.Name = "kodavtoDataGridViewTextBoxColumn";
            // 
            // nameavtoDataGridViewTextBoxColumn
            // 
            this.nameavtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameavtoDataGridViewTextBoxColumn.DataPropertyName = "Name_avto";
            this.nameavtoDataGridViewTextBoxColumn.HeaderText = "Название автомобиля";
            this.nameavtoDataGridViewTextBoxColumn.Name = "nameavtoDataGridViewTextBoxColumn";
            // 
            // kodmodelDataGridViewTextBoxColumn
            // 
            this.kodmodelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodmodelDataGridViewTextBoxColumn.DataPropertyName = "Kod_model";
            this.kodmodelDataGridViewTextBoxColumn.DataSource = this.modelsofavtoBindingSource;
            this.kodmodelDataGridViewTextBoxColumn.DisplayMember = "Model";
            this.kodmodelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.kodmodelDataGridViewTextBoxColumn.Name = "kodmodelDataGridViewTextBoxColumn";
            this.kodmodelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kodmodelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kodmodelDataGridViewTextBoxColumn.ValueMember = "Kod_model";
            // 
            // modelsofavtoBindingSource
            // 
            this.modelsofavtoBindingSource.DataMember = "Models_of_avto";
            this.modelsofavtoBindingSource.DataSource = this.автосалонDataSet;
            // 
            // автосалонDataSet
            // 
            this.автосалонDataSet.DataSetName = "АвтосалонDataSet";
            this.автосалонDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datevipDataGridViewTextBoxColumn
            // 
            this.datevipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datevipDataGridViewTextBoxColumn.DataPropertyName = "Date_vip";
            this.datevipDataGridViewTextBoxColumn.HeaderText = "Дата выпуска";
            this.datevipDataGridViewTextBoxColumn.Name = "datevipDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество (в наличие)";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "Avto";
            this.avtoBindingSource.DataSource = this.автосалонDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Summa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DeleteFromBag);
            this.groupBox3.Controls.Add(this.AddToBag);
            this.groupBox3.Controls.Add(this.kol);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(692, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 110);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операции с Корзиной";
            // 
            // Summa
            // 
            this.Summa.ForeColor = System.Drawing.Color.Red;
            this.Summa.Location = new System.Drawing.Point(189, 64);
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            this.Summa.Size = new System.Drawing.Size(113, 20);
            this.Summa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(142, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма";
            // 
            // DeleteFromBag
            // 
            this.DeleteFromBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFromBag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteFromBag.Location = new System.Drawing.Point(10, 81);
            this.DeleteFromBag.Name = "DeleteFromBag";
            this.DeleteFromBag.Size = new System.Drawing.Size(126, 23);
            this.DeleteFromBag.TabIndex = 3;
            this.DeleteFromBag.Text = "Удалить из Корзины";
            this.DeleteFromBag.UseVisualStyleBackColor = true;
            this.DeleteFromBag.Click += new System.EventHandler(this.DeleteFromBag_Click);
            // 
            // AddToBag
            // 
            this.AddToBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToBag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddToBag.Location = new System.Drawing.Point(9, 57);
            this.AddToBag.Name = "AddToBag";
            this.AddToBag.Size = new System.Drawing.Size(127, 23);
            this.AddToBag.TabIndex = 2;
            this.AddToBag.Tag = "";
            this.AddToBag.Text = "Поместить в Корзину";
            this.AddToBag.UseVisualStyleBackColor = true;
            this.AddToBag.Click += new System.EventHandler(this.AddToBag_Click);
            // 
            // kol
            // 
            this.kol.Location = new System.Drawing.Point(188, 27);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(114, 20);
            this.kol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество выбираемого товара";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 121);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NextRecord);
            this.groupBox1.Controls.Add(this.PreviewRecord);
            this.groupBox1.Controls.Add(this.EndRecord);
            this.groupBox1.Controls.Add(this.FirstRecord);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перемещение по записям";
            // 
            // NextRecord
            // 
            this.NextRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NextRecord.Location = new System.Drawing.Point(202, 81);
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
            this.PreviewRecord.Location = new System.Drawing.Point(7, 81);
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
            this.EndRecord.Location = new System.Drawing.Point(202, 51);
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
            this.FirstRecord.Location = new System.Drawing.Point(6, 51);
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
            this.groupBox2.Location = new System.Drawing.Point(406, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции с записями";
            // 
            // EditRecord
            // 
            this.EditRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditRecord.Location = new System.Drawing.Point(6, 81);
            this.EditRecord.Name = "EditRecord";
            this.EditRecord.Size = new System.Drawing.Size(265, 23);
            this.EditRecord.TabIndex = 2;
            this.EditRecord.Text = "Редактировать запись";
            this.EditRecord.UseVisualStyleBackColor = true;
            this.EditRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteRecord.Location = new System.Drawing.Point(144, 52);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(127, 23);
            this.DeleteRecord.TabIndex = 1;
            this.DeleteRecord.Text = "Удалить запись";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // AddRecord
            // 
            this.AddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddRecord.Location = new System.Drawing.Point(6, 52);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(132, 23);
            this.AddRecord.TabIndex = 0;
            this.AddRecord.Text = "Добавить запись";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // zaprosPrice1ToolStrip
            // 
            this.zaprosPrice1ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zaprosPrice1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceToolStripLabel,
            this.priceToolStripTextBox,
            this.zaprosPrice1ToolStripButton});
            this.zaprosPrice1ToolStrip.Location = new System.Drawing.Point(0, 461);
            this.zaprosPrice1ToolStrip.Name = "zaprosPrice1ToolStrip";
            this.zaprosPrice1ToolStrip.Size = new System.Drawing.Size(1012, 25);
            this.zaprosPrice1ToolStrip.TabIndex = 3;
            this.zaprosPrice1ToolStrip.Text = "zaprosPrice1ToolStrip";
            // 
            // priceToolStripLabel
            // 
            this.priceToolStripLabel.Name = "priceToolStripLabel";
            this.priceToolStripLabel.Size = new System.Drawing.Size(190, 22);
            this.priceToolStripLabel.Text = "Укажите верхнюю границу цены:";
            // 
            // priceToolStripTextBox
            // 
            this.priceToolStripTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceToolStripTextBox.Name = "priceToolStripTextBox";
            this.priceToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // zaprosPrice1ToolStripButton
            // 
            this.zaprosPrice1ToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zaprosPrice1ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zaprosPrice1ToolStripButton.Image")));
            this.zaprosPrice1ToolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.zaprosPrice1ToolStripButton.Name = "zaprosPrice1ToolStripButton";
            this.zaprosPrice1ToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.zaprosPrice1ToolStripButton.Text = "Фильтр";
            this.zaprosPrice1ToolStripButton.ToolTipText = "Фильтрация данных по цене";
            this.zaprosPrice1ToolStripButton.Click += new System.EventHandler(this.zaprosPrice1ToolStripButton_Click);
            // 
            // zaprosDate1ToolStrip
            // 
            this.zaprosDate1ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zaprosDate1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date_vipToolStripLabel,
            this.date_vipToolStripTextBox,
            this.zaprosDate1ToolStripButton});
            this.zaprosDate1ToolStrip.Location = new System.Drawing.Point(0, 436);
            this.zaprosDate1ToolStrip.Name = "zaprosDate1ToolStrip";
            this.zaprosDate1ToolStrip.Size = new System.Drawing.Size(1012, 25);
            this.zaprosDate1ToolStrip.TabIndex = 4;
            this.zaprosDate1ToolStrip.Text = "zaprosDate1ToolStrip";
            // 
            // date_vipToolStripLabel
            // 
            this.date_vipToolStripLabel.Name = "date_vipToolStripLabel";
            this.date_vipToolStripLabel.Size = new System.Drawing.Size(188, 22);
            this.date_vipToolStripLabel.Text = "Укажите дату выпуска:                   ";
            // 
            // date_vipToolStripTextBox
            // 
            this.date_vipToolStripTextBox.Name = "date_vipToolStripTextBox";
            this.date_vipToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // zaprosDate1ToolStripButton
            // 
            this.zaprosDate1ToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zaprosDate1ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zaprosDate1ToolStripButton.Image")));
            this.zaprosDate1ToolStripButton.Name = "zaprosDate1ToolStripButton";
            this.zaprosDate1ToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.zaprosDate1ToolStripButton.Text = "Фильтр";
            this.zaprosDate1ToolStripButton.Click += new System.EventHandler(this.zaprosDate1ToolStripButton_Click);
            // 
            // allRecordsToolStrip
            // 
            this.allRecordsToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allRecordsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRecordsToolStripButton});
            this.allRecordsToolStrip.Location = new System.Drawing.Point(0, 411);
            this.allRecordsToolStrip.Name = "allRecordsToolStrip";
            this.allRecordsToolStrip.Size = new System.Drawing.Size(1012, 25);
            this.allRecordsToolStrip.TabIndex = 5;
            this.allRecordsToolStrip.Text = "allRecordsToolStrip";
            // 
            // allRecordsToolStripButton
            // 
            this.allRecordsToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.allRecordsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("allRecordsToolStripButton.Image")));
            this.allRecordsToolStripButton.Name = "allRecordsToolStripButton";
            this.allRecordsToolStripButton.Size = new System.Drawing.Size(153, 22);
            this.allRecordsToolStripButton.Text = "Отобразить все записи";
            this.allRecordsToolStripButton.Click += new System.EventHandler(this.allRecordsToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kod_avto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код автомобиля";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_vip";
            dataGridViewCellStyle5.Format = "d";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата выпуска";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "d";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество (в наличие) в салоне";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество (в наличие) в салоне";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // models_of_avtoTableAdapter
            // 
            this.models_of_avtoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1003, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Корзина";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(997, 96);
            this.dataGridView2.TabIndex = 1;
            // 
            // Автомобили
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 486);
            this.Controls.Add(this.allRecordsToolStrip);
            this.Controls.Add(this.zaprosDate1ToolStrip);
            this.Controls.Add(this.zaprosPrice1ToolStrip);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Автомобили";
            this.Text = "Автомобили";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Автомобили_FormClosed);
            this.Load += new System.EventHandler(this.Автомобили_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsofavtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автосалонDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.zaprosPrice1ToolStrip.ResumeLayout(false);
            this.zaprosPrice1ToolStrip.PerformLayout();
            this.zaprosDate1ToolStrip.ResumeLayout(false);
            this.zaprosDate1ToolStrip.PerformLayout();
            this.allRecordsToolStrip.ResumeLayout(false);
            this.allRecordsToolStrip.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private АвтосалонDataSet автосалонDataSet;
        private АвтосалонDataSetTableAdapters.AvtoTableAdapter avtoTableAdapter;
        private System.Windows.Forms.BindingSource modelsofavtoBindingSource;
        private АвтосалонDataSetTableAdapters.Models_of_avtoTableAdapter models_of_avtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip zaprosPrice1ToolStrip;
        private System.Windows.Forms.ToolStripLabel priceToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox priceToolStripTextBox;
        private System.Windows.Forms.ToolStripButton zaprosPrice1ToolStripButton;
        private System.Windows.Forms.ToolStrip zaprosDate1ToolStrip;
        private System.Windows.Forms.ToolStripLabel date_vipToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox date_vipToolStripTextBox;
        private System.Windows.Forms.ToolStripButton zaprosDate1ToolStripButton;
        private System.Windows.Forms.ToolStrip allRecordsToolStrip;
        private System.Windows.Forms.ToolStripButton allRecordsToolStripButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteFromBag;
        private System.Windows.Forms.Button AddToBag;
        private System.Windows.Forms.TextBox kol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Summa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource avtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodavtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameavtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kodmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datevipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}