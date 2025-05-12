using System.Reflection;
using MudBlazor;
using MudBlazor.Services;
using personalBlog.Api.Components;
using personalBlog.Api.DependenciInjection;
using personalBlog.DAta.DbContext;
using personalBlog.Logic;


var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();
builder.Services.AddMudMarkdownServices();
builder.Services.AddServices();

// La inyección por defecto sería la implementación "System", es decir, la que provee la hora actual del sistema
builder.Services.AddSingleton<TimeProvider>(TimeProvider.System);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

//builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssembly(typeof(AssemblyMarker).Assembly));

// 1. Registrar los controladores
builder.Services.AddControllers();

builder.Services.AddDbContext<BlogDbContext>();

var app = builder.Build();

// 2. Mapear controladores en la app
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(personalBlog.Web.Client._Imports).Assembly);

app.Run();