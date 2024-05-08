namespace FacultyManagementSystem
{
    partial class StartPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fakultetpnl = new System.Windows.Forms.Panel();
            this.FacultyDGV = new System.Windows.Forms.DataGridView();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameTbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DekanTbl = new System.Windows.Forms.TextBox();
            this.SearchTbl = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.TelTbl = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ee = new System.Windows.Forms.Label();
            this.fakultetpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // fakultetpnl
            // 
            this.fakultetpnl.Controls.Add(this.FacultyDGV);
            this.fakultetpnl.Controls.Add(this.RestoreBtn);
            this.fakultetpnl.Controls.Add(this.w);
            this.fakultetpnl.Controls.Add(this.label7);
            this.fakultetpnl.Controls.Add(this.NameTbl);
            this.fakultetpnl.Controls.Add(this.label6);
            this.fakultetpnl.Controls.Add(this.DekanTbl);
            this.fakultetpnl.Controls.Add(this.SearchTbl);
            this.fakultetpnl.Controls.Add(this.ResetBtn);
            this.fakultetpnl.Controls.Add(this.SaveBtn);
            this.fakultetpnl.Controls.Add(this.label3);
            this.fakultetpnl.Controls.Add(this.UpdateBtn);
            this.fakultetpnl.Controls.Add(this.TelTbl);
            this.fakultetpnl.Controls.Add(this.DeleteBtn);
            this.fakultetpnl.Controls.Add(this.ee);
            this.fakultetpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fakultetpnl.Location = new System.Drawing.Point(0, 0);
            this.fakultetpnl.Name = "fakultetpnl";
            this.fakultetpnl.Size = new System.Drawing.Size(783, 674);
            this.fakultetpnl.TabIndex = 31;
            // 
            // FacultyDGV
            // 
            this.FacultyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacultyDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FacultyDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.FacultyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FacultyDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.FacultyDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FacultyDGV.GridColor = System.Drawing.Color.Silver;
            this.FacultyDGV.Location = new System.Drawing.Point(0, 370);
            this.FacultyDGV.Name = "FacultyDGV";
            this.FacultyDGV.RowHeadersWidth = 51;
            this.FacultyDGV.RowTemplate.Height = 24;
            this.FacultyDGV.Size = new System.Drawing.Size(783, 304);
            this.FacultyDGV.TabIndex = 45;
            this.FacultyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacultyDGV_CellContentClick_1);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RestoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RestoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.RestoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestoreBtn.Location = new System.Drawing.Point(618, 332);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(161, 32);
            this.RestoreBtn.TabIndex = 44;
            this.RestoreBtn.Text = "Qayta tiklash";
            this.RestoreBtn.UseVisualStyleBackColor = false;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w.Location = new System.Drawing.Point(309, 83);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(125, 20);
            this.w.TabIndex = 35;
            this.w.Text = "Fakultet Dekani";
            //this.w.Click += new System.EventHandler(this.w_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Fakultetlar Ro\'yxati";
            //this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NameTbl
            // 
            this.NameTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTbl.Location = new System.Drawing.Point(66, 106);
            this.NameTbl.Name = "NameTbl";
            this.NameTbl.Size = new System.Drawing.Size(194, 28);
            this.NameTbl.TabIndex = 31;
            //this.NameTbl.TextChanged += new System.EventHandler(this.NameTbl_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(211, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Qidirish";
            //this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DekanTbl
            // 
            this.DekanTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DekanTbl.Location = new System.Drawing.Point(313, 106);
            this.DekanTbl.Name = "DekanTbl";
            this.DekanTbl.Size = new System.Drawing.Size(201, 28);
            this.DekanTbl.TabIndex = 32;
            //this.DekanTbl.TextChanged += new System.EventHandler(this.DekanTbl_TextChanged);
            // 
            // SearchTbl
            // 
            this.SearchTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTbl.Location = new System.Drawing.Point(280, 333);
            this.SearchTbl.Name = "SearchTbl";
            this.SearchTbl.Size = new System.Drawing.Size(330, 28);
            this.SearchTbl.TabIndex = 41;
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
            this.ResetBtn.Location = new System.Drawing.Point(519, 185);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(167, 37);
            this.ResetBtn.TabIndex = 34;
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
            this.SaveBtn.Location = new System.Drawing.Point(113, 185);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 37);
            this.SaveBtn.TabIndex = 40;
            this.SaveBtn.Text = "Saqlash";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fakultet Nomi";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.Location = new System.Drawing.Point(253, 185);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(108, 37);
            this.UpdateBtn.TabIndex = 39;
            this.UpdateBtn.Text = "Yangilash";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // TelTbl
            // 
            this.TelTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelTbl.Location = new System.Drawing.Point(559, 106);
            this.TelTbl.Name = "TelTbl";
            this.TelTbl.Size = new System.Drawing.Size(197, 28);
            this.TelTbl.TabIndex = 33;
            //this.TelTbl.TextChanged += new System.EventHandler(this.TelTbl_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.Location = new System.Drawing.Point(386, 185);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 37);
            this.DeleteBtn.TabIndex = 38;
            this.DeleteBtn.Text = "O\'chirish";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ee
            // 
            this.ee.AutoSize = true;
            this.ee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ee.Location = new System.Drawing.Point(555, 83);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(131, 20);
            this.ee.TabIndex = 37;
            this.ee.Text = "Telefom Raqami";
            //this.ee.Click += new System.EventHandler(this.ee_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 674);
            this.ControlBox = false;
            this.Controls.Add(this.fakultetpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartPage";
            this.Text = "Fakultet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.fakultetpnl.ResumeLayout(false);
            this.fakultetpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fakultetpnl;
        private System.Windows.Forms.DataGridView FacultyDGV;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DekanTbl;
        private System.Windows.Forms.TextBox SearchTbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox TelTbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label ee;
    }
}