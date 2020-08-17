// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Main class to convert quantity.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// Function to get converted unit value.
        /// </summary>
        /// <param name="unitValue"></param>
        /// <param name="unitType"></param>
        /// <returns></returns>
        public double GetConvertUnitValue(double unitValue, Unit.UnitType unitType)
        {
            if (unitType.Equals(Unit.UnitType.CELSIUS))
            {
                return (unitValue * 9.0 / 5.0) + 32;
            }

            return unitValue * new Unit().GetValue(unitType);
        }

        /// <summary>
        /// Function to add two unit values.
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double GetAddition(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        /// <summary>
        /// Override equals method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (this.GetType().Equals(obj.GetType()))
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Override Get hash code method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
