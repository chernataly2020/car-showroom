namespace Автосалон
{
    partial class Производители_автомобилей
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Производители_автомобилей));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextRecord = new System.Windows.Forms.Button();
            this.PreviewRecord = new System.Windows.Forms.Button();
            this.EndRecord = new System.Windows.Forms.Button();
            this.FirstRecord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.AddRecord = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(855, 483);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(855, 280);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NextRecord);
            this.groupBox1.Controls.Add(this.PreviewRecord);
            this.groupBox1.Controls.Add(this.EndRecord);
            this.groupBox1.Controls.Add(this.FirstRecord);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
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
            this.NextRecord.TabIndex = 7;
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
            this.PreviewRecord.TabIndex = 6;
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
            this.EndRecord.TabIndex = 5;
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
            this.FirstRecord.TabIndex = 4;
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
            this.groupBox2.Location = new System.Drawing.Point(406, 92);
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
            this.EditRecord.TabIndex = 10;
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
            this.DeleteRecord.TabIndex = 9;
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
            this.AddRecord.TabIndex = 8;
            this.AddRecord.Text = "Добавить запись";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(565, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Мощность двигателя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес производителя";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя производителя";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Код производителя";
            // 
            // Производители_автомобилей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 483);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Производители_автомобилей";
            this.Text = "Производители автомобилей";
            this.Load += new System.EventHandler(this.Производители_автомобилей_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextRecord;
        private System.Windows.Forms.Button PreviewRecord;
        private System.Windows.Forms.Button EndRecord;
        private System.Windows.Forms.Button FirstRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}