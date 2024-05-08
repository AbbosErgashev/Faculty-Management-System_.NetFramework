using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Yonalish : Form
    {
        public Yonalish()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=faculty_management_system_db;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from YonalishTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                yonalishDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void Save()
        {
            if (ytbl.Text == "" || fcb.SelectedIndex == -1)
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into YonalishTbl values('" + fcb.SelectedIndex + "', '" + ytbl.Text + "')";
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

        private void Restore()
        {
            stbl.Text = "";
            Populate();
            Con.Close();
        }

        private void Reset()
        {
            ytbl.Text = "";
            fcb.SelectedIndex = -1;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Yonalish_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faculty_management_system_dbDataSet1.FakultetTbl' table. You can move, or remove it, as needed.
            this.fakultetTblTableAdapter1.Fill(this.faculty_management_system_dbDataSet1.FakultetTbl);
            // TODO: This line of code loads data into the 'faculty_management_system_dbDataSet.FakultetTbl' table. You can move, or remove it, as needed.
            this.fakultetTblTableAdapter.Fill(this.faculty_management_system_dbDataSet.FakultetTbl);

        }

        private void UpdateYonalish()
        {
            if (ytbl.Text == "" || fcb.SelectedIndex == -1)
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update YonalishTbl set FakultetId='" + fcb.SelectedIndex + "', YonalishNomi='" + ytbl.Text + "' where YonalishId=" + key + ";";
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

        private void DeleteY()
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
                    string query = "delete from YonalishTbl where YonalishId=" + key + ";";
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
            string query = "SELECT * FROM YonalishTbl ";
            query += "WHERE YonalishId LIKE '%' + @param + '%' ";
            query += "OR FakultetId LIKE '%' + @param + '%' ";
            query += "OR YonalishNomi LIKE '%' + @param + '%' ";
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
                        yonalishDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click_1(object sender, EventArgs e)
        {
            Restore();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateYonalish();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteY();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void yonalishDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fcb.SelectedItem = yonalishDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            ytbl.Text = yonalishDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (ytbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(yonalishDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}