using Barker.Interfaces;
using Barker.Mocks;

var builder = WebApplication.CreateBuilder(args); // Создает новый экземпляр приложения

builder.Services.AddControllersWithViews(); // Добавляет поддержку контроллеров и представлений в контейнер служб
builder.Services.AddTransient<IAllProducts, MockProduct>();
builder.Services.AddTransient<IProductCategory, MockCategory>();

var app = builder.Build(); // Строит приложение

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Использует страницу ошибки для неразработочной среды
    app.UseHsts(); // Включает HSTS (HTTP Strict Transport Security)
}
else
{
    app.UseDeveloperExceptionPage(); // Включает страницу разработчика для отладки ошибок
}

app.UseHttpsRedirection(); // Перенаправляет HTTP-запросы на HTTPS
app.UseStaticFiles(); // Включает поддержку статических файлов
app.UseStatusCodePages(); // Включает страницы для отображения кодов статуса

app.UseRouting(); // Включает маршрутизацию
app.UseAuthorization(); // Включает авторизацию

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Определяет маршрут по умолчанию

app.Run(); // Запускает приложение
