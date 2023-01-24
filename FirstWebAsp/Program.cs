
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
               
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.Run(async (context) => await context.Response.WriteAsync("Name: Natyazhenko Vladimir" + "\n" + $"DATE: {DateTime.Now}" + "\n" + $"Environment: {app.Environment.EnvironmentName}" + "\n" +
        //$"ApplicationName: {app.Environment.ApplicationName}" + "\n" + $"Host: {context.Request.Host}" + "\n" + $"Protocol: {context.Request.Protocol}"));


        app.Run(async (context) =>
        {
            var response = context.Response;
            response.ContentType = "text/html; charset=utf-8";
            await response.WriteAsync("<h2>Name:</h2><h3>Natyazhenko Vladimir</h3>" + $"<h2>DATE:</h2><h3>{DateTime.Now}</h3>" 
                + $"<h2>Environment:</h2><h3>{app.Environment.EnvironmentName}</h3>"
                + $"<h2>ApplicationName:</h2><h3>{app.Environment.ApplicationName}</h3>" 
                + $"<h2>Host:</h2><h3>{context.Request.Host}</h3>"
                + $"<h2>Protocol:</h2><h3>{context.Request.Protocol}</h3>");
        });

        //app.Run(async (context) => await context.Response.WriteAsync("Name: " + "\n" + $"DATE: {DateTime.Now}" + "\n" + $"Environment: {app.Environment.EnvironmentName}" + "\n" +
        //$"ApplicationName: {app.Environment.ApplicationName}" + "\n" + $"Host: {context.Request.Host}" + "\n" + $"Protocol: {context.Request.Protocol}"));


        //app.MapGet("/", (context) => "Name: Natyazhenko Vladimir" + "\n" + $"DATE: {DateTime.Now.ToString()}" + "\n" + $"Environment: {app.Environment.EnvironmentName}" + "\n" +
        //$"ApplicationName: {app.Environment.ApplicationName}" + "\n" + $"Host: {context.Request.Host}");
        app.Run();
    }
}