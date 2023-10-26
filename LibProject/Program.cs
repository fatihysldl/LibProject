using BusinessLayer.abstracts;
using BusinessLayer.concrete;
using DataAccessLayer.abstracts;
using DataAccessLayer.concrete;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<context>();
builder.Services.AddScoped<IMemberDal, EfMemberDal>();
builder.Services.AddScoped<IMemberService, memberManager>();

builder.Services.AddScoped<IBookDal, EfBookDal>();
builder.Services.AddScoped<IBookService, bookManager>();

builder.Services.AddScoped<IBookCategoryDal,EfBookCategoryDal>();
builder.Services.AddScoped<IBookCategoryService, bookCategoryManager>();


var app = builder.Build();
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
