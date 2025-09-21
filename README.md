# IoC_Web - ASP.NET Core Razor Pages IoC (Inversion of Control) Demo

## Proje Hakkında

Bu proje, ASP.NET Core Razor Pages üzerinde Inversion of Control (IoC) ve Dependency Injection (DI) kavramlarını, Singleton, Scoped ve Transient yaşam süreleriyle birlikte örnekleyen bir demodur. Amaç, farklı yaşam sürelerine sahip servislerin uygulama davranışını ve çalışma zamanındaki etkilerini görsel olarak göstermektir.

## IoC (Inversion of Control) Nedir?

**Inversion of Control (IoC)**, bir nesnenin bağımlılıklarının (örneğin başka sınıflar veya servisler) doğrudan kendisi tarafından oluşturulmak yerine, dışarıdan bir mekanizma tarafından sağlanması prensibidir. Bu yaklaşım, kodun daha esnek, test edilebilir ve sürdürülebilir olmasını sağlar.

### Dependency Injection (DI)

IoC'nin en yaygın uygulama şekli Dependency Injection'dır. ASP.NET Core, yerleşik DI konteyneri ile servislerin yaşam sürelerini ve bağımlılıklarını yönetir.

#### Yaşam Süreleri

- **Singleton:** Uygulama boyunca tek bir örnek oluşturulur ve her yerde aynı nesne kullanılır.
- **Scoped:** Her HTTP isteği için bir örnek oluşturulur. Aynı istek içinde aynı nesne kullanılır.
- **Transient:** Her talepte ve her kullanıldığında yeni bir nesne oluşturulur.

## Proje Özellikleri

- Razor Pages ile modern ve sade arayüz
- Singleton, Scoped ve Transient servislerin davranışlarını karşılaştırmalı olarak gösteren ana sayfa
- Bootstrap ile responsive tasarım
- Controller ve ViewBag üzerinden servis değerlerinin gösterimi

## Kurulum ve Çalıştırma

1. Repoyu klonlayın:
```
  git clone https://github.com/BurakErkemen/IoC-DIP-DI.git
```
2. Proje dizinine girin ve NuGet paketlerini yükleyin:
```
cd IoC-DIP-DI/IoC_Web dotnet restore
```
4. Uygulamayı başlatın:
```
dotnet run
```
6. Tarayıcınızda `https://localhost:5001` adresini açın.

## Kullanım

- Ana sayfada Singleton, Scoped ve Transient servislerin değerlerini görebilirsiniz.
- Sayfayı yenileyerek (F5) değerlerin nasıl değiştiğini veya değişmediğini gözlemleyin.

## Proje Yapısı

- `Controllers/` : Controller sınıfları
- `Models/`      : Servis arayüzleri ve implementasyonları
- `Views/`       : Razor sayfaları ve layout dosyaları
- `wwwroot/`     : Statik dosyalar (CSS, JS, kütüphaneler)

