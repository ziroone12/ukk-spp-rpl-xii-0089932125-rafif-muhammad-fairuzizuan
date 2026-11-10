CREATE DATABASE db_spp_sekolah_xii;

CREATE Table spp(
  id_spp INT,
  tahun INT ,
  nominal INT, 
  keterangan VARCHAR(100),
  created_at TIMESTAMP,
  updated_at TIMESTAMP
);

CREATE Table kelas(
    id_kelas INT PRIMARY KEY,
    nama_kelas VARCHAR(15),
    kompetensi_keahlian VARCHAR(50),
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);

CREATE Table petugas(
    id_petugas INT PRIMARY KEY,
    username VARCHAR(30),
    password VARCHAR(255),
    
);