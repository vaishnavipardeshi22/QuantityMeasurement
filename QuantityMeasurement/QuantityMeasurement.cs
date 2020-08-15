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
        /// Function to get feet value.
        /// </summary>
        /// <param name="unitValue"></param>
        /// <returns></returns>
        public double GetUnitValue(double unitValue)
        {
            return unitValue;
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
