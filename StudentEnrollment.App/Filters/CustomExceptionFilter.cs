using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentEnrollment.App.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;
            var log = new
            {
                RequestURI = filterContext.HttpContext.Request.Url,
                ExceptionMessage = filterContext.Exception.Message,
                DateTime = filterContext.HttpContext.Timestamp
            };
            Debug.WriteLine(JsonConvert.SerializeObject(log));
            filterContext.ExceptionHandled = true;

        }
    }
}