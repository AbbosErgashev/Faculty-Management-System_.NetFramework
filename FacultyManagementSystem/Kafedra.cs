using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Kafedra : Form
    {
        public Kafedra()
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
                string query = "select * from KafedraTbl";
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

        private void SaveFakultet()
        {
            if (ktbl.Text == "")
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into KafedraTbl values('" + ktbl.Text + "')";
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
            if (ktbl.Text == "")
            {
                MessageBox.Show("Ma'lumotlar xato kiritilgan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update KafedraTbl set KafedraNomi='" + ktbl.Text + "' where KafedraId=" + key + ";";
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
                    string query = "delete from KafedraTbl where KafedraId=" + key + ";";
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
            string query = "SELECT * FROM KafedraTbl ";
            query += "WHERE KafedraId LIKE '%' + @param + '%' ";
            query += "OR KafedraNomi LIKE '%' + @param + '%' ";
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

        private void Restore()
        {
            stbl.Text = "";
            Populate();
            Con.Close();
        }

        private void Reset()
        {
            ktbl.Text = "";
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

        private void yonalishDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ktbl.Text = yonalishDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (ktbl.Text == "")
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