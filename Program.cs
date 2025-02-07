var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<StuffService>();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
