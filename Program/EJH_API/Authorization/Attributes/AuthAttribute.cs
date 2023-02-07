using DataBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace API.Authorization.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        List<Guid> _roles = new List<Guid>();
        public AuthorizeAttribute(params string[] roles)
        {
            foreach (var role in roles)
            {
                _roles.Add(Guid.Parse(role));
            }
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            var attributes = context.ActionDescriptor.EndpointMetadata.OfType<AuthorizeAttribute>();
            foreach (var a in attributes)
            {
                _roles.AddRange(a._roles);
            }
            _roles = _roles.Distinct().ToList();
            if (allowAnonymous)
                return;

            // authorization
            User user = (User)context.HttpContext.Items["User"];
            Guid[] roles = (Guid[])context.HttpContext.Items["Roles"];

            if (user == null)
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };

            if (roles != null)
            {
                if (_roles.Intersect(roles).Count() == 0)
                    context.Result = new JsonResult(new { message = "Permission denied" }) { StatusCode = StatusCodes.Status403Forbidden };
            }
        }
    }
}
