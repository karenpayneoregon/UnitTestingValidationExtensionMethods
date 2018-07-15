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
        /// <summary>
        /// Retrives the first day of the month of the <paramref name="date"/>.
        /// </summary>
        /// <param name="date">A date from the month we want to get the first day.</param>
        /// <returns>A DateTime representing the first day of the month.</returns>
        public static DateTime FirstDayOfTheMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Retrives the last day of the month of the <paramref name="date"/>.
        /// </summary>
        /// <param name="date">A date from the month we want to get the last day.</param>
        /// <returns>A DateTime representing the last day of the month.</returns>
        public static DateTime LastDayOfTheMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month)).AddSeconds(-1);
        }
    }
}
