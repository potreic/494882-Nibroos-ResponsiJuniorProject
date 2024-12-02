CREATE OR REPLACE FUNCTION insert_karyawan(
    in_nama_karyawan TEXT,
    in_nama_dep TEXT,
    in_nama_jabatan TEXT
) RETURNS VOID AS $$
DECLARE
    dep_id INT;
    jabatan_id INT;
BEGIN
    -- Get the id of the department
    SELECT id_dep INTO dep_id
    FROM departemen
    WHERE nama_dep = in_nama_dep;

    -- Get the id of the job position
    SELECT id_jabatan INTO jabatan_id
    FROM jabatan
    WHERE nama_jabatan = in_nama_jabatan;

    -- Insert the new karyawan
    INSERT INTO karyawan (id_dep, id_jabatan, nama_karyawan)
    VALUES (dep_id, jabatan_id, in_nama_karyawan); -- Use in_nama_karyawan
END;
$$ LANGUAGE plpgsql;
