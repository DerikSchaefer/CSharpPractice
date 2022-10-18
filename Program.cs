using EmpManagementSystem.Models;
using EmpManagementSystem.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 4. register services
//builder.Services.AddSingleton<ICRUD, CRUDRepository>(); // in memory list
builder.Services.AddScoped<ICRUD, DBCRUDRepository>(); // register of services for db
builder.Services.AddSingleton<IFormatNumber, FormatClass>();
builder.Services.AddScoped<IFileUploadService, FileUploadService>();
//builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlite("Data Source=Employeesdb.db"));
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<UserContext>();

// shane , alex
//builder.Services.AddDbContext<UserContext>(options => options.UseSqlite("Data Source=Users.db"));


// sql server
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer("Server=LAPTOP-76KFFC21;Database=PCAD7Users;Trusted_Connection=true;MultipleActiveResultSets=True"));
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer("Server=LAPTOP-76KFFC21;Database=PCAD7MVCEmp;Trusted_Connection=true;MultipleActiveResultSets=True"));

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
if(app.Environment.IsStaging())
{
    app.UseExceptionHandler("Home/StagingError");
}
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<EmployeeContext>();
    dbContext.Database.EnsureCreated(); // create db if not there
    var userdbContext = scope.ServiceProvider.GetRequiredService<UserContext>();
    userdbContext.Database.EnsureCreated(); // create db if not there


    // use context
}


//app.Services.AddDbContext<EmployeeContext>(options => options.UseSqlite("Employees.db"));
app.UseStaticFiles();


app.UseRouting(); //1

app.UseAuthentication();
app.UseAuthorization(); // user has rights
 // checking the right (correct ) user
 
//2
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{name?}");

app.Run();


