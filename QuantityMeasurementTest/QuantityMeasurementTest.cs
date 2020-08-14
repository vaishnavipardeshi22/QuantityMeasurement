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
        private QuantityMeasurement quantityMeasurement;

        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        [Test]
        public void GivenFeet_ShouldEqual()
        {
            double actualFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            Assert.AreEqual(0.0, actualFeetValue);
        }

        [Test]
        public void GivenFeet_ShouldNotEqual()
        {
            double actualFeetValue = this.quantityMeasurement.GetFeetValue(1.0);
            Assert.AreNotEqual(0.0, actualFeetValue);
        }

        [Test]
        public void GivenTwoFeetValueAsZero_ShouldEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            double secondFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            Assert.AreEqual(firstFeetValue, secondFeetValue, 0.0);
        }

        [Test]
        public void GivenTwoDifferentFeet_ShouldNotEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            double secondFeetValue = this.quantityMeasurement.GetFeetValue(1.0);
            Assert.AreNotEqual(firstFeetValue, secondFeetValue);
        }

        [Test]
        public void GivenNullValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        [Test]
        public void GivenReference_shouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        [Test]
        public void GivenType_shouldReturnTrue()
        {
            QuantityMeasurement firstQuantity = new QuantityMeasurement();
            QuantityMeasurement secondQuantity = new QuantityMeasurement();
            Assert.AreEqual(firstQuantity, secondQuantity);
        }

        [Test]
        public void GivenTwoSameFeet_ShouldEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetFeetValue(12.0);
            double secondFeetValue = this.quantityMeasurement.GetFeetValue(12.0);
            Assert.AreEqual(firstFeetValue, secondFeetValue);
        }
    }
}