CREATE OR REPLACE FUNCTION update_karyawan(
    up_id_karyawan INT,
    up_nama_karyawan TEXT,
    up_nama_dep TEXT,
    up_nama_jabatan TEXT
) RETURNS VOID AS $$
DECLARE
    dep_id INT;
    jabatan_id INT;
BEGIN
    -- Get the id of the department
    SELECT id_dep INTO dep_id
    FROM departemen
    WHERE nama_dep = up_nama_dep;

    -- Get the id of the job position
    SELECT id_jabatan INTO jabatan_id
    FROM jabatan
    WHERE nama_jabatan = up_nama_jabatan;

    -- Update the karyawan
    UPDATE karyawan
    SET nama_karyawan = up_nama_karyawan,
        id_dep = dep_id,
        id_jabatan = jabatan_id
    WHERE id_karyawan = up_id_karyawan;
END;
$$ LANGUAGE plpgsql;
