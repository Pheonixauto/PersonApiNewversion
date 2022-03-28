using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using PersonApi;
using PersonApi.Configurations.Mapper;
using PersonApi.Datas;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          builder =>
                          {
                              builder.WithOrigins("http://example.com",
                                                  "http://www.contoso.com")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

// Add services to the container.

builder.Services.AddControllers()
                 .AddFluentValidation(options =>
                 {
                     // Validate child properties and root collection elements
                     options.ImplicitlyValidateChildProperties = true;
                     options.ImplicitlyValidateRootCollectionElements = true;
                     // Automatic registration of validators in assembly
                     options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                 });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DatabaseContext>(dbContextOptions =>
{
    dbContextOptions.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));

});
builder.Services.AddAutoMapper(typeof(MapperInitilier));

builder.Services.ConfigServiceDependencyInject();


builder.Services.AddResponseCaching();
builder.Services.ConfigureHttpCacheHeaders();

builder.Services.AddAuthentication();
builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.ConfigureIdentity();

builder.Services.ConfigureVersioning();

builder.Services.AddControllers(cf =>
{
    cf.CacheProfiles.Add("120SecondsDuration", new CacheProfile
    {
        Duration = 120
    });
}
               ).AddNewtonsoftJson(op =>
op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddHttpClient();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential 
    // cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;
    // requires using Microsoft.AspNetCore.Http;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Person Api Manager");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.WebRootPath, "FileImageEmployees")),
    RequestPath = "/Images"

});
//app.ConfigureExceptiontionHandler();

app.UseResponseCaching();
app.UseHttpCacheHeaders();

app.UseCookiePolicy();

app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllers();
});
app.MapControllers();

app.Run();
