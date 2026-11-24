# Aplikasi Kasir Pecel Lele

Aplikasi desktop Windows Forms berbasis VB.NET (.NET 8) untuk kasir kedai pecel lele.

## Fitur

- Halaman awal pemilihan pengguna:
  - **User** langsung masuk tanpa password.
  - **Admin** harus login menggunakan akun di tabel `tb_login`.
- Hak akses:
  - User hanya dapat memesan/melakukan transaksi dan melihat daftar menu.
  - Admin dapat melihat data lengkap: riwayat transaksi, ringkasan pendapatan, dan kelola menu.
- Login admin dengan validasi, query parameterized, dan password ter-hash (PBKDF2-SHA256).
- Dashboard admin dengan informasi admin yang sedang login.
- Transaksi:
  - Mengisi nama pembeli sebelum memesan.
  - Memilih makanan/minuman dari database.
  - Mengatur qty.
  - Menghitung harga dan total otomatis.
  - Menghapus item dari keranjang.
  - Membayar tunai dan menghitung kembalian.
  - Menyimpan header + detail transaksi dalam satu database transaction.
- Struk transaksi dan pratinjau cetak.
- Riwayat transaksi (admin):
  - Filter tanggal awal dan akhir.
  - Nama pembeli tampil di daftar transaksi.
  - Detail item per transaksi.
  - Ringkasan jumlah transaksi dan total pendapatan.
  - Melihat ulang struk.
- Kelola menu (admin): tambah, ubah, hapus, dan lihat daftar menu.
- Logout admin dan kembali ke halaman pemilihan pengguna.

## Hak Akses

| Fitur | User | Admin |
|---|---|---|
| Memesan / transaksi | Ya | Ya |
| Melihat daftar menu | Ya | Ya |
| Riwayat transaksi & ringkasan pendapatan | Tidak | Ya |
| Kelola menu | Tidak | Ya |
| Dashboard admin | Tidak | Ya |

User tidak memakai password karena ditujukan untuk alur pemesanan cepat di perangkat kasir. Pembatasan admin juga diperiksa ulang saat Form4 (riwayat), Form7 (kelola menu), dan Form8 (dashboard admin) dibuka.

## Struktur Project

```
Project.kasirPecelLele/
├── Database/
│   ├── 01_create_tb_menu.sql
│   ├── 02_create_tb_transaksi.sql
│   ├── 03_secure_tb_login.sql
│   └── 04_add_nama_pembeli.sql
├── Project.kasirPecelLele/
│   ├── Form1.vb              ' Login admin
│   ├── Form2.vb              ' Halaman awal / pilih pengguna
│   ├── Form3.vb              ' Transaksi
│   ├── Form4.vb              ' Riwayat transaksi dan ringkasan (admin)
│   ├── Form5.vb              ' Pembayaran dan kembalian
│   ├── Form6.vb              ' Struk dan pratinjau cetak
│   ├── Form7.vb              ' Kelola menu (admin)
│   ├── Form8.vb              ' Dashboard admin
│   ├── Navigasi.vb           ' Navigasi antar form
│   ├── Koneksi.vb            ' Koneksi database terpusat
│   ├── Sesi.vb               ' Menyimpan user dan role yang sedang aktif
│   ├── PasswordHelper.vb     ' Hash dan verifikasi password PBKDF2
│   ├── ItemKeranjang.vb      ' Model item transaksi
│   ├── TransaksiRepository.vb
│   └── MenuRepository.vb
├── .sln
└── README.md
```

Form yang pertama muncul saat aplikasi dijalankan adalah **Form2** (diatur melalui `My Project/Application.myapp`).

## Setup Database

1. Buka SQL Server Management Studio.
2. Pastikan database `db_pecel_lele` sudah ada dan tabel `tb_login` sudah berisi akun admin.
3. Jalankan `Database/01_create_tb_menu.sql`.
4. Jalankan `Database/02_create_tb_transaksi.sql`.
5. Jalankan `Database/03_secure_tb_login.sql`.
6. Jalankan `Database/04_add_nama_pembeli.sql` (wajib untuk database yang sudah ada sebelum fitur nama pembeli ditambahkan).
7. Sesuaikan connection string di `Project.kasirPecelLele/Koneksi.vb` jika nama instance SQL Server berbeda.
8. Buka solution di Visual Studio, lalu jalankan aplikasi (F5).

## Alur Pemakaian

1. Jalankan aplikasi. Halaman **Pilih Pengguna** akan muncul.
2. Klik **Masuk sebagai User** untuk langsung membuka halaman transaksi tanpa password.
3. Isi **Nama Pembeli**, lalu pilih makanan/minuman, atur qty, dan klik **Tambah Makanan** atau **Tambah Minuman**.
4. Klik **Bayar & Simpan**, masukkan uang bayar, lalu konfirmasi.
5. Struk dapat dilihat dan dicetak; nama pembeli juga tampil pada struk.
6. Nama pembeli dan detail pesanan tampil pada halaman **Riwayat Transaksi** admin.
7. Klik **Kembali** untuk kembali ke halaman pemilihan pengguna.
8. Klik **Masuk sebagai Admin**, lalu masukkan username dan password admin.
9. Dari dashboard admin, buka **Transaksi**, **Riwayat Transaksi**, atau **Kelola Menu**.
10. Klik **Logout** untuk kembali ke halaman pemilihan pengguna.

## Troubleshooting

### "An application policy has blocked this file"

Pesan ini berasal dari **Smart App Control** Windows 11, bukan dari aplikasi. Smart App Control memblokir aplikasi yang belum ditandatangani, termasuk hasil build lokal dari Visual Studio.

Cara mengatasinya:

1. Buka **Windows Security**.
2. Pilih **App & browser control**.
3. Klik **Smart App Control settings**.
4. Pilih **Off**, lalu konfirmasi.
5. Tutup Visual Studio, build ulang, lalu jalankan aplikasi dengan **F5**.

Setelah dimatikan, Smart App Control hanya dapat diaktifkan kembali dengan reset atau instal ulang Windows. Jika tidak ingin mematikannya, aplikasi harus dijalankan di komputer lain yang kebijakan aplikasinya tidak memblokir file unsigned.

## Catatan

- Password admin disimpan sebagai hash PBKDF2-SHA256. Password lama yang masih teks biasa akan di-upgrade otomatis saat login pertama berhasil, sehingga pengguna tetap dapat memakai password yang sama.
- Role masih berupa dua tingkat tetap (User dan Admin). Belum ada halaman manajemen akun admin dari dalam aplikasi.
- User tanpa password bukan pengganti autentikasi multi-user; aplikasi ini ditujukan untuk perangkat kasir lokal.
- Transaksi yang dibuat melalui mode User tetap tersimpan dan dapat dilihat admin pada riwayat transaksi.
- Connection string masih diarahkan ke instance SQL Server lokal (`LAPTOP-5641CBJO\SQLEXPRESS`). Ubah sesuai environment.
- Belum ada manajemen stok bahan baku.
