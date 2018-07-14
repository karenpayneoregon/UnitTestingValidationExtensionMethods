using Library.LanguageExtensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace ValidatorLibrary
{
    /// <summary>
    /// Ensure date is in current month
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class RecievedDateTimeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            var (FirstDayOfMonth, LastDayOfMonth) = DateTime.Now.FirstLastDayOfMonth();
            if (!Convert.ToDateTime(value).Between(FirstDayOfMonth, LastDayOfMonth))
            {
                return false;
            }

            return true;
        }
    }
}
