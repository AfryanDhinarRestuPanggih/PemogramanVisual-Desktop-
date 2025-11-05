using GarasiMobil.Models;
using GarasiMobil.Services;

var builder = WebApplication.CreateBuilder(args);

// Konfigurasi MongoDB settings dari appsettings.json
builder.Services.Configure<GarasiMobilDatabaseSettings>(
    builder.Configuration.GetSection("GarasiMobilDatabase"));

// Registrasi service untuk Car, Customer, dan Login
builder.Services.AddSingleton<CarService>();
builder.Services.AddSingleton<CustomerService>();
builder.Services.AddSingleton<LoginService>(); // ✅ ini diganti

// Tambahkan MVC Controller dengan Views
builder.Services.AddControllersWithViews();

// Tambahkan Session (penting untuk login)
builder.Services.AddSession();

var app = builder.Build();

// Middleware error handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession(); // ✅ aktifkan session sebelum routing

// 🚗 Atur route default ke LoginController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
