using System;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Courier_Management_System.Filter
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly string[] allowedroles;
        public CustomAuthorizeAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }

        protected virtual bool AuthorizeCore(HttpContext context)
        {
            String user_role=context.Session.GetString("user_role");
            if (user_role!=null)
            {
                foreach (String role in allowedroles)
                {
                    if(role==user_role)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        protected virtual void HandleUnauthorizedRequest(AuthorizationHandlerContext filterContext)
        {
            if(filterContext.Resource is AuthorizationFilterContext redirectContext)
            {
                redirectContext.Result= new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    { "controller", "Home" },
                    { "action", "Index" }
                });
            }
        }
    }
}
