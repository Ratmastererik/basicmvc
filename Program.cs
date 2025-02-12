using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBlog.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MvcBlogContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcBlogContext") ?? throw new InvalidOperationException("Connection string 'MvcBlogContext' not found.")));
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<StuffService>();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
