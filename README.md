# 📬 ASP.NET Core 8.0 Identity Projesi

Murat Yücedağ hocamızın eğitmenliğinde ve M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde yapmış olduğum **"ASP.NET Core 8.0 ve Identity ile Mail Uygulaması"** projesini başarıyla tamamladım! 🏆

## 🚀 Proje Özeti

Bu uygulama, kullanıcıların güvenli bir şekilde birbirleriyle mesajlaşmalarını sağlayan bir mail/mesajlaşma sistemidir. ASP.NET Core Identity altyapısı ile kimlik doğrulama ve yetkilendirme işlemleri uygulanmıştır. 

### Temel Özellikler:
- Kayıt olma ve giriş yapma (validation kuralları ve şifre güvenliği ile)
- Gelen kutusu, giden kutusu ve çöp kutusu
- Yeni mesaj oluşturma, mesaj görüntüleme, silme
- Kullanıcı profil bilgilerini görüntüleme ve güncelleme
- Okundu/okunmadı durumu takibi, mesaj arama

### 🛠️ Kullanılan Teknolojiler

- ⚡ **ASP.NET Core 8.0**: Modern web uygulamaları geliştirmek için güçlü, esnek ve yüksek performanslı framework.
- 🔑 **ASP.NET Core Identity**: Kullanıcı kimlik doğrulama, güvenlik ve yetkilendirme işlemleri için kapsamlı bir yapı.
- 🎨 **Razor Views & Partial Views**: Dinamik ve sürdürülebilir kullanıcı arayüzleri geliştirmeye olanak tanır, sayfa bileşenlerini modüler hale getirir.
- ⚙️ **Dependency Injection (DI)**: Uygulamanın bağımlılıklarını yönetmek, esnek ve test edilebilir bir yapı oluşturmak için kullanılır.
- 🛠️ **Authentication & Authorization**: Kullanıcıların güvenli bir şekilde giriş yapmalarını sağlayarak, roller ve yetkilendirme işlemlerini yönetir.
- 🔄 **Veritabanı Migrasyonları**: Veritabanı yapısını güncelleme ve şemada yapılan değişiklikleri yönetme sürecini kolaylaştırır.
- 🔒 **Şifreleme ve Güvenlik**: Kullanıcı şifrelerini güvenli bir şekilde saklamak için şifreleme teknikleri ve hashleme yöntemleri uygulanır.


## 🧰 Uygulama Detayları

- **🔐 Kayıt & Giriş Sistemi:**  
  Hash'lenmiş şifreler, başarısız girişlerde zaman sınırlı bloke işlemi
  
  ![login](/images/giris.png)
  ![register](/images/kayit.png)
  
- **📊 Dashboard:**

Dashboard, kullanıcının mesajlaşma uygulamasına dair genel bilgileri hızlıca görmesine olanak tanır. Bu sayfa şunları içerir:

  ![dashboard](/images/dashboard.png)
  
 **Gelen Mesaj Sayısı**: Kullanıcının almış olduğu toplam mesaj sayısı.
 **Giden Mesaj Sayısı**: Kullanıcının gönderdiği toplam mesaj sayısı.
 **Son Gelen Mesaj**: Kullanıcının aldığı en son mesajın detayları
 **Son Gönderilen Mesaj**: Kullanıcının gönderdiği en son mesajın detayları
  
Ayrıca, kullanıcıya aşağıdaki sayfalara kolayca yönlendirme yapılır:

- **Profilim**: Kullanıcının profil bilgilerini görüntüleyip güncelleyebileceği sayfa.
- **Yeni Mesaj**: Kullanıcıların diğer kullanıcılara mesaj gönderebileceği sayfa.

- **📨 Mesajlaşma Özelliği:**

Mesajlaşma bölümü, kullanıcıların iletişimini kolaylaştıran çeşitli özelliklere sahiptir:

  ![message](/images/gelen-kutusu.png)
  ![message](/images/giden-kutusu.png)
  ![message](/images/message-detail.png)
  ![message](/images/search.png)
  
- **Okundu / Okunmadı Durumu**: Kullanıcılar, mesajlarını okundu veya okunmadı olarak işaretleyebilir. Bu özellik, mesajların durumunu takip etmeyi kolaylaştırır.
- **Arama & Filtreleme**: Mesajlar üzerinde arama yapabilir ve filtreleme işlemleri gerçekleştirebilirsiniz. Arama, konu veya mesaj içeriği gibi kriterlere göre yapılabilir, böylece istenilen mesajlara hızlıca ulaşabilirsiniz.

- **📝 Yeni Mesaj Gönderimi:**
  
  Alıcı adı, e-posta, konu ve içerik girilerek mesaj oluşturma
  
 ![message](/images/yeni-mesaj.png)
  ![message](/images/send-message.png)
  
- **👤 Profil Sayfası:**
  
  Ad, soyad, e-posta bilgileri ve mesaj istatistikleri

 ![profile](/images/edit-profile.png)
  
- **🗑️ Çöp Kutusu:**  
  Silinen mesajlar bu bölümde görüntülenir.
  
  ![message](/images/trash.png)
  

## 🎓 Kazanımlarım

Bu proje ile:
- ASP.NET Core 8.0 mimarisine hâkimiyet kazandım
- Identity ile güvenli kullanıcı yönetimini uygulamalı olarak öğrendim
- Modern, kullanıcı dostu arayüzler tasarladım
- Veri modelleme, LINQ sorguları ve veritabanı işlemlerinde yetkinlik kazandım
