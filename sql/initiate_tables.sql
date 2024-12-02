-- Create the Jabatan table
CREATE TABLE Jabatan (
    id_jabatan SERIAL PRIMARY KEY, 
    nama_jabatan TEXT NOT NULL,
    salary NUMERIC NOT NULL
);

-- Create the Departemen table
CREATE TABLE Departemen (
    id_dep SERIAL PRIMARY KEY, 
    nama_dep TEXT NOT NULL
);

-- Create the Karyawan table
CREATE TABLE Karyawan (
    id_karyawan SERIAL PRIMARY KEY,
    nama_karyawan TEXT NOT NULL,
    id_dep INT REFERENCES Departemen(id_dep) ON DELETE CASCADE, 
    id_jabatan INT REFERENCES Jabatan(id_jabatan) ON DELETE CASCADE 
);
