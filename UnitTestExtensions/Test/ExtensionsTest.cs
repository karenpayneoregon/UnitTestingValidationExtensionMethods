using System;
using BusnessEntities;
using Library.LanguageExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExtensions.BaseClasses;
using ValidatorLibrary;
#pragma warning disable 1574

namespace UnitTestExtensions.Test
{
    [TestClass]
    public class ExtensionsTest : TestBase
    {
        /// <summary>
        /// Validate <see cref="GeneralExtensions.Between"></see> extension 
        /// method functions with date time where value is between start and end 
        /// datetime values.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IComparableExtensionMethods)]
        public void BetweenDateRangeFromTestBase()
        {
            // arrange 
            var (StartRange, EndRange, Value) = DateTimeItems();

            // act assert
            Assert.IsTrue(Value.Between(StartRange, EndRange),
                $"Expected {Value} to be in range {StartRange} to {EndRange}");
        }
        /// <summary>
        /// Validate <see cref="GeneralExtensions.Between"></see> extension 
        /// method functions with date time where value is between start 
        /// and end datetime values.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IComparableExtensionMethods)]
        public void BetweenDateRangeFromLibrary()
        {
            // arrange 
            var (FirstDayOfMonth, LastDayOfMonth) = DateTime.Now.FirstLastDayOfMonth();
            var today = DateTime.Now;

            // act assert
            Assert.IsTrue(today.Between(FirstDayOfMonth, LastDayOfMonth),
                $"Expected {today} to be in range {FirstDayOfMonth} to {LastDayOfMonth}");
        }

        /// <summary>
        /// Validate <see cref="GeneralExtensions.Between"></see> extension 
        /// method functions with int where value is between start and end int values
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IComparableExtensionMethods)]
        public void BetweenIntRange()
        {
            // arrange, act assert
            var (StartRange, EndRange, Value) = IntItems();

            Assert.IsTrue(Value.Between(StartRange, EndRange),
                "Expectred testValue to be in range");

            // arrange
            Value += StartRange;

            // assert
            Assert.IsFalse(Value.Between(StartRange, EndRange),
                "Expectred testValue to be in range");

        }
        /// <summary>
        /// Validate <see cref="GeneralExtensions.Between"></see> extension 
        /// method functions with double where value is between start and end double values
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IComparableExtensionMethods)]
        public void BetweenDoubleRange() 
        {
            // arrange, act assert
            var (StartRange, EndRange, Value) = DoubleItems();

            Assert.IsTrue(Value.Between(StartRange, EndRange),
                "Expectred testValue to be in range");

            // arrange
            Value += StartRange;

            // assert
            Assert.IsFalse(Value.Between(StartRange, EndRange),
                "Expectred testValue to be in range");

        }
        /// <summary>
        /// Given a range of -999 to 999 when asserting against 
        /// <see cref="GeneralExtensions.Between"></see> if value is in range 
        /// then I expect Assert.IsFalse to be true.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IComparableExtensionMethods)]
        public void BetweenIntRangeOutOfRange()
        {
            // arrange
            int startRange = -999;
            int endRange = 999;
            int value = -1001;

            // act
            Assert.IsFalse(value.Between(startRange, endRange),
                "Expected testValue to be out of range");
        }
        /// <summary>
        /// Validate <see cref="DateTimeExtensions.FirstLastDayOfMonth"></see> extension.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.DateTimeExtensionMethods)]
        public void FirstLastDayOfMonth()
        {
            // arrange
            var today = DateTime.Now;
            var startDate = new DateTime(today.Year, today.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1).AddSeconds(-1);

            // act
            var (FirstDayOfMonth, LastDayOfMonth) = DateTime.Now.FirstLastDayOfMonth();

            // assert
            Assert.IsTrue(startDate.Equals(FirstDayOfMonth),
                "Expected start dates to match.");

            Assert.IsTrue(endDate.Equals(LastDayOfMonth),
                "Expected end dates to match.");

        }

    }
}
