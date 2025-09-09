var builder = WebApplication.CreateBuilder(args); // Creates the web application builder

// Add services to the container.
builder.Services.AddControllersWithViews(); 

var app = builder.Build(); // Builds the application

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) // Checks if not in development environment
{
    app.UseExceptionHandler("/Home/Error"); // Uses custom error handler
    app.UseHsts(); // Enables HTTP Strict Transport Security
}

app.UseHttpsRedirection(); // Redirects HTTP requests to HTTPS
app.UseStaticFiles(); 

app.UseRouting(); // Adds routing middleware

app.UseAuthorization(); // Adds authorization middleware

app.MapControllerRoute( // Configures default route
    name: "default", // Route name
    pattern: "{controller=Home}/{action=Index}/{id?}"); 

app.Run(); // Runs the application