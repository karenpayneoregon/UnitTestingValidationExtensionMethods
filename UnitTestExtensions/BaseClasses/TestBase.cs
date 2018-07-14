using System;
using UnitTestExtensions.Test;

namespace UnitTestExtensions.BaseClasses
{
    public abstract class TestBase
    {
        /// <summary>
        /// Provides values for unit test <see cref="ExtensionsTest.BetweenIntRange"></see>.
        /// </summary>
        /// <returns></returns>
        public (int StartRange, int EndRange, int Value) IntItems()
        {
            return (-999, 999, -999);
        }
        public (double StartRange, Double EndRange, Double Value) DoubleItems()
        {
            return (-999, 999, -999);
        }
        /// <summary>
        /// Provides two dates used for obtaining first and last day of month.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// By returning dates rather than days makes this method flexible for 
        /// <see cref="ExtensionsTest.BetweenDateRangeFromTestBase"></see> other date 
        /// related routines.
        /// </remarks>
        public (DateTime StartRange, DateTime EndRange, DateTime Value) DateTimeItems()
        {
            var now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1).AddSeconds(-1);

            return (
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, startDate.Day), 
                new DateTime(DateTime.Now.Year,  DateTime.Now.Month, endDate.Day), 
                new DateTime(DateTime.Now.Year,  DateTime.Now.Month, DateTime.Now.Day)
            );
        }
    }

}
