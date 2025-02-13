using StudentManagement.DataAccess;
using StudentManagement.Business;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


var connectionString = app.Configuration.GetConnectionString("StudentManagementDatabase");


builder.Services.AddDbContext<EfContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(c => c.AddProfile<ModelAutoMapping>(), AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(c => c.AddProfile<ServiceAutoMapping>(), AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddServiceResolver();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
