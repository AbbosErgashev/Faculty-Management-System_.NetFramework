namespace FacultyManagementSystem
{
    partial class Fan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stbl = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.fanDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.restorebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ftbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.otbl = new System.Windows.Forms.ComboBox();
            this.oqituvchiTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faculty_management_system_dbDataSet5 = new FacultyManagementSystem.faculty_management_system_dbDataSet5();
            this.ktbl = new System.Windows.Forms.ComboBox();
            this.kafedraTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faculty_management_system_dbDataSet4 = new FacultyManagementSystem.faculty_management_system_dbDataSet4();
            this.faculty_management_system_dbDataSet3 = new FacultyManagementSystem.faculty_management_system_dbDataSet3();
            this.fanlarTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fanlarTblTableAdapter = new FacultyManagementSystem.faculty_management_system_dbDataSet3TableAdapters.FanlarTblTableAdapter();
            this.kafedraTblTableAdapter = new FacultyManagementSystem.faculty_management_system_dbDataSet4TableAdapters.KafedraTblTableAdapter();
            this.oqituvchiTblTableAdapter = new FacultyManagementSystem.faculty_management_system_dbDataSet5TableAdapters.OqituvchiTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fanDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oqituvchiTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fanlarTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Fanlar Ro\'yxati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(220, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Qidirish";
            // 
            // stbl
            // 
            this.stbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stbl.Location = new System.Drawing.Point(289, 321);
            this.stbl.Name = "stbl";
            this.stbl.Size = new System.Drawing.Size(330, 28);
            this.stbl.TabIndex = 72;
            this.stbl.TextChanged += new System.EventHandler(this.stbl_TextChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.Location = new System.Drawing.Point(490, 223);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(167, 37);
            this.ResetBtn.TabIndex = 68;
            this.ResetBtn.Text = "Qayta o\'rnatish";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(84, 223);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 37);
            this.SaveBtn.TabIndex = 71;
            this.SaveBtn.Text = "Saqlash";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.Location = new System.Drawing.Point(224, 223);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(108, 37);
            this.UpdateBtn.TabIndex = 70;
            this.UpdateBtn.Text = "Yangilash";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.Location = new System.Drawing.Point(357, 223);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 37);
            this.DeleteBtn.TabIndex = 69;
            this.DeleteBtn.Text = "O\'chirish";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // fanDGV
            // 
            this.fanDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fanDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.fanDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.fanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fanDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.fanDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fanDGV.GridColor = System.Drawing.Color.Silver;
            this.fanDGV.Location = new System.Drawing.Point(0, 355);
            this.fanDGV.Name = "fanDGV";
            this.fanDGV.RowHeadersWidth = 51;
            this.fanDGV.RowTemplate.Height = 24;
            this.fanDGV.Size = new System.Drawing.Size(783, 319);
            this.fanDGV.TabIndex = 67;
            this.fanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fanDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(163, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Kafedra Nomi";
            // 
            // restorebtn
            // 
            this.restorebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.restorebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restorebtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.restorebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.restorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restorebtn.Location = new System.Drawing.Point(622, 317);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(161, 32);
            this.restorebtn.TabIndex = 75;
            this.restorebtn.Text = "Qayta tiklash";
            this.restorebtn.UseVisualStyleBackColor = false;
            this.restorebtn.Click += new System.EventHandler(this.restorebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Fan Nomi";
            // 
            // ftbl
            // 
            this.ftbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ftbl.Location = new System.Drawing.Point(280, 92);
            this.ftbl.Name = "ftbl";
            this.ftbl.Size = new System.Drawing.Size(330, 28);
            this.ftbl.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(150, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "O\'qituvchi Ismi ";
            // 
            // otbl
            // 
            this.otbl.DataSource = this.oqituvchiTblBindingSource;
            this.otbl.DisplayMember = "IsmFamiliyasi";
            this.otbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otbl.FormattingEnabled = true;
            this.otbl.Location = new System.Drawing.Point(280, 144);
            this.otbl.Name = "otbl";
            this.otbl.Size = new System.Drawing.Size(330, 30);
            this.otbl.TabIndex = 80;
            this.otbl.ValueMember = "OqituvchiId";
            // 
            // oqituvchiTblBindingSource
            // 
            this.oqituvchiTblBindingSource.DataMember = "OqituvchiTbl";
            this.oqituvchiTblBindingSource.DataSource = this.faculty_management_system_dbDataSet5;
            // 
            // faculty_management_system_dbDataSet5
            // 
            this.faculty_management_system_dbDataSet5.DataSetName = "faculty_management_system_dbDataSet5";
            this.faculty_management_system_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ktbl
            // 
            this.ktbl.DataSource = this.kafedraTblBindingSource;
            this.ktbl.DisplayMember = "KafedraNomi";
            this.ktbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ktbl.FormattingEnabled = true;
            this.ktbl.Location = new System.Drawing.Point(280, 44);
            this.ktbl.Name = "ktbl";
            this.ktbl.Size = new System.Drawing.Size(330, 30);
            this.ktbl.TabIndex = 81;
            this.ktbl.ValueMember = "KafedraId";
            // 
            // kafedraTblBindingSource
            // 
            this.kafedraTblBindingSource.DataMember = "KafedraTbl";
            this.kafedraTblBindingSource.DataSource = this.faculty_management_system_dbDataSet4;
            // 
            // faculty_management_system_dbDataSet4
            // 
            this.faculty_management_system_dbDataSet4.DataSetName = "faculty_management_system_dbDataSet4";
            this.faculty_management_system_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faculty_management_system_dbDataSet3
            // 
            this.faculty_management_system_dbDataSet3.DataSetName = "faculty_management_system_dbDataSet3";
            this.faculty_management_system_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fanlarTblBindingSource
            // 
            this.fanlarTblBindingSource.DataMember = "FanlarTbl";
            this.fanlarTblBindingSource.DataSource = this.faculty_management_system_dbDataSet3;
            // 
            // fanlarTblTableAdapter
            // 
            this.fanlarTblTableAdapter.ClearBeforeFill = true;
            // 
            // kafedraTblTableAdapter
            // 
            this.kafedraTblTableAdapter.ClearBeforeFill = true;
            // 
            // oqituvchiTblTableAdapter
            // 
            this.oqituvchiTblTableAdapter.ClearBeforeFill = true;
            // 
            // Fan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 674);
            this.Controls.Add(this.ktbl);
            this.Controls.Add(this.otbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ftbl);
            this.Controls.Add(this.restorebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stbl);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.fanDGV);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fan";
            this.Text = "Fan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fanDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oqituvchiTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fanlarTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView fanDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button restorebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ftbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox otbl;
        private System.Windows.Forms.ComboBox ktbl;
        private faculty_management_system_dbDataSet3 faculty_management_system_dbDataSet3;
        private System.Windows.Forms.BindingSource fanlarTblBindingSource;
        private faculty_management_system_dbDataSet3TableAdapters.FanlarTblTableAdapter fanlarTblTableAdapter;
        private faculty_management_system_dbDataSet4 faculty_management_system_dbDataSet4;
        private System.Windows.Forms.BindingSource kafedraTblBindingSource;
        private faculty_management_system_dbDataSet4TableAdapters.KafedraTblTableAdapter kafedraTblTableAdapter;
        private faculty_management_system_dbDataSet5 faculty_management_system_dbDataSet5;
        private System.Windows.Forms.BindingSource oqituvchiTblBindingSource;
        private faculty_management_system_dbDataSet5TableAdapters.OqituvchiTblTableAdapter oqituvchiTblTableAdapter;
    }
}