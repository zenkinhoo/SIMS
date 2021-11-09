using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Bolnica.View.Validation
{
    class NumbersValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;

                if (Regex.IsMatch(s, @"[1-5]$"))
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, "You must enter rating 1-5");
                }
            }
            catch
            {
                return new ValidationResult(false, "Exception");
            }
        }
    }
}
