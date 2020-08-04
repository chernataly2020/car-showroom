namespace Автосалон
{
    partial class Модели_автомобилей
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Модели_автомобилей));
            this.автосалонDataSet = new Автосалон.АвтосалонDataSet();
            this.modelsofavtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.models_of_avtoTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.Models_of_avtoTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.AddRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextRecord = new System.Windows.Forms.Button();
            this.PreviewRecord = new System.Windows.Forms.Button();
            this.EndRecord = new System.Windows.Forms.Button();
            this.FirstRecord = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proizvAvtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizv_AvtoTableAdapter = new Автосалон.АвтосалонDataSetTableAdapters.Proizv_AvtoTableAdapter();
            this.kodmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodproizvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obemdriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerdriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.автосалонDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsofavtoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvAvtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // автосалонDataSet
            // 
            this.автосалонDataSet.DataSetName = "АвтосалонDataSet";
            this.автосалонDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsofavtoBindingSource
            // 
            this.modelsofavtoBindingSource.DataMember = "Models_of_avto";
            this.modelsofavtoBindingSource.DataSource = this.автосалонDataSet;
            // 
            // models_of_avtoTableAdapter
            // 
            this.models_of_avtoTableAdapter.ClearBeforeFill = true;
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
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodmodelDataGridViewTextBoxColumn,
            this.kodproizvDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.obemdriveDataGridViewTextBoxColumn,
            this.powerdriveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelsofavtoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // proizvAvtoBindingSource
            // 
            this.proizvAvtoBindingSource.DataMember = "Proizv_Avto";
            this.proizvAvtoBindingSource.DataSource = this.автосалонDataSet;
            // 
            // proizv_AvtoTableAdapter
            // 
            this.proizv_AvtoTableAdapter.ClearBeforeFill = true;
            // 
            // kodmodelDataGridViewTextBoxColumn
            // 
            this.kodmodelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodmodelDataGridViewTextBoxColumn.DataPropertyName = "Kod_model";
            this.kodmodelDataGridViewTextBoxColumn.HeaderText = "Код модели";
            this.kodmodelDataGridViewTextBoxColumn.Name = "kodmodelDataGridViewTextBoxColumn";
            // 
            // kodproizvDataGridViewTextBoxColumn
            // 
            this.kodproizvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodproizvDataGridViewTextBoxColumn.DataPropertyName = "Kod_proizv";
            this.kodproizvDataGridViewTextBoxColumn.DataSource = this.proizvAvtoBindingSource;
            this.kodproizvDataGridViewTextBoxColumn.DisplayMember = "Name_proizv";
            this.kodproizvDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.kodproizvDataGridViewTextBoxColumn.Name = "kodproizvDataGridViewTextBoxColumn";
            this.kodproizvDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kodproizvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kodproizvDataGridViewTextBoxColumn.ValueMember = "Kod_proizv";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Название модели";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // obemdriveDataGridViewTextBoxColumn
            // 
            this.obemdriveDataGridViewTextBoxColumn.DataPropertyName = "Obem_drive";
            this.obemdriveDataGridViewTextBoxColumn.HeaderText = "Объем двигателя";
            this.obemdriveDataGridViewTextBoxColumn.Name = "obemdriveDataGridViewTextBoxColumn";
            // 
            // powerdriveDataGridViewTextBoxColumn
            // 
            this.powerdriveDataGridViewTextBoxColumn.DataPropertyName = "Power_drive";
            this.powerdriveDataGridViewTextBoxColumn.HeaderText = "Мощность двигателя";
            this.powerdriveDataGridViewTextBoxColumn.Name = "powerdriveDataGridViewTextBoxColumn";
            // 
            // Модели_автомобилей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 483);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Модели_автомобилей";
            this.Text = "Модели автомобилей";
            this.Load += new System.EventHandler(this.Модели_автомобилей_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автосалонDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsofavtoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvAvtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private АвтосалонDataSet автосалонDataSet;
        private System.Windows.Forms.BindingSource modelsofavtoBindingSource;
        private АвтосалонDataSetTableAdapters.Models_of_avtoTableAdapter models_of_avtoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextRecord;
        private System.Windows.Forms.Button PreviewRecord;
        private System.Windows.Forms.Button EndRecord;
        private System.Windows.Forms.Button FirstRecord;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource proizvAvtoBindingSource;
        private АвтосалонDataSetTableAdapters.Proizv_AvtoTableAdapter proizv_AvtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kodproizvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obemdriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerdriveDataGridViewTextBoxColumn;
    }
}