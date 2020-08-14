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
    }
}