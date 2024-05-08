namespace FacultyManagementSystem
{
    partial class Oqituvchi
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
            this.FacultyDGV = new System.Windows.Forms.DataGridView();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptbl = new System.Windows.Forms.TextBox();
            this.SearchTbl = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.otbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ttbl = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ktbl = new System.Windows.Forms.ComboBox();
            this.kafedraTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faculty_management_system_dbDataSet2 = new FacultyManagementSystem.faculty_management_system_dbDataSet2();
            this.kafedraTblTableAdapter = new FacultyManagementSystem.faculty_management_system_dbDataSet2TableAdapters.KafedraTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // FacultyDGV
            // 
            this.FacultyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacultyDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FacultyDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.FacultyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FacultyDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.FacultyDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FacultyDGV.GridColor = System.Drawing.Color.Silver;
            this.FacultyDGV.Location = new System.Drawing.Point(0, 370);
            this.FacultyDGV.Name = "FacultyDGV";
            this.FacultyDGV.RowHeadersWidth = 51;
            this.FacultyDGV.RowTemplate.Height = 24;
            this.FacultyDGV.Size = new System.Drawing.Size(783, 304);
            this.FacultyDGV.TabIndex = 60;
            this.FacultyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacultyDGV_CellContentClick);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RestoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RestoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.RestoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestoreBtn.Location = new System.Drawing.Point(619, 332);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(161, 32);
            this.RestoreBtn.TabIndex = 59;
            this.RestoreBtn.Text = "Qayta tiklash";
            this.RestoreBtn.UseVisualStyleBackColor = false;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w.Location = new System.Drawing.Point(392, 119);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(141, 20);
            this.w.TabIndex = 50;
            this.w.Text = "Passport Seriyasi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 58;
            this.label7.Text = "O\'qituvchilar Ro\'yxati";
            // 
            // itbl
            // 
            this.itbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itbl.Location = new System.Drawing.Point(187, 114);
            this.itbl.Name = "itbl";
            this.itbl.Size = new System.Drawing.Size(194, 28);
            this.itbl.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(212, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Qidirish";
            // 
            // ptbl
            // 
            this.ptbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptbl.Location = new System.Drawing.Point(546, 114);
            this.ptbl.Name = "ptbl";
            this.ptbl.Size = new System.Drawing.Size(201, 28);
            this.ptbl.TabIndex = 47;
            // 
            // SearchTbl
            // 
            this.SearchTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTbl.Location = new System.Drawing.Point(281, 337);
            this.SearchTbl.Name = "SearchTbl";
            this.SearchTbl.Size = new System.Drawing.Size(330, 28);
            this.SearchTbl.TabIndex = 56;
            this.SearchTbl.TextChanged += new System.EventHandler(this.SearchTbl_TextChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.Location = new System.Drawing.Point(516, 248);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(167, 37);
            this.ResetBtn.TabIndex = 49;
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
            this.SaveBtn.Location = new System.Drawing.Point(110, 248);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 37);
            this.SaveBtn.TabIndex = 55;
            this.SaveBtn.Text = "Saqlash";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // otbl
            // 
            this.otbl.AutoSize = true;
            this.otbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otbl.Location = new System.Drawing.Point(60, 118);
            this.otbl.Name = "otbl";
            this.otbl.Size = new System.Drawing.Size(120, 20);
            this.otbl.TabIndex = 51;
            this.otbl.Text = "Ismi Familiyasi";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.Location = new System.Drawing.Point(250, 248);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(108, 37);
            this.UpdateBtn.TabIndex = 54;
            this.UpdateBtn.Text = "Yangilash";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ttbl
            // 
            this.ttbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ttbl.Location = new System.Drawing.Point(191, 166);
            this.ttbl.Name = "ttbl";
            this.ttbl.Size = new System.Drawing.Size(190, 28);
            this.ttbl.TabIndex = 48;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.Location = new System.Drawing.Point(383, 248);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 37);
            this.DeleteBtn.TabIndex = 53;
            this.DeleteBtn.Text = "O\'chirish";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ee
            // 
            this.ee.AutoSize = true;
            this.ee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ee.Location = new System.Drawing.Point(50, 171);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(131, 20);
            this.ee.TabIndex = 52;
            this.ee.Text = "Telefom Raqami";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(422, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Kafedra Nomi";
            // 
            // ktbl
            // 
            this.ktbl.DataSource = this.kafedraTblBindingSource;
            this.ktbl.DisplayMember = "KafedraNomi";
            this.ktbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ktbl.FormattingEnabled = true;
            this.ktbl.Location = new System.Drawing.Point(546, 167);
            this.ktbl.Name = "ktbl";
            this.ktbl.Size = new System.Drawing.Size(201, 30);
            this.ktbl.TabIndex = 63;
            this.ktbl.ValueMember = "KafedraId";
            // 
            // kafedraTblBindingSource
            // 
            this.kafedraTblBindingSource.DataMember = "KafedraTbl";
            this.kafedraTblBindingSource.DataSource = this.faculty_management_system_dbDataSet2;
            // 
            // faculty_management_system_dbDataSet2
            // 
            this.faculty_management_system_dbDataSet2.DataSetName = "faculty_management_system_dbDataSet2";
            this.faculty_management_system_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kafedraTblTableAdapter
            // 
            this.kafedraTblTableAdapter.ClearBeforeFill = true;
            // 
            // Oqituvchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 674);
            this.Controls.Add(this.ktbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyDGV);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.w);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ptbl);
            this.Controls.Add(this.SearchTbl);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.otbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ttbl);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Oqituvchi";
            this.Text = "Oqituvchi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Oqituvchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacultyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_management_system_dbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FacultyDGV;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ptbl;
        private System.Windows.Forms.TextBox SearchTbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label otbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox ttbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label ee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ktbl;
        private faculty_management_system_dbDataSet2 faculty_management_system_dbDataSet2;
        private System.Windows.Forms.BindingSource kafedraTblBindingSource;
        private faculty_management_system_dbDataSet2TableAdapters.KafedraTblTableAdapter kafedraTblTableAdapter;
    }
}