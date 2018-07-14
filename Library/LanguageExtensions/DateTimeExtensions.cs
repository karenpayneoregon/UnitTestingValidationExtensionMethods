using System;

namespace Library.LanguageExtensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Provides a date for first day and last day of month.
        /// </summary>
        /// <param name="now">Date to find first and last day of month</param>
        /// <returns>
        /// ValueTuple representing first and last dates of month for now.
        /// </returns>
        /// <remarks>
        /// endDate subtracts one second for use with database SQL operations.
        /// </remarks>
        public static (DateTime FirstDayOfMonth, DateTime LastDayOfMonth) FirstLastDayOfMonth(this DateTime now)
        {
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1).AddSeconds(-1);

            return (startDate, endDate);
        }
    }
}
