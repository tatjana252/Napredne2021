using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Security.Claims;

namespace WebApp.Controllers
{
    public class LoggedIn : ActionFilterAttribute

    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(!context.HttpContext.User.Claims.Any(c => c.Type == ClaimTypes.Role && c.Value== typeof(Teacher).ToString()))
            {
                context.HttpContext.Response.Redirect("/");
                return;
            }
            Controller controller = (Controller)context.Controller;
            controller.ViewBag.IsLoggedIn = true;
        }
    }
}
