CREATE OR REPLACE FUNCTION load_all_karyawan_info()
RETURNS TABLE (
    id_karyawan INT,
    nama_karyawan TEXT,
    nama_departmen TEXT,
    id_dep INT,
    nama_jabatan TEXT,
    id_jabatan INT
)
LANGUAGE plpgsql
AS
$$
BEGIN
    RETURN QUERY
    SELECT
        k.id_karyawan,
        k.nama_karyawan,
        d.nama_dep AS nama_departmen,
        k.id_dep,
        j.nama_jabatan,
        k.id_jabatan
    FROM
        Karyawan k
    JOIN Departemen d ON k.id_dep = d.id_dep
    JOIN Jabatan j ON k.id_jabatan = j.id_jabatan;
END;
$$;
