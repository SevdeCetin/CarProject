using CarProject.API.DTOs;
using CarProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProject.API.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IAracService _service;
        public NotFoundFilter(IAracService service)
        {
            _service = service;
        }
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = _service.GetAsync(id);
            if (product != null)
            {
                next();
            }
            else
            {
                ErrorDTO dTO = new ErrorDTO();
                dTO.StatusCode = 400;
                dTO.Error.Add($"{id} nolu veri bulunamadı.");
                context.Result = new NotFoundObjectResult(dTO);
            }
            return base.OnActionExecutionAsync(context, next);
        }
    }
}
