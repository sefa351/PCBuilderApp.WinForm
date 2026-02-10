using Microsoft.EntityFrameworkCore;
using PCBuilder.App.Components;
using PCBuilder.Business;
using PCBuilder.DataAccess;         
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PCBuilderContext>(options =>
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PCBuilderDB;Trusted_Connection=True;"));

builder.Services.AddScoped<PCBuilder.Business.ProductService>();
builder.Services.AddScoped<SystemTransferService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PCBuilderContext>();
    context.Database.EnsureCreated(); 
    DbSeeder.Seed(context);           
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();