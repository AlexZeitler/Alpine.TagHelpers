using Alpine.TagHelpers.Samples;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
  .AddRazorRuntimeCompilation();

builder.Services.Configure<RazorViewEngineOptions>(
  o => o.ViewLocationExpanders.Add(new FeatureFolderLocationExpander())
);

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
  name: "default",
  pattern: "{controller=GetHome}/{action=GetHome}/{id?}"
);

app.Run();
