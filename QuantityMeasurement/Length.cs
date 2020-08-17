﻿namespace QuantityMeasurementProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Length
    {
        /// <summary>
        /// Enum For length unit.
        /// </summary>
        public enum LengthUnit
        {
            /// <summary>
            /// Enum for feet unit type.
            /// </summary>
            FEET,

            /// <summary>
            /// Enum for inch unit type.
            /// </summary>
            INCH,

            /// <summary>
            /// Enum for feet to inch conversion.
            /// </summary>
            FEET_TO_INCH,

            /// <summary>
            /// Enum for inch to feet conversion.
            /// </summary>
            INCH_TO_FEET,

            /// <summary>
            /// Enum for feet to yard conversion.
            /// </summary>
            FEET_TO_YARD,

            /// <summary>
            /// Enum for inch to yard conversion.
            /// </summary>
            INCH_TO_YARD,

            /// <summary>
            /// Enum for yard to inch conversion.
            /// </summary>
            YARD_TO_INCH,

            /// <summary>
            /// Enum for yard to feet conversion.
            /// </summary>
            YARD_TO_FEET,

            /// <summary>
            /// Enum for inch to centimeter conversion.
            /// </summary>
            INCH_TO_CENTIMETER,
        }

        /// <summary>
        /// Function to get value of enum.
        /// </summary>
        /// <param name="lengthUnit"></param>
        /// <returns></returns>
        public double GetValue(LengthUnit lengthUnit)
        {
            return lengthUnit switch
            {
                LengthUnit.FEET => 1.0,
                LengthUnit.INCH => 1.0,
                LengthUnit.FEET_TO_INCH => 1 * 12.0,
                LengthUnit.INCH_TO_FEET => 1 / 12.0,
                LengthUnit.FEET_TO_YARD => 1 / 3.0,
                LengthUnit.INCH_TO_YARD => 1 / 36.0,
                LengthUnit.YARD_TO_INCH => 1 * 36.0,
                LengthUnit.YARD_TO_FEET => 1 * 3.0,
                LengthUnit.INCH_TO_CENTIMETER => 1 * 2.5,
                _ => 0.0,
            };
        }
    }
}
