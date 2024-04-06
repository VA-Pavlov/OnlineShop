using OnlineShopWebApp.Models.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IProductsList, ProductsList>();
builder.Services.AddSingleton<IBagsList, BagsList>();
builder.Services.AddSingleton<IOrdersList, OrdersList>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
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

app.Run();
