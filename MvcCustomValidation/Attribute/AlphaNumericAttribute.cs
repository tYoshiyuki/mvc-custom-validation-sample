using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MvcCustomValidation.Attribute
{
    public class AlphaNumericAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Regex.IsMatch(value?.ToString(), @"[^a-zA-z0-9]"))
            {
                return new ValidationResult(this.ErrorMessage ?? $"{ validationContext.DisplayName }は英数字で入力してください。");
            }

            return ValidationResult.Success;
        }
    }
}