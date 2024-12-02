CREATE OR REPLACE FUNCTION delete_karyawan(up_id_karyawan INT) 
RETURNS VOID AS $$
BEGIN
    DELETE FROM karyawan
    WHERE id_karyawan = up_id_karyawan;
END;
$$ LANGUAGE plpgsql;
