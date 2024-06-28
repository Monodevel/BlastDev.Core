using BlastDev.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastDev.Core.Test.Helpers.Extensions
{
    public static class DataAnnotationsExtensions
    {
        public static IList<ValidationResult> Validate<TDto>(this TDto dto) where TDto : IDtoBase
        {
            var results = new List<ValidationResult>();

            var validationContext = new ValidationContext(dto, null, null);

            Validator.TryValidateObject(dto, validationContext, results, true);

            if (dto is IValidatableObject)
                (dto as IValidatableObject).Validate(validationContext);

            return results;
        }

    }
}
