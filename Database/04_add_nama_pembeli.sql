/* ============================================================
   Project Kasir Pecel Lele
   Tambah kolom nama pembeli pada tabel transaksi
   Jalankan setelah 02_create_tb_transaksi.sql
   ============================================================ */

USE db_pecel_lele;
GO

IF COL_LENGTH('dbo.tb_transaksi', 'nama_pembeli') IS NULL
BEGIN
    ALTER TABLE dbo.tb_transaksi ADD nama_pembeli VARCHAR(50) NULL;
END;
GO

SELECT name, TYPE_NAME(user_type_id) AS tipe, max_length
FROM sys.columns
WHERE object_id = OBJECT_ID('dbo.tb_transaksi') AND name = 'nama_pembeli';
GO
