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
    class TimeValidation : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;

                if (Regex.IsMatch(s, @"[0-2][0-9][:][0-5][0-9]$"))
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, "Not Valid Time Format");
                }
            }
            catch
            {
                return new ValidationResult(false, "Exception");
            }
        }

    }
}
