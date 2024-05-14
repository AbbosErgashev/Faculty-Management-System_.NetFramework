using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class StartPage : Form
    {
        public StartPage()
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
                string query = "select * from FakultetTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                FacultyDGV.DataSource = ds.Tables[0];
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
            if (NameTbl.Text == "" || TelTbl.Text == "" || DekanTbl.Text == "")
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FakultetTbl values('" + NameTbl.Text + "', '" + DekanTbl.Text + "', '" + TelTbl.Text + "')";
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
            if (NameTbl.Text == "" || TelTbl.Text == "" || DekanTbl.Text == "")
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FakultetTbl set FakultetNomi='" + NameTbl.Text + "', Dekan='" + DekanTbl.Text + "', TelefonRaqami='" + TelTbl.Text + "' where FakultetId=" + key + ";";
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
                    string query = "delete from FakultetTbl where FakultetId=" + key + ";";
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
            string query = "SELECT * FROM FakultetTbl ";
            query += "WHERE FakultetId LIKE '%' + @param + '%' ";
            query += "OR FakultetNomi LIKE '%' + @param + '%' ";
            query += "OR Dekan LIKE '%' + @param + '%' ";
            query += "OR TelefonRaqami LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=faculty_management_system_db;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", SearchTbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        FacultyDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Restore()
        {
            SearchTbl.Text = "";
            Populate();
            Con.Close();
        }

        private void Reset()
        {
            NameTbl.Text = "";
            DekanTbl.Text = "";
            TelTbl.Text = "";
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

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void SearchTbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void FacultyDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NameTbl.Text = FacultyDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            DekanTbl.Text = FacultyDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            TelTbl.Text = FacultyDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (NameTbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(FacultyDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}