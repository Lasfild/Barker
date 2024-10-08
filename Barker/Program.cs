using Barker;
using Barker.DataAccess.Repository;
using Barker.DataAccess.Repository.IRepository;
using Barker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ��������� �������� ���� ������ � ��������� ������������
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// ��������� ����������� � ���������������
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������������ middleware
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "category",
        pattern: "Customer/Category/{name}",
        defaults: new { area = "Customer", controller = "Category", action = "Category" });

    endpoints.MapControllerRoute(
        name: "product",
        pattern: "Customer/Product/{id}",
        defaults: new { area = "Customer", controller = "Product", action = "Product" });
});


app.Run();
