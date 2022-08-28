var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);

});
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

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Doctor",
    pattern: "{controller=DoctorController}/{action=CheckTemprature}/{id?}");


app.MapControllerRoute(
    name: "GuessingGame",
    pattern: "{controller=GuessingGame}/{action=GuessGame}/{id?}");


app.Run();
