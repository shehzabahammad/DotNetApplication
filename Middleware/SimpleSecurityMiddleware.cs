using Microsoft.AspNetCore.Http

namespace SimpleApi.Middleware

public class SimpleSecurityMiddleware
{
    private readonly RequestDelegate _next;

    public SimpleSecurityMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path;
        if(path.StartsWithSegments("/api/products"))
        {
           var apiKey= context.Request.Headers["X-API-KEY"].FirstOrDefault();

           if(apikey != "12345")
           {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
                return;
           }


        }
        
        // Call the next middleware in the pipeline
        await _next(context);
    }
}