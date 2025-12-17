🚀 WinForm API Integration & UI Design
Bu proje, C# Windows Forms platformunda asenkron programlama teknikleri kullanılarak bir REST API'den veri çekilmesini ve bu verilerin modern bir kullanıcı arayüzü ile sunulmasını gösteren bir case study çalışmasıdır.

🌟 Öne Çıkan Özellikler
Asenkron Programlama (async/await): API istekleri sırasında UI thread'inin bloklanması engellenerek kullanıcı deneyimi (UX) maksimize edilmiştir.

Modern UI Tasarımı: Standart WinForm DataGridView bileşeni, özel bir metot (GridiGuzellestir) ile modern, şık ve okunabilir bir temaya dönüştürülmüştür.

JSON Veri Yönetimi: Newtonsoft.Json kütüphanesi kullanılarak API'den dönen veriler Tip-Güvenli (Type-Safe) C# modellerine map edilmiştir.

Hata Yönetimi: Uygulama içerisinde try-catch-finally blokları ile ağ hataları kontrol altına alınmış ve kullanıcıya anlamlı geri bildirimler sağlanmıştır.

🛠 Teknik Stack
Dil: C# (.NET Framework/Core)

Arayüz: Windows Forms (WinForms)

Kütüphaneler: * System.Net.Http: API haberleşmesi için.

Newtonsoft.Json: JSON deserialization işlemleri için.

Veri Kaynağı: JSONPlaceholder (REST API)

📋 Kod Yapısı ve Analizi
1. Model Tabanlı Yaklaşım
API'den gelen veriler için oluşturulan post sınıfı, verilerin yapısal olarak doğru yönetilmesini sağlar:

C#

public class post {
    public int Id { get; set; }
    public String Title { get; set; }
    public String Body { get; set; }
}
2. UI Özelleştirme (Modernization)
Projenin görsel kalitesini artıran GridiGuzellestir fonksiyonu şu detayları içerir:

Zebra Efekti: Satırlar arasında renk geçişi (AlternatingRowsDefaultCellStyle).

Flat Design: Kenarlıkların ve header yapısının modern UI standartlarına uygun düzenlenmesi.

Responsive Kolonlar: Verinin ekrana tam sığması için AutoSizeColumnsMode kullanımı.

🚀 Nasıl Çalıştırılır?
Projeyi bilgisayarınıza clone'layın.

NuGet Paket Yöneticisi üzerinden Newtonsoft.Json paketini yükleyin.

Projeyi Build edin ve çalıştırın.

"Veri Çek" butonuna basarak API entegrasyonunu deneyimleyin.

Geliştirici: Yakup Daş
