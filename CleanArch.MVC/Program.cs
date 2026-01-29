using CleanArch.Infra.Data.Context;
using CleanArch.Infra.IoC;
using CleanArch.MVC.MappingConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container
// Chama o método de extensão que registra DbContext, Identity, RazorPages e outras infraestruturas
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAutoMapperConfiguration();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Opcional: tentar aplicar migrations automaticamente e logar erros
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate(); // aplica migrations pendentes
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Ocorreu um erro na migração ou alimentação dos dados.");
    }
}

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();
