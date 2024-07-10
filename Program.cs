using MacoriStars.BLL;
using MacoriStars.Components;
using MacoriStars.DAL;
using MacoriStars.Dtos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<Contexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

builder.Services.AddTransient<ICategoriasServices, CategoriasService>();
builder.Services.AddTransient<IEstablecimientosService, EstablecimientosService>();
builder.Services.AddTransient<IUsuariosService, UsuariosService>();
builder.Services.AddTransient<IResenasService, ResenasService>();
builder.Services.AddTransient<ICalificacionesService, CalificacionesService>();
builder.Services.AddScoped<SesionDto>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
