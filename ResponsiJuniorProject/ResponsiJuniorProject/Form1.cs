using System.Data;
using Npgsql;

namespace ResponsiJuniorProject
{
    public partial class Form1 : Form
    {

        string connString = "Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=ResponsiJuniorProject";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow row;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                sql = "select  karyawan.id_dep, karyawan.nama, karyawan.id_karyawan, departemen.nama_dep from karyawan, departemen WHERE karyawan.id_dep = departemen.id_dep";


                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void LoadDataDept()
        {

            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                sql = "select * load_departemen()";


                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());


                MessageBox.Show("Load Data Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error showing departmen");
            }
            finally
            {
                conn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataDept();


        }



        private void InsertData()
        {
            string nama = textBoxNama.Text;
            string dep = comboBoxDep.Text;


            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM add_karyawan(@in_id_karyawan, @in_nama, @in_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_nama_dep", dep);
                int statusCode = (int)cmd.ExecuteScalar();
                if (statusCode == 201)
                {
                    MessageBox.Show("[201] Created");
                    LoadData();
                    return;
                }
                if (statusCode == 409)
                {
                    throw new Exception("[409] User already exist");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            finally { conn.Close(); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void EditData()
        {
            if (row == null)
            {
                MessageBox.Show("Pilih karyawan untuk diedit", "Ingfo");
                return;
            }
            try
            {
                string nama = textBoxNama.Text;
                string dep = comboBoxDep.Text;

                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM edit_karyawan(@in_id_karyawan, @in_nama, @in_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", row.Cells["id_karyawan"].Value);
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_nama_dep", dep);

                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 200)
                {
                    MessageBox.Show("[200] Edit success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] karyawan tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }


        private void dgvDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show("Pilih karyawan untuk dihapus");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM delete_karyawan(@in_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", row.Cells["id_karyawan"].Value);

                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 204)
                {
                    MessageBox.Show("[204] Delete success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] Karyawan tidak ditemukan");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }

}