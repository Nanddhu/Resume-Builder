using Microsoft.EntityFrameworkCore;
using ResumeBuilders.Data;
using ResumeBuilders.Services;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AuthService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 33)),
    mySqlOptions=>
    {
        mySqlOptions.EnableRetryOnFailure();
    }
    ));
 
builder.Services.AddSession(options=>
{
    options.IdleTimeout=TimeSpan.FromMinutes(30);
   
});

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Landing}/{action=Index}/{id?}");

app.Run();

