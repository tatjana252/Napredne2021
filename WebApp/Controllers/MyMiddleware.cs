using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            var u = httpContext.Session.Get("user");
            if(u != null)
            {
            //Person p = JsonSerializer.Deserialize<Person>(u);
            var claims = JsonSerializer.Deserialize < Dictionary<string, string>> (u, new JsonSerializerOptions { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve }).Select(e => new Claim(e.Key, e.Value));
                var identity = new ClaimsIdentity (claims);
            //ClaimsIdentity identity = new ClaimsIdentity();
            //identity.AddClaim(new Claim(ClaimTypes.Role, p.GetType().ToString()));
            //identity.AddClaim(new Claim(ClaimTypes.Name, p.Username));
            //identity.AddClaim(new Claim("id", p.PersonId.ToString()));
 
            httpContext.User.AddIdentity(identity); 

            }
       
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}
