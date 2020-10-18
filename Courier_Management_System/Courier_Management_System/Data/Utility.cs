using System;
using Microsoft.AspNetCore.Http;

namespace Courier_Management_System.Data
{
    public class Utility
    {
        IHttpContextAccessor _accessor;
        public Utility(IHttpContextAccessor accessor)
        {
            this._accessor = accessor;
        }

        public Boolean IsAuthorisedClient()
        {
            Console.WriteLine(this._accessor.HttpContext.Session.GetString("logged_in_user") + ":" + this._accessor.HttpContext.Session.GetString("user_role"));
            if(this._accessor.HttpContext.Session.GetString("logged_in_user")!=null && this._accessor.HttpContext.Session.GetString("user_role")=="client")
            {
                return true;
            }
            return false;
        }
        public Boolean IsAuthorisedEmployee()
        {
            if (this._accessor.HttpContext.Session.GetString("logged_in_user") != null && this._accessor.HttpContext.Session.GetString("user_role") == "employee")
            {
                return true;
            }
            return false;
        }
    }
}
