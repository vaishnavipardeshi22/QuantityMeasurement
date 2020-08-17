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
            double firstFeetValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.FEET);
            double secondFeetValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.FEET);
            Assert.AreEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check zero feet is not equal to five feet.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeet_ShouldNotEqual()
        {
            double firstFeetValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.FEET);
            double secondFeetValue = this.quantityMeasurement.GetConvertUnitValue(5.0, Unit.UnitType.FEET);
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
            double firstFeetValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Unit.UnitType.FEET);
            double secondFeetValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Unit.UnitType.FEET);
            Assert.AreEqual(firstFeetValue, secondFeetValue);
        }

        /// <summary>
        /// Test method to check zero inch equals zero inch.
        /// </summary>
        [Test]
        public void GivenTwoInchValueAsZero_ShouldEqual()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.INCH);
            Assert.AreEqual(firstInchValue, secondInchValue);
        }

        /// <summary>
        /// Test method to check zero inch is not equal to five inch.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInch_ShouldNotEqual()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(5.0, Unit.UnitType.INCH);
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
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Unit.UnitType.INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(12.0, Unit.UnitType.INCH);
            Assert.AreEqual(firstInchValue, secondInchValue);
        }

        /// <summary>
        /// Test method to check one feet equals to twelve inch.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToInch_ShouldReturnEqual()
        {
            double actualInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_INCH);
            Assert.AreEqual(12.0, actualInchValue);
        }

        /// <summary>
        /// Test method to check three feet equals to one yard.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToYard_ShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(3.0, Unit.UnitType.FEET_TO_YARD);
            Assert.AreEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one feet is not equals to one yard.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToYard_ShouldReturnNotEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_YARD);
            Assert.AreNotEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one inch is not equal to one yard.
        /// </summary>
        [Test]
        public void GivenInchValueConvertToYard_ShouldReturnNotEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.INCH_TO_YARD);
            Assert.AreNotEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one yard is not equal to thirty six inch.
        /// </summary>
        [Test]
        public void GivenYardValueConvertToInch_ShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.YARD_TO_INCH);
            Assert.AreEqual(36.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check thirty six inch is equal to one yard.
        /// </summary>
        [Test]
        public void GivenInchValueConvertToYard_ShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(36.0, Unit.UnitType.INCH_TO_YARD);
            Assert.AreEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one yard is equal to three feet.
        /// </summary>
        [Test]
        public void GivenYardValueConvertToFeet_ShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.YARD_TO_FEET);
            Assert.AreEqual(3.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check two inch is equal to five centimeter.
        /// </summary>
        [Test]
        public void GivenInchValueToConvertToCentimeter_ShouldReturnEqual()
        {
            double actualCentimeterValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH_TO_CENTIMETER);
            Assert.AreEqual(5.0, actualCentimeterValue);
        }

        /// <summary>
        /// Test method to check one inch is not equal to one centimeter.
        /// </summary>
        [Test]
        public void GivenInchValueToConvertToCentimeter_ShouldReturnNotEqual()
        {
            double actualCentimeterValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.INCH_TO_CENTIMETER);
            Assert.AreNotEqual(1.0, actualCentimeterValue);
        }

        /// <summary>
        /// Test method to check two inch plus two inch equal to four inch.
        /// </summary>
        [Test]
        public void GivenTwoInchLength_WhenAdd_ThenReturnResult()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH);
            double addition = this.quantityMeasurement.GetAddition(firstInchValue, secondInchValue);
            Assert.AreEqual(4.0, addition);
        }

        /// <summary>
        /// Test method to check one feet plus two inch equal to fourteen inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInchValue_WhenAdd_ReturnResultInInch()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH);
            double addition = this.quantityMeasurement.GetAddition(firstInchValue, secondInchValue);
            Assert.AreEqual(14.0, addition);
        }

        /// <summary>
        /// Test method to check one feet plus one feet equal to twenty four inch.
        /// </summary>
        [Test]
        public void GivenTwoFeetLength_WhenAdd_ThenReturnResultInInch()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_INCH);
            double addition = this.quantityMeasurement.GetAddition(firstInchValue, secondInchValue);
            Assert.AreEqual(24.0, addition);
        }

        /// <summary>
        /// Test method to check two inch plus two point five centimeter equal to three inch.
        /// </summary>
        [Test]
        public void GivenLengthInInchAndCentimeter_WhenAdd_ThenReturnResultInInch()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(2.5, Unit.UnitType.CENTIMETER_TO_INCH);
            double addition = this.quantityMeasurement.GetAddition(firstInchValue, secondInchValue);
            Assert.AreEqual(3.0, addition);
        }

        /// <summary>
        /// Test method to check one gallon equals to three point seven eight litre.
        /// </summary>
        [Test]
        public void GivenOneGallonVolumeConvertToLitres_ShouldReturnEquals()
        {
            double actualVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.GALLON_TO_LITRES);
            Assert.AreEqual(3.78, actualVolume);
        }

        /// <summary>
        /// Test method to check one litre equals to thousand millilitre.
        /// </summary>
        [Test]
        public void GivenOneLitreVolumeConvertToMilliLitre_ShouldReturnEqual()
        {
            double actualVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.LITRE_TO_MILLILITRE);
            Assert.AreEqual(1000.0, actualVolume);
        }

        /// <summary>
        /// Test method to check addition of one gallon and three point seven eight litres equal to seven point five seven litres.
        /// </summary>
        [Test]
        public void GivenOneGallonAndOneLitreValue_WhenAdd_ShouldReturnResultInLitres()
        {
            double firstVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.GALLON_TO_LITRES);
            double secondVolume = this.quantityMeasurement.GetConvertUnitValue(3.785, Unit.UnitType.LITRE);
            double addition = this.quantityMeasurement.GetAddition(firstVolume, secondVolume);
            Assert.AreEqual(7.57, addition, 0.1);
        }

        /// <summary>
        /// Test method to check addition of one litre and thousand millilitres equal to two litres.
        /// </summary>
        [Test]
        public void GivenOneLitreAndOneMillilitreValue_WhenAdd_ShouldReturnResultInLitres()
        {
            double firstVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.LITRE);
            double secondVolume = this.quantityMeasurement.GetConvertUnitValue(1000.0, Unit.UnitType.MILLILITRE_TO_LITRE);
            double addition = this.quantityMeasurement.GetAddition(firstVolume, secondVolume);
            Assert.AreEqual(2.0, addition);
        }
    }
}