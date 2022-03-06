using FluentValidation.AspNetCore;
using HotelListing.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonApi;
using PersonApi.Configurations.Mapper;
using PersonApi.Datas;
using PersonApi.Repository;
using PersonApi.Repository.Repositories;
using PersonApi.Repository.Repositories.Implement;
using PersonApi.Repository.Repositories.Interfaces;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services;
using PersonApi.Services.AuthManager;
using PersonApi.Services.Interfaces;
using System.Globalization;
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
    dbContextOptions./*UseLazyLoadingProxies().*/UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));

});


builder.Services.AddAutoMapper(typeof(MapperInitilier));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillService, SkillService>();


builder.Services.AddScoped<ILearningRepository, LearningRepository>();
builder.Services.AddScoped<ILearningService, LearningService>();

builder.Services.AddScoped<IRelativeRepository, RelativeRepository>();
builder.Services.AddScoped<IRelativeService, RelativeService>();

builder.Services.AddScoped<ISalaryRepository, SalaryRepository>();
builder.Services.AddScoped<ISalaryService, SalaryService>();

builder.Services.AddScoped<IEmployeeSkillRepository, EmployeeSkillRepository>();
builder.Services.AddScoped<IEmployeeSkillService, EmployeeSkillService>();

builder.Services.AddScoped<IEmployeeLearningRepository, EmployeeLearningRepository>();
builder.Services.AddScoped<IEmployeeLearningService, EmployeeLearningService>();

builder.Services.AddScoped<IAuthManager, AuthManager>();


builder.Services.AddAuthentication();
builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.ConfigureIdentity();

builder.Services.AddControllers().AddNewtonsoftJson(op =>
op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("tr-TR");
//    options.SupportedCultures = new List<CultureInfo> { new CultureInfo("tr-TR") };
//});
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
//app.ConfigureExceptiontionHandler();

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
