﻿// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
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
        /// Test method to check equal condition for feet value.
        /// </summary>
        [Test]
        public void GivenFeet_ShouldEqual()
        {
            double actualFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            Assert.AreEqual(0.0, actualFeetValue);
        }

        /// <summary>
        /// Test method to check not equal condition for feet value.
        /// </summary>
        [Test]
        public void GivenFeet_ShouldNotEqual()
        {
            double actualFeetValue = this.quantityMeasurement.GetFeetValue(1.0);
            Assert.AreNotEqual(0.0, actualFeetValue);
        }

        /// <summary>
        /// Test method to check zero feet equals zero feet.
        /// </summary>
        [Test]
        public void GivenTwoFeetValueAsZero_ShouldEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            double secondFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            Assert.AreEqual(firstFeetValue, secondFeetValue, 0.0);
        }

        /// <summary>
        /// Test method to check zero feet is not equal to five feet.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeet_ShouldNotEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetFeetValue(0.0);
            double secondFeetValue = this.quantityMeasurement.GetFeetValue(5.0);
            Assert.AreNotEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check equality of null value.
        /// </summary>
        [Test]
        public void GivenNullValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test method to check equality of reference.
        /// </summary>
        [Test]
        public void GivenReference_shouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        /// <summary>
        /// Test method to check equality of type.
        /// </summary>
        [Test]
        public void GivenType_shouldReturnTrue()
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
            double firstFeetValue = this.quantityMeasurement.GetFeetValue(12.0);
            double secondFeetValue = this.quantityMeasurement.GetFeetValue(12.0);
            Assert.AreEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check equal condition for inch value.
        /// </summary>
        [Test]
        public void GivenInch_ShouldEqual()
        {
            double actualInchValue = this.quantityMeasurement.GetInchValue(0.0);
            Assert.AreEqual(0.0, actualInchValue);
        }

        /// <summary>
        /// Test method to check not equal condition for inch value.
        /// </summary>
        [Test]
        public void GivenInch_ShouldNotEqual()
        {
            double actualInchValue = this.quantityMeasurement.GetInchValue(1.0);
            Assert.AreNotEqual(0.0, actualInchValue);
        }
    }
}