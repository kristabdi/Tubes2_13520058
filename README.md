# graph-folder-crawling
Visualize folder crawling using BFS and DFS algorithm using C# and .NET

## Description
Aplikasi Folder Crawling GUI sederhana yang dibuat dengan bahasa pemrograman C# dalam framework .NET yang dapat menemukan file target dari start direktori. Dengan memanfaatkan algoritma Breadth First Search (BFS) dan Depth First Search (DFS), dapat menelusuri jalur pencarian file yang ingin ditemukan dan memodelkan jalur pencarian dalam bentuk pohon pencarian. Selain itu, pengguna juga dapat memilih untuk menemukan semua file dengan nama yang sama.
```
simpul dan sisi biru - jalur yang sudah ditelusuri dan ditemukan file yang ingin dicari
simpul dan sisi merah - jalur yang sudah ditelusuri dan tidak ditemukan file yang ingin dicari
simpul putih dan sisi hitam - jalur yang belum ditelusuri
```
## Requirements
**Catatan :** Anda perlu melakukan instalasi beberapa hal ini hanya jika Anda ingin menjalankan dari file solution.
1. [Visual Studio](https://visualstudio.microsoft.com/downloads/)
2. [MSAGL](https://github.com/microsoft/automatic-graph-layout)

## How To Run
Sebelum menjalankan aplikasi, pastikan Anda sudah melakukan download atau clone repository ini.
```
git clone https://github.com/kristabdi/graph-folder-crawling
```
Untuk menjalankan aplikasi  dapat dilakukan dengan 2 cara antara lain 
- Via File Solution dengan Visual Studio
   
    Untuk menjalan aplikasi folder crawling via file solution, Anda dapat melakukan hal berikut :
    
    1.  Jalankan Visual Studio yang sudah anda install sebelumnya.
    2.  Buka repository ini pada Visual Studio.
    3.  Buka solution explorer dan klik pada file graph-folder-crawling.sln
    4.  Klik tombol "Start" berwarna hijau pada panel atas dan pastikan project graph-folder-crawling sudah terpilih di solution explorer.
    5.  Visual studio akan secara otomatis melakukan *build* terhadap aplikasi ini dan jika build berhasil aplikasi akan segera dijalankan.
- Via Executable Code

    Untuk menjalankan aplikasi via executable code, Anda cukup buka folder bin dan double klik pada file graph-folder-crawling.exe (ekstensi ".exe").

## How To Use
1. Jalankan dan buka aplikasi folder crawling (via file solution atau via executable code).
2. Jika aplikasi berhasil dijalankan, akan ditampilkan menu utama dari aplikasi folder crawling.
3. Klik tombol “Browse” untuk memilih direktori yang ingin digunakan sebagai tempat mulainya jalur pencarian. 
4. Isi nama file yang dicari beserta ekstensinya misalnya "prak1.txt".
5. Centang ceklis findAllOccurence jika ingin menemukan semua file yang bernama sama.
6. Pilih metode yang ingin digunakan yaitu DFS atau BFS.
7. Klik tombol "Search" untuk memulai pencarian.
8. Pohon jalur pencarian dan Hyperlink file yang dicari akan berada di kanan layar aplikasi
9. Jika ingin mencari lagi, ulangi langkah dari nomor 2.

## Author
NIM | NAMA
--- | ---
13520058 | Kristo Abdi Wiguna
13520076 | Claudia
13520080 | Jason Kanggara