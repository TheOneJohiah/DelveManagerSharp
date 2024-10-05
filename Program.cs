using DelveManagerSharp;
using System;

namespace DelveManagerSharp{
    class Program{
        static void Main(string[] args){

            Awakened sample = new Awakened("John", "Test");
            Console.WriteLine($"Name: {sample.Nameable.Name}");
            Console.WriteLine($"Description: {sample.Nameable.Description}");


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error", createScopeForErrors: true);
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<DelveManagerSharp.Components.App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }

        
    }
}


