var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Activate MVC

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

//Routing

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
