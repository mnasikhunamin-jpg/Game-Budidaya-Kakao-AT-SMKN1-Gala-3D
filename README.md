# 🍫 AgroEdu Kakao 3D - Game Edukasi Budidaya Tanaman Kakao (Hulu ke Hilir)

Aplikasi game edukasi interaktif berbasis 3D yang dirancang khusus untuk siswa **SMK Perkebunan** (Studi Kasus: SMKN 1 Gala). Game ini mensimulasikan seluruh rangkaian Standar Operasional Prosedur (SOP) budidaya tanaman kakao, mulai dari pembibitan, pemeliharaan, hingga pengolahan pascapanen menjadi cokelat batang siap konsumsi.

## 📱 Fitur & Modul Utama Game

1. **Modul 1: Perbanyakan & Pembibitan Vegetatif**
   - Simulasi interaktif teknik *Grafting* (Sambung Pucuk) klon kakao unggul.
   - Deteksi akurasi geseran pisau (*swipe*) dan kelurusan kambium.
2. **Modul 2: Persiapan Lahan & Penanaman**
   - Pengukuran jarak tanam ideal (3x3m atau 3x4m) menggunakan sistem ajir.
   - Mekanik penggalian lubang tanam standar industri (60x60x60 cm).
3. **Modul 3: Pemeliharaan & Proteksi Tanaman (OPT)**
   - Fitur pemindaian (*scanning*) untuk mendeteksi Hama Penggerek Buah Kakao (PBK) dan penyakit Busuk Buah (*Phytophthora*).
   - Pengambilan keputusan klinis pertanian untuk memilih jenis pestisida/tindakan pangkas.
4. **Modul 4 & 5: Panen, Pascapanen, & Hilirisasi**
   - Panen selektif buah matang berdasarkan perubahan warna visual 3D.
   - Manajemen waktu simulasi fermentasi kotak kayu 5 hari (wajib balik biji per 24 jam).
   - Kontrol suhu mesin pengeringan dan *roasting* (pemanggangan) pada suhu optimal 120°C.

## 📊 Sistem Integrasi Nilai Guru (Cloud Reporting)
Game ini dilengkapi dengan fitur pengiriman data otomatis menggunakan protokol `UnityWebRequest` ke **Google Forms & Google Sheets**. Begitu siswa menyelesaikan ujian praktikum digital di Modul 5, rekapitulasi nilai berupa:
- Nama & Kelas Siswa
- Nilai Kompetensi tiap Modul (M1 - M5)
Akan langsung terkirim secara *real-time* ke dasbor komputer Guru Pengawas tanpa perlu server tambahan.

## 🛠️ Spesifikasi & Optimasi Android
- **Engine:** Unity dengan *Universal Render Pipeline* (URP).
- **Gaya Visual:** *Low-Poly Art Style* (Ringan untuk HP Android RAM di bawah 3GB).
- **Kompresi Tekstur:** ASTC Format.
- **Target Target Arsitektur:** ARM64 (Ukuran file APK dioptimalkan di bawah 100 MB).

## 🚀 Cara Menjalankan Kode di Unity
1. Unduh atau *clone* repositori ini.
2. Masukkan seluruh file dari folder `Assets/Scripts` ke dalam folder skrip proyek Unity Anda.
3. Pasang masing-masing skrip manajer ke objek pengontrol (*Game Controller*) pada setiap *Scene* terkait di Unity Inspector.
4. Sesuaikan ID entri pada skrip `DataReporter.cs` dengan tautan Google Form milik sekolah Anda sebelum melakukan *Build APK*.
