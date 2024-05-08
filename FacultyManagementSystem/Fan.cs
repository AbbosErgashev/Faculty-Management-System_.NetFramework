using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Fan : Form
    {
        public Fan()
        {
            InitializeComponent();
            Populate();
        }

        private void Fan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faculty_management_system_dbDataSet5.OqituvchiTbl' table. You can move, or remove it, as needed.
            this.oqituvchiTblTableAdapter.Fill(this.faculty_management_system_dbDataSet5.OqituvchiTbl);
            // TODO: This line of code loads data into the 'faculty_management_system_dbDataSet4.KafedraTbl' table. You can move, or remove it, as needed.
            this.kafedraTblTableAdapter.Fill(this.faculty_management_system_dbDataSet4.KafedraTbl);
            // TODO: This line of code loads data into the 'faculty_management_system_dbDataSet3.FanlarTbl' table. You can move, or remove it, as needed.
            this.fanlarTblTableAdapter.Fill(this.faculty_management_system_dbDataSet3.FanlarTbl);

        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=faculty_management_system_db;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from FanlarTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                fanDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void SaveFakultet()
        {
            if (ktbl.SelectedIndex == -1 || ftbl.Text == "" || otbl.SelectedIndex == -1)
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FanlarTbl values('" + ktbl.SelectedIndex + "', '" + ftbl.Text + "', '" + otbl.SelectedIndex + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saqlandi");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void UpdateF()
        {
            if (ktbl.SelectedIndex == -1 || ftbl.Text == "" || otbl.SelectedIndex == -1)
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FanlarTbl set KafedraId='" + ktbl.SelectedIndex + "', FanNomi='" + ftbl.Text + "', OqituvchiId='" + otbl.SelectedIndex + "' where FanId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yangilandi");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void DeleteFakultet()
        {
            if (key == 0)
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FanlarTbl where FanId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O'chirildi");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM FanlarTbl ";
            query += "WHERE KafedraId LIKE '%' + @param + '%' ";
            query += "OR FanNomi LIKE '%' + @param + '%' ";
            query += "OR OqituvchiId LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=faculty_management_system_db;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", stbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        fanDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Restore()
        {
            stbl.Text = "";
            Populate();
            Con.Close();
        }

        private void Reset()
        {
            ktbl.Text = "";
            ftbl.Text = "";
            otbl.Text = "";
            key = 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFakultet();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteFakultet();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void fanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ktbl.SelectedItem = fanDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            ftbl.Text = fanDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            otbl.SelectedItem = fanDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (ftbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(fanDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}