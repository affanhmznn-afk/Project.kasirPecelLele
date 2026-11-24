/* ============================================================
   Project Kasir Pecel Lele
   Memperlebar kolom password agar dapat menyimpan hash PBKDF2.
   Password lama tetap dapat dipakai; akan di-upgrade otomatis
   saat login pertama setelah aplikasi diperbarui.
   ============================================================ */

USE db_pecel_lele;
GO

IF EXISTS
(
    SELECT 1
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'tb_login'
      AND COLUMN_NAME = 'password'
      AND CHARACTER_MAXIMUM_LENGTH < 255
)
BEGIN
    ALTER TABLE dbo.tb_login ALTER COLUMN password VARCHAR(255) NULL;
END;
GO

-- Pastikan username unik agar proses login tidak ambigu.
IF OBJECT_ID('dbo.tb_login', 'U') IS NOT NULL
   AND NOT EXISTS
   (
       SELECT 1
       FROM sys.indexes
       WHERE name = 'UX_tb_login_username'
         AND object_id = OBJECT_ID('dbo.tb_login')
   )
   AND NOT EXISTS
   (
       SELECT username
       FROM dbo.tb_login
       GROUP BY username
       HAVING COUNT(*) > 1
   )
BEGIN
    CREATE UNIQUE INDEX UX_tb_login_username ON dbo.tb_login(username);
END;
GO

SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'tb_login'
ORDER BY ORDINAL_POSITION;
GO
