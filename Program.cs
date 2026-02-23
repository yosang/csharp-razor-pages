var builder = WebApplication.CreateBuilder();

builder.Services.AddRazorPages();

var app = builder.Build();

if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();
app.UseStaticFiles();
app.MapRazorPages();

app.Run();