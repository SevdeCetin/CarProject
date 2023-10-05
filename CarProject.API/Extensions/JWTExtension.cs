using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProject.API.Extensions
{
    public static class JWTExtension
    {
        public static void ApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
        }
    }
}
