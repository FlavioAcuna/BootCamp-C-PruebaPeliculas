var builder = WebApplication.CreateBuilder(args);
//indicar el servidor que utilizaremos arquitectura MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();
//Configuracion para utilizar rutas,archivos estaticos y autenficacion 
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id}"
);
app.Run();
