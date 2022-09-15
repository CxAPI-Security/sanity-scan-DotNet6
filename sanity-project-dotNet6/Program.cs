using sanity_project_csharp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<IUserService, UserService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

/*TODO: not supported yet- This will not be detected by SAST
app.MapControllerRoute(
    name: "default",
    pattern: "api/{controller=Teacher}/{action=Index}/{id?}");
*/

//app.UseRouting();

// TODO: not supported yet- This will not be detected by SAST
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "api/{controller=Teacher}/{action=Index}/{id?}");
//});

// TODO: not supported yet- This will not be detected by SAST
//app.MapGet("/", () => "Hello World!");

app.Run();

