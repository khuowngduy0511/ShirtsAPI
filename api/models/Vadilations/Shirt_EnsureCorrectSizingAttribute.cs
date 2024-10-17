using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.models.Vadilations
{
    public class Shirt_EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender)){
                if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
                {
                    return new ValidationResult("For Men's shirts, the size has to be greater or equal to 8.");
                }
                else if(shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6) 
                {
                    return new ValidationResult("For women's shirts, the size has to be greater or equal to6.");
                }
            }

            return ValidationResult.Success;
        }
    }
}