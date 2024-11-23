// WebApplication.Builder olu�turulur, uygulama yap�land�rmalar�n� ayarlamak i�in kullan�l�r.
var builder = WebApplication.CreateBuilder(args);

// A��klama:
// `WebApplication.CreateBuilder`
// - Uygulaman�n ba�lang�� noktas�d�r ve gerekli yap�land�rmalar�n yap�lmas�n� sa�lar.
// - Bu metot, uygulama i�in bir Builder nesnesi olu�turur. 
// - `args` parametresi komut sat�r� arg�manlar�n� al�r.

var app = builder.Build();

// A��klama:
// `builder.Build()`
// - Builder nesnesini derler ve bir `WebApplication` nesnesi olu�turur.
// - Uygulama, olu�turulan bu nesne �zerinden �al��t�r�l�r.

// Basit bir rota tan�mlan�r. Ana sayfa iste�i yap�ld���nda "Hello World!" d�ner.
app.MapGet("/", () => "Hello World!");

// A��klama:
// `app.MapGet`
// - Belirtilen rotaya bir HTTP GET iste�i geldi�inde, belirtilen i�lemi �al��t�r�r.
// - Burada k�k URL (`/`) talep edildi�inde, yan�t olarak "Hello World!" d�ner.

// Controller ve View hizmetlerini servislere ekler.
builder.Services.AddControllersWithViews();

// A��klama:
// `builder.Services.AddControllersWithViews()`
// - MVC yap�s�n� desteklemek i�in gerekli olan controller ve view hizmetlerini uygulamaya ekler.
// - Controller'lar arac�l���yla gelen istekler i�lenir ve View'lar kullan�c�ya d�nd�r�l�r.

// HTTP iste�i i�leme hatt� yap�land�r�l�r. Geli�tirme ortam�nda de�ilse hata i�leyici devreye girer.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Varsay�lan HSTS de�eri 30 g�nd�r.
}

// A��klama:
// `app.Environment.IsDevelopment()`
// - Uygulaman�n �al��ma ortam�n� kontrol eder. Geli�tirme (Development) ortam�nda olup olmad���n� belirler.
// `app.UseExceptionHandler`
// - Geli�tirme d��� ortamlarda hata i�leme i�in belirli bir sayfay� y�nlendirir.
// `app.UseHsts`
// - HTTPS kullan�m� i�in HTTP Strict Transport Security (HSTS) protokol�n� etkinle�tirir.

// HTTPS'ye y�nlendirme ve statik dosya servisi etkinle�tirilir.
app.UseHttpsRedirection();
app.UseStaticFiles();

// A��klama:
// `app.UseHttpsRedirection()`
// - T�m HTTP isteklerini otomatik olarak HTTPS'ye y�nlendirir, g�venli�i art�r�r.
// `app.UseStaticFiles()`
// - `wwwroot` dizinindeki statik dosyalar� (CSS, JavaScript, resimler vb.) sunar.

// Rotalama i�lemi etkinle�tirilir.
app.UseRouting();

// A��klama:
// `app.UseRouting()`
// - Gelen istekleri belirli bir rotaya y�nlendiren rotalama sistemini etkinle�tirir.

// Yetkilendirme middleware'i eklenir.
app.UseAuthorization();

// A��klama:
// `app.UseAuthorization()`
// - Kullan�c�lar�n belirli sayfalara veya i�lemlere eri�im izni olup olmad���n� kontrol eder.

// Varsay�lan rotalama d�zeni tan�mlan�r.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// A��klama:
// `app.MapControllerRoute`
// - Controller tabanl� rotalar� tan�mlar. 
// - Burada varsay�lan rota d�zeni belirlenmi�tir: 
//   Controller: Home, Action: Index, Opsiyonel id parametresi.

// Uygulama ba�lat�l�r ve gelen istekleri dinlemeye ba�lar.
app.Run();

// A��klama:
// `app.Run()`
// - Uygulamay� ba�lat�r ve HTTP isteklerini dinlemeye ba�lar.
// - Bu metot uygulaman�n sonland�r�c�s�d�r ve burada uygulama �al���r durumda kal�r.
