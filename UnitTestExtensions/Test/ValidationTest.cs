using System;
using BusnessEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidatorLibrary;

namespace UnitTestExtensions.Test
{
    [TestClass]
    public class ValidationTest
    {
        /// <summary>
        /// Given a RecievedDateTime not in the current month validates.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Validating)]
        public void IsValidatePayment()
        {
            // arrange
            var payment = new Payment { RecievedDateTime = DateTime.Now };

            // act
            var validationResult = ValidationHelper.ValidateEntity(payment);

            // assert
            Assert.IsFalse(validationResult.HasError,
                "Expected a validate payment");

        }

        /// <summary>
        /// Given a RecievedDateTime not in the current month validation fails.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Validating)]
        public void IsNotValidatePayment()
        {
            // arrange
            var payment = new Payment { RecievedDateTime = DateTime.Now.AddMonths(-1) };

            // act
            var validationResult = ValidationHelper.ValidateEntity(payment);

            // assert
            Assert.IsTrue(validationResult.HasError,
                "Expected a invalidate payment");

        }
    }
}
