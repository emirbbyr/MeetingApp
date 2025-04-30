var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews ();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
//default olarak ana sayfaya hangi controller çıksın?
app.Run();
