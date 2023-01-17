var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "emp",
    pattern: "Employee/delete/{ssn}",
    defaults: new { controller = "Employee", action = "delete" }
 );
 app.MapControllerRoute(
    name: "emp1",
    pattern: "Employee/update/{eid}",
    defaults: new { controller = "Employee", action = "update" }
 );
  app.MapControllerRoute(
    name: "emp11",
    pattern: "Employee/find/{eidd}",
    defaults: new { controller = "Employee", action = "find" }
 );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
