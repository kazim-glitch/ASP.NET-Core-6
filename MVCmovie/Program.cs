using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCmovie.Data;
using MVCmovie.Models;
using MVCmovie.ActionFilters;
using Microsoft.AspNetCore.Authorization; 



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCmovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCmovieContext") ?? throw new InvalidOperationException("Connection string 'MVCmovieContext' not found.")));


/*builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
});*/


/*builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<GlobalsampleactionFilter>();
});*/

/*builder.Services.AddControllers(config =>
{
    config.Filters.Add(new LogActionFilterExample());
});*/

builder.Services.AddScoped<LogActionFilter>();

builder.Services.AddControllers();

//builder.Services.AddScoped<Actionfilterexample>(); 

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

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

app.UseAuthentication();
app.UseAuthorization();



/*app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("First middleware");
    await next.Invoke();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Second Middleware");
});*/


// app.UseMiddleware();

//app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
