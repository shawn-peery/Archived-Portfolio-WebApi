using Microsoft.Identity.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);



builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration)
        .EnableTokenAcquisitionToCallDownstreamApi()
            .AddMicrosoftGraph(builder.Configuration.GetSection("DownstreamApi"))
            .AddInMemoryTokenCaches();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

if (!app.Environment.IsDevelopment())
{
    // Recommended to use UseHsts after UseHttpsRedirection. https://learn.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-7.0&viewFallbackFrom=aspnetcore-2.1&tabs=visual-studio%2Clinux-ubuntu
    app.UseHsts();
}

app.UseCors(builder =>
{
    builder.WithOrigins("http://127.0.0.1:8000").AllowAnyHeader().AllowAnyMethod();

});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Hrome}/{action=Get}/{id?}");


app.MapControllers();


app.Run();
