using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args); // Создает новый экземпляр приложения
builder.Services.AddControllersWithViews(); // Добавляет поддержку контроллеров и представлений в контейнер служб

var app = builder.Build(); // Строит приложение

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Использует страницу ошибки для неразработочной среды
    app.UseHsts(); // Включает HSTS (HTTP Strict Transport Security)
}

app.UseHttpsRedirection(); // Перенаправляет HTTP-запросы на HTTPS
app.UseStaticFiles(); // Включает поддержку статических файлов

app.UseRouting(); // Включает маршрутизацию

app.UseAuthorization(); // Включает авторизацию

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Определяет маршрут по умолчанию

app.Run(); // Запускает приложение
