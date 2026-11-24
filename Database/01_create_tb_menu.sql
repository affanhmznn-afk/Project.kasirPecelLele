/* ============================================================
   Project Kasir Pecel Lele
   Membuat tabel master menu (makanan & minuman)
   Jalankan di SQL Server Management Studio pada database db_pecel_lele
   ============================================================ */

USE db_pecel_lele;
GO

IF OBJECT_ID('dbo.tb_menu', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_menu
    (
        id_menu   INT IDENTITY(1,1) NOT NULL,
        nama_menu VARCHAR(50) NOT NULL,
        kategori  VARCHAR(10) NOT NULL,
        harga     DECIMAL(12,0) NOT NULL,
        CONSTRAINT PK_tb_menu PRIMARY KEY (id_menu),
        CONSTRAINT UQ_tb_menu_nama UNIQUE (nama_menu),
        CONSTRAINT CK_tb_menu_kategori CHECK (kategori IN ('Makanan', 'Minuman')),
        CONSTRAINT CK_tb_menu_harga CHECK (harga >= 0)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.tb_menu)
BEGIN
    INSERT INTO dbo.tb_menu (nama_menu, kategori, harga) VALUES
        ('Gurame Bakar', 'Makanan', 25000),
        ('Lele Bakar',   'Makanan', 15000),
        ('Ayam Bakar',   'Makanan', 20000),
        ('Lele Goreng',  'Makanan', 13000),
        ('Ayam Goreng',  'Makanan', 18000),
        ('Es Jeruk',     'Minuman',  8000),
        ('Jeruk Anget',  'Minuman',  7000),
        ('Es Teh',       'Minuman',  5000),
        ('Teh Anget',    'Minuman',  4000),
        ('Es Doger',     'Minuman', 10000),
        ('Es Buah',      'Minuman', 12000);
END;
GO

SELECT id_menu, nama_menu, kategori, harga
FROM dbo.tb_menu
ORDER BY kategori, nama_menu;
GO
