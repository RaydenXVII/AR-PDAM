# Proyek Aplikasi AR PDAM Berbasis Android  

## 1. Deskripsi Proyek  
Aplikasi **Augmented Reality (AR) PDAM** merupakan media interaktif berbasis Android yang dikembangkan untuk mendukung penyampaian informasi, edukasi, serta visualisasi terkait layanan Perusahaan Daerah Air Minum (PDAM).  
Proyek ini dibangun menggunakan **Unity Editor versi 6000.2.0f1** dengan dukungan **AR Foundation** dan **Google ARCore**, sehingga dapat dijalankan secara optimal pada perangkat Android yang mendukung teknologi AR.  

## 2. Tujuan Pengembangan  
- Menyediakan sarana edukasi interaktif terkait sistem PDAM.  
- Memberikan pengalaman visual 3D yang lebih menarik dan mudah dipahami.  
- Mendukung implementasi teknologi AR pada perangkat mobile untuk kebutuhan edukasi dan informasi publik.  

## 3. Lingkup Fitur  
- **Visualisasi 3D**: Menampilkan objek 3D terkait layanan PDAM melalui kamera AR.  
- **Marker-based AR**: Menampilkan konten menggunakan marker tertentu.  
- **Interaksi Pengguna**: Mendukung rotasi, perbesaran (zoom), dan animasi objek.  
- **Kompatibilitas Android**: Build aplikasi difokuskan untuk perangkat Android.  

## 4. Teknologi yang Digunakan  
- **Unity Editor**: 6000.2.0f1  
- **AR Foundation**: (versi sesuai kebutuhan)  
- **ARCore XR Plugin**: integrasi AR pada Android  
- **Android SDK & NDK**: sesuai konfigurasi Unity  

## 5. Cara Menjalankan Aplikasi  
1. Clone repository proyek ini.  
2. Buka menggunakan **Unity Editor versi 6000.2.0f1**.  
3. Pastikan **AR Foundation** dan **ARCore XR Plugin** telah diinstal melalui Unity Package Manager.  
4. Hubungkan perangkat Android dengan **Developer Mode** aktif.  
5. Lakukan proses build melalui menu:  
   - *File > Build Settings > Android > Build & Run*.  
6. Aplikasi akan terpasang dan dapat dijalankan pada perangkat Android.  

## 6. Struktur Direktori  
```bash
/Assets
/Scenes -> Berisi scene utama AR
/Packages -> Berisi Package AR Core
/Prefabs -> Objek 3D dan marker
/Scripts -> Script kontrol dan interaksi AR
/Models -> Model 3D terkait PDAM
```

## 7. Tim Pengembang  
Proyek ini dikembangkan oleh **Tim AR PDAM** sebagai bagian dari implementasi teknologi AR dalam pengembangan aplikasi edukasi berbasis mobile.  
