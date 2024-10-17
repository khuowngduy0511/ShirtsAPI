using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api.Filters
{
    public class Shirt_ValidateShirtIdFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var shirtId = context.ActionArguments["id"] as int?;

            if (shirtId.HasValue)
            {
                if (shirtId <= 0)
                {
                    context.ModelState.AddModelError("ShirtId", "ShirtId is invalid");
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);
                }
                else if(!ShirtRepository.ShirtExists(shirtId.Value))
                {
                    context.ModelState.AddModelError("ShirtId", "ShirtId doesn't exist");
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status404NotFound
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);
                }
            }
        }
    }
}