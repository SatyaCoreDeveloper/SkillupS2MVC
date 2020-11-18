using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentEnrollment.App.Filters
{
    public class LogRequestFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var log = new
            {
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                ActionName = filterContext.ActionDescriptor.ActionName,
                DateTime = filterContext.HttpContext.Timestamp
            };
            Debug.WriteLine(JsonConvert.SerializeObject(log));                        
        }

    }
}