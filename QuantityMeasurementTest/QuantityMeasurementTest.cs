// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// Class to test quantity measurement.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Creating object for main class.
        /// </summary>
        private QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// Set up method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        /// <summary>
        /// Test method to check zero feet equals zero feet.
        /// </summary>
        [Test]
        public void GivenTwoFeetValueAsZero_ShouldEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.FEET_TO_INCH);
            double secondFeetValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.FEET_TO_INCH);
            Assert.AreEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check zero feet is not equal to five feet.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeet_ShouldNotEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.FEET_TO_INCH);
            double secondFeetValue = this.quantityMeasurement.GetConvertUnitValue(5.0, Length.LengthUnit.FEET_TO_INCH);
            Assert.AreNotEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check equality of null feet value.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test method to check equality of feet reference.
        /// </summary>
        [Test]
        public void GivenFeetReference_shouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        /// <summary>
        /// Test method to check equality of type.
        /// </summary>
        [Test]
        public void GivenFeetType_shouldReturnTrue()
        {
            QuantityMeasurement firstQuantity = new QuantityMeasurement();
            QuantityMeasurement secondQuantity = new QuantityMeasurement();
            Assert.AreEqual(firstQuantity, secondQuantity);
        }

        /// <summary>
        /// Test method to check equality of value.
        /// </summary>
        [Test]
        public void GivenTwoSameFeet_ShouldEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Length.LengthUnit.FEET_TO_INCH);
            double secondFeetValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Length.LengthUnit.FEET_TO_INCH);
            Assert.AreEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check zero inch equals zero inch.
        /// </summary>
        [Test]
        public void GivenTwoInchValueAsZero_ShouldEqual()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.INCH_TO_FEET);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.INCH_TO_FEET);
            Assert.AreEqual(firstInchValue, secondInchValue);
        }

        /// <summary>
        /// Test method to check zero inch is not equal to five inch.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInch_ShouldNotEqual()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.INCH_TO_FEET);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(5.0, Length.LengthUnit.INCH_TO_FEET);
            Assert.AreNotEqual(firstInchValue, secondInchValue);
        }

        /// <summary>
        /// Test method to check equality of null inch value.
        /// </summary>
        [Test]
        public void GivenNullInchValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test method to check equality of inch reference.
        /// </summary>
        [Test]
        public void GivenInchReference_shouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        /// <summary>
        /// Test method to check equality of type.
        /// </summary>
        [Test]
        public void GivenInchType_shouldReturnTrue()
        {
            QuantityMeasurement firstQuantity = new QuantityMeasurement();
            QuantityMeasurement secondQuantity = new QuantityMeasurement();
            Assert.AreEqual(firstQuantity, secondQuantity);
        }

        /// <summary>
        /// Test method to check equality of value.
        /// </summary>
        [Test]
        public void GivenTwoSameInch_ShouldEqual()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Length.LengthUnit.INCH_TO_FEET);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Length.LengthUnit.INCH_TO_FEET);
            Assert.AreEqual(firstInchValue, secondInchValue);
        }

        /// <summary>
        /// Test method to check one feet equals to twelve inch.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToInch_ShouldReturnEqual()
        {
            double actualInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Length.LengthUnit.FEET_TO_INCH);
            Assert.AreEqual(12.0, actualInchValue);
        }

        /// <summary>
        /// Test method to check three feet equals to one yard.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToYard_ShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(3.0, Length.LengthUnit.FEET_TO_YARD);
            Assert.AreEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one feet is not equals to one yard.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToYard_ShouldReturnNotEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Length.LengthUnit.FEET_TO_YARD);
            Assert.AreNotEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one inch is not equal to one yard.
        /// </summary>
        [Test]
        public void GivenInchValueConvertToYard_ShouldReturnNotEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Length.LengthUnit.INCH_TO_YARD);
            Assert.AreNotEqual(1.0, actualYardValue);
        }
    }
}