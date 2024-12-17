using _11.week_GalacticTour_03.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _11.week_GalacticTour_03.ModelBindings
{
    public class GalacticCoordinateBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName).FirstValue;

            if(string.IsNullOrWhiteSpace(value))
            {
                return Task.CompletedTask;
            }

            //12.36,32.56

            var parts = value.Split(',');
            if(parts.Length != 2 || double.TryParse(parts[0], out double x) || !double.TryParse(parts[1], out double y)) )
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "geçersiz koordinat bilgisi,'x.xx,y.yy' formatınıu kullanmalısın");

                return Task.CompletedTask;
            }

            var result = new GalacticCordinate
            {
                X = x,
                Y = y
            };

            bindingContext.Result = ModelBindingResult.Success(result);

            return Task.CompletedTask;


        }
    }
}
