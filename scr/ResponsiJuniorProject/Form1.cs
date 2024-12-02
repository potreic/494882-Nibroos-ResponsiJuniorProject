using System.Data;
using Npgsql;

namespace ResponsiJuniorProject
{
    public partial class ResponsiJuniorProject : Form
    {

        string connString = "Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=ResponsiJuniorProject";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow row;

        public ResponsiJuniorProject()
        {
            InitializeComponent();
            LoadDataKaryawan();
            PopulateDepartmen();
            PopulateJabatan();
        }


        //FUNCTION HANDLER ======================================================================================================================================
        private void LoadDataKaryawan()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                sql = "SELECT * FROM load_all_karyawan_info();"; 
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

        private void PopulateDepartmen()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();

                string sql = "SELECT nama_dep FROM Departemen";

                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                comboBoxDep.Items.Clear();

                while (reader.Read())
                {
                    string departmentName = reader.GetString(0);  
                    comboBoxDep.Items.Add(departmentName); 
                }
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

        private void PopulateJabatan()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();

                string sql = "SELECT nama_jabatan FROM Jabatan";

      
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

       
                comboBoxJabatan.Items.Clear();

                while (reader.Read())
                {
                    string departmentName = reader.GetString(0);  
                    comboBoxJabatan.Items.Add(departmentName);  
                }
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

        private void InsertDataKaryawan()
        {
            string namaKaryawan = textBoxNama.Text;
            string namaDepartemen = comboBoxDep.SelectedItem?.ToString();
            string namaJabatan = comboBoxJabatan.SelectedItem?.ToString();
      
            if (string.IsNullOrEmpty(namaKaryawan) || string.IsNullOrEmpty(namaDepartemen) || string.IsNullOrEmpty(namaJabatan))
            {
                MessageBox.Show("Please fill all fields before inserting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new NpgsqlConnection(connString);
            try
            {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT insert_karyawan(@nama_karyawan, @nama_dep, @nama_jabatan);", conn))
                    {
                        cmd.Parameters.AddWithValue("nama_karyawan", namaKaryawan);
                        cmd.Parameters.AddWithValue("nama_dep", namaDepartemen);
                        cmd.Parameters.AddWithValue("nama_jabatan", namaJabatan);

                        cmd.ExecuteNonQuery();
                    }
                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNama.Clear();
                comboBoxDep.SelectedIndex = -1;
                comboBoxJabatan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditDataKaryawan()
        {
            if (dgvDataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            row = dgvDataTable.SelectedRows[0];
            int idKaryawan = Convert.ToInt32(row.Cells["id_karyawan"].Value);

            string namaKaryawan = textBoxNama.Text;
            string namaDepartemen = comboBoxDep.SelectedItem?.ToString();
            string namaJabatan = comboBoxJabatan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(namaKaryawan) || string.IsNullOrEmpty(namaDepartemen) || string.IsNullOrEmpty(namaJabatan))
            {
                MessageBox.Show("Please fill all fields before editing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT update_karyawan(@id_karyawan, @nama_karyawan, @nama_dep, @nama_jabatan);", conn))
                {
                    cmd.Parameters.AddWithValue("id_karyawan", idKaryawan);
                    cmd.Parameters.AddWithValue("nama_karyawan", namaKaryawan);
                    cmd.Parameters.AddWithValue("nama_dep", namaDepartemen);
                    cmd.Parameters.AddWithValue("nama_jabatan", namaJabatan);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteDataKaryawan()
        {
            if (dgvDataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            row = dgvDataTable.SelectedRows[0];
            int idKaryawan = Convert.ToInt32(row.Cells["id_karyawan"].Value);

            // Confirm before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the selected record (ID: {idKaryawan})?",
                                                  "Delete Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                conn = new NpgsqlConnection(connString);
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT delete_karyawan(@id_karyawan);", conn))
                    {
                        cmd.Parameters.AddWithValue("id_karyawan", idKaryawan);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload data in the DataGridView
                    LoadDataKaryawan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        //BUTTON ACTION HANDLER ======================================================================================================================================
        private void btnInsert_Click(object sender, EventArgs e)
        {

            InsertDataKaryawan();
            LoadDataKaryawan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDataKaryawan();
            LoadDataKaryawan();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataKaryawan();
            LoadDataKaryawan();
        }

        private void dgvDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgvDataTable.Rows[e.RowIndex];

                textBoxNama.Text = row.Cells["nama_karyawan"].Value?.ToString();
                comboBoxDep.SelectedItem = row.Cells["nama_dep"].Value?.ToString();
                comboBoxJabatan.SelectedItem = row.Cells["nama_jabatan"].Value?.ToString();
            }
        }


        private void labelNama_Click(object sender, EventArgs e)
        {

        }
    }

}