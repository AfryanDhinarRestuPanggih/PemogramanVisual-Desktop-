# 🚘 GarasiMobil

**GarasiMobil** adalah aplikasi web modern untuk mengelola data **mobil** dan **customer** dalam satu sistem terpadu.  
Didesain dengan tampilan **mewah**, **modern**, dan **interaktif**, aplikasi ini cocok digunakan oleh showroom, dealer, atau bisnis jual beli mobil.

---

## Link YouTube  
https://youtu.be/eGKi_q1TiIM?si=zF42oxEy9nlfUaYS  

  

## Mock Up  
### Login  
<img width="974" height="525" alt="Screenshot 2025-12-02 010913" src="https://github.com/user-attachments/assets/67d000e0-f8a2-4ba9-b47f-7de602109f2a" />  

### Home  
<img width="978" height="529" alt="image" src="https://github.com/user-attachments/assets/581813c7-651d-4b3e-be99-4ba00827604c" />  

### Data Mobil  
<img width="975" height="526" alt="image" src="https://github.com/user-attachments/assets/b4a46580-7be1-4798-aa55-d83fe8b2343f" />  

### Data Customer  
<img width="972" height="524" alt="image" src="https://github.com/user-attachments/assets/1f8e0811-b9b8-4954-b1ca-219e9e568451" />  



## 🌐 1. Cara Setting Web Service dan Konfigurasi Web

### ⚙️ a. Setting Web Service
Web service pada **GarasiMobil** menggunakan **ASP.NET Core MVC** yang berkomunikasi dengan database **MongoDB**.

Langkah-langkah konfigurasi:

1. **Pastikan MongoDB berjalan**
   - Jalankan service MongoDB di komputer kamu (default port: `27017`).

2. **Konfigurasi koneksi database**
   - Buka file `appsettings.json`, lalu ubah bagian berikut sesuai koneksi lokal kamu:
     ```json
     {
       "ConnectionStrings": {
         "MongoDB": "mongodb://localhost:27017"
       },
       "DatabaseName": "GarasiMobilDB"
     }
     ```

3. **Daftarkan Service di Program.cs**
   Tambahkan dependency injection untuk menghubungkan MongoDB:
   ```csharp
   builder.Services.Configure<DatabaseSettings>(
       builder.Configuration.GetSection("ConnectionStrings"));
   builder.Services.AddSingleton<MongoDBService>();
--------------

## 📦 2. Nama Project dan Alasan Pemilihan

### Nama Project: **GarasiMobil**

**GarasiMobil** dipilih karena merepresentasikan tempat di mana semua data kendaraan dikumpulkan — seperti garasi yang menyimpan mobil.  
Nama ini menggambarkan aplikasi digital tempat transaksi dan pengelolaan mobil secara **online dan profesional**.

**Alasan menggunakan proyek ini:**
1. Fokus pada **penjualan kendaraan mobil**.
2. Tampilan **mewah dan elegan**, cocok untuk dealer modern.
3. Sistem dapat dikembangkan menjadi **platform showroom digital**.
4. Menggunakan teknologi terbaru yang stabil dan mudah di-maintain.

---

## 🔁 3. Bisnis Proses

### Deskripsi
**GarasiMobil** berfungsi sebagai sistem **manajemen penjualan mobil**.  
Admin dapat menambahkan data mobil yang dijual, mencatat data customer, serta mengelola transaksi dengan mudah.

### Alur Bisnis
1. **Admin login** ke dalam sistem.  
2. **Admin menambahkan data mobil** (merk, tipe, tahun, harga).  
3. **Customer melakukan pemesanan / pembelian.**  
4. Data customer disimpan secara otomatis di database.  
5. Admin dapat **melihat daftar mobil terjual** dan **membuat laporan sederhana.**

### Tujuan
- Mempercepat proses administrasi penjualan mobil.  
- Menyediakan data kendaraan dan pelanggan secara terstruktur.  
- Memberi kesan profesional melalui tampilan web yang menarik.

---
## 🔁 Diagram Bisnis Proses GarasiMobil
GarasiMobil adalah platform berbasis web yang dirancang untuk membantu proses **penjualan mobil** secara efisien dan modern.  
Website ini menghubungkan **admin** (penjual atau pengelola showroom) dengan **customer** (pembeli mobil) dalam satu sistem terintegrasi.  

Model bisnis GarasiMobil berfokus pada:
- **Kemudahan pengelolaan data mobil** bagi admin.
- **Kemudahan pencarian dan pembelian mobil** bagi customer.
- **Tampilan modern dan mewah** agar memberikan kesan profesional dan meningkatkan kepercayaan pembeli.
- **Pengelolaan data berbasis MongoDB** untuk kecepatan dan fleksibilitas penyimpanan.
<img width="1141" height="795" alt="Screenshot 2025-11-05 114244" src="https://github.com/user-attachments/assets/c33b7c03-34ed-4765-9640-a6b5edb47999" />

---  

## 💼 Diagram Model Bisnis  
<img width="600" height="822" alt="Screenshot 2025-11-05 114546" src="https://github.com/user-attachments/assets/6bfa4ffa-7c24-4655-94ce-690291413ed7" />

