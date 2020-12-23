using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerProject.WEB.DTOs;
using NLayerProject.Core.Services;

namespace NLayerProject.WEB.Filters
{
    public class NotFoundFilter :ActionFilterAttribute
    {
        private readonly ICategoryService _categoryService;

        public NotFoundFilter(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async override Task OnActionExecutionAsync(ActionExecutingContext context,
            ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();

            var category = await _categoryService.GetByIdAsycn(id);

            if (category!=null)
            {
              await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
               
                errorDto.Errors.Add($"id'si {id} olan eleman veritabanında bulunamadı");
                context.Result = new RedirectToActionResult("Error","Home",errorDto);
            }

        }
    }
}
