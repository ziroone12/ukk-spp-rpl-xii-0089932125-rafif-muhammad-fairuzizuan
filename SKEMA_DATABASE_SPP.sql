-- Active: 1794277965729@@127.0.0.1@3306@mysql
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
    nama_petugas VARCHAR(30),
    level petugas_level_enum,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);

CREATE Table siswa(
    nisn CHAR(10),
    nis CHAR(8),
    nama VARCHAR(50),
    id_kelas INT,
    alamat TEXT,
    no_telp VARCHAR(15),
    id_spp
)