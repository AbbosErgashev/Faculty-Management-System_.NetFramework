using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Oqituvchi : Form
    {
        public Oqituvchi()
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
                string query = "select * from OqituvchiTbl";
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
            if (itbl.Text == "" || ttbl.Text == "" || ptbl.Text == "" || ktbl.SelectedIndex == -1)
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into OqituvchiTbl values('" + ktbl.SelectedIndex + "', '" + itbl.Text + "', '" + ptbl.Text + "', '" + ttbl.Text + "')";
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
            if (itbl.Text == "" || ttbl.Text == "" || ptbl.Text == "" || ktbl.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update OqituvchiTbl set KafedraId='" + ktbl.SelectedIndex + "', IsmFamiliyasi='" + itbl.Text + "', PassportSeriyasi='" + ptbl.Text + "', TelefonRaqami='" + ttbl.Text + "' where OqituvchiId=" + key + ";";
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
                    string query = "delete from OqituvchiTbl where OqituvchiId=" + key + ";";
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
            string query = "SELECT * FROM OqituvchiTbl ";
            query += "WHERE OqituvchiId LIKE '%' + @param + '%' ";
            query += "OR KafedraId LIKE '%' + @param + '%' ";
            query += "OR IsmFamiliyasi LIKE '%' + @param + '%' ";
            query += "OR PassportSeriyasi LIKE '%' + @param + '%' ";
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
            itbl.Text = "";
            ktbl.Text = "";
            ptbl.Text = "";
            ttbl.Text = "";
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

        private void SearchTbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void FacultyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ktbl.SelectedItem = FacultyDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            itbl.Text = FacultyDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            ptbl.Text = FacultyDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            ttbl.Text = FacultyDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (itbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(FacultyDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Oqituvchi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faculty_management_system_dbDataSet2.KafedraTbl' table. You can move, or remove it, as needed.
            this.kafedraTblTableAdapter.Fill(this.faculty_management_system_dbDataSet2.KafedraTbl);
        }
    }
}