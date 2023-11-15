İÇERİK



•	Hakkında
o	Kullanılan Teknolojiler
o	Programlama Dilleri
o	Kullanılan Kütüphaneler


•	Başlarken
o	Database Kurulumu
o	Başlangıç Projesi Ayarlama


•	Kullanımı ve Arayüzler
o	Sipariş Verme Ekranı
o	Ürün Kontrol Ekranı
o	Şirket Kontrol Ekranı
 
SANALOGİ CASE HAKKINDA
Veritabanı olarak MsSqlServer , Beckend tarafında EntityFramework ve WebApi kullanılarak yazılmış. Bir sipariş sistemi sistemidir.

Kullanılan Teknolojiler: #NetCore WebApi, #NetCore 6, #Net Cors, #NetCore MVC

Programlama Dili: C#, Ajax, HTML, CSS, Javascript

Kullanılan Kütüphaneler: Microsoft.AspNet.WebApi. Client,Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.Tool, Microsoft.EntityFrameworkCore.Sqlite, Autofac , Autofac.Extensions.DependencyInjection, Autofac.Extras.DynamicProxy, Castle.Core, Boostrap, Fontawesome

BAŞLARKEN

Database Kurulumu: Öncelikle Paket Yöneticisini çalıştırılmalı. Paket Yöneticisini açtıktan sonra ilk olarak migration eklenmeli. Paket Yöneticinde “add-migration [migrationadı]“ komutu çalıştırılmalı. Bu işlemler yapılırken “Default Project” DataAccess olarak ayarlanmalı. Migration eklendikten sonra “update-database” komutunu çalıştırın. Böylece database oluşur.

 ![addmigration komutu](https://user-images.githubusercontent.com/96738030/190131702-4ea9273b-3d40-491d-9556-2fe491e0aa51.png)

add-migration komutu

 ![update-database komutu](https://user-images.githubusercontent.com/96738030/190131733-9664e10a-bca7-4e35-a712-91780eb99854.png)

update-database komutu



Başlangıç Projesini Ayarlama: Program UI(User Interface) Beckend tarafı ayrıdır iki projeyi birlikte başlatmalısınız .Öncelikle solutiona sağ tık yapın. Çıkan menüden Set Startup Projects.. ‘e tıklayın açılan pencereden Multiple startup projectste  WebUI ve WebAPI yi seçin.  Uygula tıklayın sonrasında Tamam diyin. Artık web uygulamasını kullanmaya başlayabilirsiniz. Projeyi Start edip başlatın.
![setstartup 1 page](https://user-images.githubusercontent.com/96738030/190131801-543a2b01-bb9d-4846-8fce-da701313f6cf.png)

 
Set Startup Projects seçilmesi.
![setstartup 2 page](https://user-images.githubusercontent.com/96738030/190131836-71adf912-5737-4eaf-b3fe-be99b2e7ea74.png)

 
Multiple startup projects ayarı.
KULLANIMI
Sipariş Verme:  Bu pencerede ilk olarak karşısınız şirket seçme ve sipariş tarihini belirleme alanları gelecek ikisinin de seçili olması gerek yoksa bu adımı geçemezsiniz. İki seçili olduğunda bu defa ürün seçme ekranına geçen bir buton göreceksiniz. Bu butona tıklayarak ürün seçme bölümü açılır.

 ![ürünseçme bölümü](https://user-images.githubusercontent.com/96738030/190132130-c0db9095-12a7-4305-be6c-94cef6eb4e54.png)

Şirket ve tarih belirleme ekranı.

Bu aşamayı geçtikten sonra ürün seçme bölümü açılacaktır. Burada bir seçmeli yerden ürününüzü seçip adetinizi giriniz ödeyeceğiniz tutar Tutar bölümünde görülecektir. Bu işlemi tamamladıktan sonra Ekle butonuna tıklayın altta bir tablo olarak alacağınız ürünlere eklenecektir. 
 ![ürünseçme bölümü](https://user-images.githubusercontent.com/96738030/190132098-fc301e7c-65af-4d89-8d55-4b4e29376f6d.png)

Ürün seçme bölümü.
Ekle butonuna basıldıktan sonra aşağıda oluşan tablodan aldığınız ürünleri ve toplam tutarı göreceksiniz. Kaydet butonuna basıldığında işlem yapılır. Bir mesaj ile işlemin durumu bildirilir. Sipariş verilmiştir.
 ![Kaydet 1 page](https://user-images.githubusercontent.com/96738030/190132204-26d409f7-db91-40fb-9a3e-eafaf518aec2.png)

Girilen ürünlerin listelenmesi.

 ![Kaydet 2 page](https://user-images.githubusercontent.com/96738030/190132232-a2b7a692-fd59-40eb-927a-de29bcb266d7.png)

İşlemin bitirilmesi.





Ürün Kontrol Ekranı: Bu bölümün amacı elimizde bulunan ürünlerin kontrolünün sağlanması üzerinde güncellemelerin yapılmasıdır. İlk olarak ürünler listelenir. Ürün hakkında gereken bilgiler verilir. 
 ![ürünkontrolilk görünüm](https://user-images.githubusercontent.com/96738030/190132316-ad867ea6-ebc0-4b48-8b78-2ae60952a63e.png)

Ürün kontrol ilk ekran

Ekleme: Karşınıza girmeniz gereken bilgiler çıkar bilgileri girdikten sonra ekle butonunuza basıp bilgileri ekleyebilirsiniz.
 ![ekleme](https://user-images.githubusercontent.com/96738030/190132377-9c0b2250-169b-4779-808c-43aaef8a8945.png)

Ürün Ekleme 

 ![zambakekle](https://user-images.githubusercontent.com/96738030/190132418-5d4d0f0b-f45b-4f59-94f4-21aa2299dde3.png)

Bilgilerin girilmesi.

 ![zambak göründü](https://user-images.githubusercontent.com/96738030/190132431-c776f0e8-73c3-4c6d-b48a-b1880f0951a1.png)

Sonuç.

Güncelleme: Ürünün yanında bulunan güncelleme butonuna basınız karşınıza bir güncelleme işlemi çıkacaktır. Ürüne ait değiştirmek istediğiniz alanları değiştirin ve işlemi yapın.

 ![güncellemeekranı](https://user-images.githubusercontent.com/96738030/190132476-3f48f56f-3e6c-4b4c-8a6b-aaee17188ca8.png)

Güncelleme ekranı.

 ![bilgigüncelleme](https://user-images.githubusercontent.com/96738030/190132496-62df1e24-0eac-4a69-813d-ea21e0e93386.png)

Bilgi güncelleme.

 ![çıktı](https://user-images.githubusercontent.com/96738030/190132509-f7a0d0bf-5469-4dcf-be96-1a972d9fdd04.png)

Çıktı.

Silme: Ürünün yanında bulunan silme butonuna tıklamanız yeterlidir. Böylece silme işleminiz tamamlanacaktır.

 ![silme](https://user-images.githubusercontent.com/96738030/190132557-47045898-26f4-4d39-9be4-1604db0f9ff7.png)

Zambak Ürünü Silindi.
Şirket Kontrol: Bu bölüm şirket üzerinde ekleme düzenleme veya silme işlemlerini yaptığımız bölümdür.

 ![ŞirketKontrolİlkGöünüm](https://user-images.githubusercontent.com/96738030/190132614-0014d9aa-332b-47d8-be36-7a9961f9cfa6.png)

Şirket Kontrol Ekranı İlk Görünüm
Ekleme: Karşınıza girmeniz gereken bilgiler çıkar bilgileri girdikten sonra ekle butonunuza basıp bilgileri ekleyebilirsiniz.

![EklemeEkranı(şirket)](https://user-images.githubusercontent.com/96738030/190132665-faf0fb18-ed07-4956-890a-8dc2016e80a0.png)

 
CCompany’i Ekliyoruz.
 
![Çıktı(Şirketekleme)](https://user-images.githubusercontent.com/96738030/190132696-44c1f9cd-5756-43bb-a4b1-d6dcb8fc20e8.png)
Ekleme İşlemi Çıktı.
Güncelleme: Şirket yanında bulunan güncelleme butonuna basınız karşınıza bir güncelleme işlemi çıkacaktır. Şirkete ait ismi değiştirin ve işlemi yapın.
 ![Güncellemeİlk](https://user-images.githubusercontent.com/96738030/190132788-f49222ce-09be-4690-ae9d-afbeb8aa80d4.png)

CCompany VCompanye Güncelliyoruz.

 ![çıktı](https://user-images.githubusercontent.com/96738030/190132805-92eac168-4240-4364-9c4c-9fca28b81e53.png)

VCompany olarak güncellendi.
Silme: Şirket yanında bulunan silme butonuna tıklamanız yeterlidir. Böylece silme işleminiz tamamlanacaktır.

 ![silmeilk](https://user-images.githubusercontent.com/96738030/190132849-34d37ca8-4201-4ba3-8a95-868f1953a5a2.png)

VCompany yanındaki sil butonuna tıklıyoruz.
![Silmeçıktı](https://user-images.githubusercontent.com/96738030/190132882-42928172-4d3f-40f3-a95d-19f9892c609b.png)

 
VCompany Silindi.


Bu proje Yalçın UZUN tarafından hazırlanmıştır.
