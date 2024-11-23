// WebApplication.Builder oluþturulur, uygulama yapýlandýrmalarýný ayarlamak için kullanýlýr.
var builder = WebApplication.CreateBuilder(args);

// Açýklama:
// `WebApplication.CreateBuilder`
// - Uygulamanýn baþlangýç noktasýdýr ve gerekli yapýlandýrmalarýn yapýlmasýný saðlar.
// - Bu metot, uygulama için bir Builder nesnesi oluþturur. 
// - `args` parametresi komut satýrý argümanlarýný alýr.

var app = builder.Build();

// Açýklama:
// `builder.Build()`
// - Builder nesnesini derler ve bir `WebApplication` nesnesi oluþturur.
// - Uygulama, oluþturulan bu nesne üzerinden çalýþtýrýlýr.

// Basit bir rota tanýmlanýr. Ana sayfa isteði yapýldýðýnda "Hello World!" döner.
app.MapGet("/", () => "Hello World!");

// Açýklama:
// `app.MapGet`
// - Belirtilen rotaya bir HTTP GET isteði geldiðinde, belirtilen iþlemi çalýþtýrýr.
// - Burada kök URL (`/`) talep edildiðinde, yanýt olarak "Hello World!" döner.

// Controller ve View hizmetlerini servislere ekler.
builder.Services.AddControllersWithViews();

// Açýklama:
// `builder.Services.AddControllersWithViews()`
// - MVC yapýsýný desteklemek için gerekli olan controller ve view hizmetlerini uygulamaya ekler.
// - Controller'lar aracýlýðýyla gelen istekler iþlenir ve View'lar kullanýcýya döndürülür.

// HTTP isteði iþleme hattý yapýlandýrýlýr. Geliþtirme ortamýnda deðilse hata iþleyici devreye girer.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Varsayýlan HSTS deðeri 30 gündür.
}

// Açýklama:
// `app.Environment.IsDevelopment()`
// - Uygulamanýn çalýþma ortamýný kontrol eder. Geliþtirme (Development) ortamýnda olup olmadýðýný belirler.
// `app.UseExceptionHandler`
// - Geliþtirme dýþý ortamlarda hata iþleme için belirli bir sayfayý yönlendirir.
// `app.UseHsts`
// - HTTPS kullanýmý için HTTP Strict Transport Security (HSTS) protokolünü etkinleþtirir.

// HTTPS'ye yönlendirme ve statik dosya servisi etkinleþtirilir.
app.UseHttpsRedirection();
app.UseStaticFiles();

// Açýklama:
// `app.UseHttpsRedirection()`
// - Tüm HTTP isteklerini otomatik olarak HTTPS'ye yönlendirir, güvenliði artýrýr.
// `app.UseStaticFiles()`
// - `wwwroot` dizinindeki statik dosyalarý (CSS, JavaScript, resimler vb.) sunar.

// Rotalama iþlemi etkinleþtirilir.
app.UseRouting();

// Açýklama:
// `app.UseRouting()`
// - Gelen istekleri belirli bir rotaya yönlendiren rotalama sistemini etkinleþtirir.

// Yetkilendirme middleware'i eklenir.
app.UseAuthorization();

// Açýklama:
// `app.UseAuthorization()`
// - Kullanýcýlarýn belirli sayfalara veya iþlemlere eriþim izni olup olmadýðýný kontrol eder.

// Varsayýlan rotalama düzeni tanýmlanýr.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Açýklama:
// `app.MapControllerRoute`
// - Controller tabanlý rotalarý tanýmlar. 
// - Burada varsayýlan rota düzeni belirlenmiþtir: 
//   Controller: Home, Action: Index, Opsiyonel id parametresi.

// Uygulama baþlatýlýr ve gelen istekleri dinlemeye baþlar.
app.Run();

// Açýklama:
// `app.Run()`
// - Uygulamayý baþlatýr ve HTTP isteklerini dinlemeye baþlar.
// - Bu metot uygulamanýn sonlandýrýcýsýdýr ve burada uygulama çalýþýr durumda kalýr.
