/* ============================================================
   Project Kasir Pecel Lele
   Tabel transaksi dan detail transaksi
   Jalankan setelah 01_create_tb_menu.sql
   ============================================================ */

USE db_pecel_lele;
GO

IF OBJECT_ID('dbo.tb_transaksi', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_transaksi
    (
        id_transaksi  INT IDENTITY(1,1) NOT NULL,
        no_transaksi  VARCHAR(30) NOT NULL,
        tanggal       DATETIME NOT NULL CONSTRAINT DF_tb_transaksi_tanggal DEFAULT GETDATE(),
        username      VARCHAR(50) NOT NULL,
        nama_pembeli  VARCHAR(50) NULL,
        total         DECIMAL(12,0) NOT NULL,
        bayar         DECIMAL(12,0) NOT NULL,
        kembalian     DECIMAL(12,0) NOT NULL,
        metode_bayar  VARCHAR(20) NOT NULL CONSTRAINT DF_tb_transaksi_metode DEFAULT 'Tunai',
        CONSTRAINT PK_tb_transaksi PRIMARY KEY (id_transaksi),
        CONSTRAINT UQ_tb_transaksi_no UNIQUE (no_transaksi)
    );
END;
GO

IF OBJECT_ID('dbo.tb_detail_transaksi', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_detail_transaksi
    (
        id_detail     INT IDENTITY(1,1) NOT NULL,
        id_transaksi  INT NOT NULL,
        id_menu       INT NULL,
        nama_menu     VARCHAR(50) NOT NULL,
        kategori      VARCHAR(10) NOT NULL,
        harga         DECIMAL(12,0) NOT NULL,
        qty           INT NOT NULL,
        subtotal      DECIMAL(12,0) NOT NULL,
        CONSTRAINT PK_tb_detail_transaksi PRIMARY KEY (id_detail),
        CONSTRAINT FK_detail_transaksi FOREIGN KEY (id_transaksi)
            REFERENCES dbo.tb_transaksi(id_transaksi) ON DELETE CASCADE,
        CONSTRAINT FK_detail_menu FOREIGN KEY (id_menu)
            REFERENCES dbo.tb_menu(id_menu) ON DELETE SET NULL
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_tb_transaksi_tanggal' AND object_id = OBJECT_ID('dbo.tb_transaksi'))
    CREATE INDEX IX_tb_transaksi_tanggal ON dbo.tb_transaksi(tanggal);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_tb_detail_transaksi_id' AND object_id = OBJECT_ID('dbo.tb_detail_transaksi'))
    CREATE INDEX IX_tb_detail_transaksi_id ON dbo.tb_detail_transaksi(id_transaksi);
GO

SELECT name FROM sys.tables WHERE name IN ('tb_transaksi', 'tb_detail_transaksi') ORDER BY name;
GO
