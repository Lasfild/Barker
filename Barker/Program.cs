using Barker;
using Barker.Interfaces;
using Barker.Models;
using Barker.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Добавляем контекст базы данных в контейнер зависимостей
builder.Services.AddDbContext<AppDBContent>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Регистрируем реализации интерфейсов
builder.Services.AddScoped<IAllProducts, ProductRepository>();
builder.Services.AddScoped<IProductCategory, CategoryRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddCoreAdmin();

var app = builder.Build();

// Конфигурация middleware

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Инициализация базы данных
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDBContent>();

    // Создание базы данных, если она не существует
    context.Database.EnsureCreated();

    // Заполнение базы данных начальными данными
    DBObjects.Initial(context);
}

app.Run();
