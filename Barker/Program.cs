using Barker.Interfaces;
using Barker.Mocks;

var builder = WebApplication.CreateBuilder(args); // ������� ����� ��������� ����������

builder.Services.AddControllersWithViews(); // ��������� ��������� ������������ � ������������� � ��������� �����
builder.Services.AddTransient<IAllProducts, MockProduct>();
builder.Services.AddTransient<IProductCategory, MockCategory>();

var app = builder.Build(); // ������ ����������

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // ���������� �������� ������ ��� ��������������� �����
    app.UseHsts(); // �������� HSTS (HTTP Strict Transport Security)
}
else
{
    app.UseDeveloperExceptionPage(); // �������� �������� ������������ ��� ������� ������
}

app.UseHttpsRedirection(); // �������������� HTTP-������� �� HTTPS
app.UseStaticFiles(); // �������� ��������� ����������� ������
app.UseStatusCodePages(); // �������� �������� ��� ����������� ����� �������

app.UseRouting(); // �������� �������������
app.UseAuthorization(); // �������� �����������

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // ���������� ������� �� ���������

app.Run(); // ��������� ����������
