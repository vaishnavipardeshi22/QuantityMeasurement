namespace QuantityMeasurementProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Unit
    {
        /// <summary>
        /// Enum For length unit.
        /// </summary>
        public enum UnitType
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
            /// Enum for litre volume type.
            /// </summary>
            LITRE,

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

            /// <summary>
            /// Enum for centimeter to inch conversion.
            /// </summary>
            CENTIMETER_TO_INCH,

            /// <summary>
            /// Enum for gallon to litres conversion.
            /// </summary>
            GALLON_TO_LITRES,

            /// <summary>
            /// Enum for litre to millilitre conversion.
            /// </summary>
            LITRE_TO_MILLILITRE,

            /// <summary>
            /// Enum for millilitre to litre conversion.
            /// </summary>
            MILLILITRE_TO_LITRE,

            /// <summary>
            /// Enum for kilogram to gram conversion.
            /// </summary>
            KILOGRAM_TO_GRAM,
        }

        /// <summary>
        /// Function to get value of enum.
        /// </summary>
        /// <param name="unitType"></param>
        /// <returns></returns>
        public double GetValue(UnitType unitType)
        {
            return unitType switch
            {
                UnitType.FEET => 1.0,
                UnitType.INCH => 1.0,
                UnitType.LITRE => 1.0,
                UnitType.FEET_TO_INCH => 1 * 12.0,
                UnitType.INCH_TO_FEET => 1 / 12.0,
                UnitType.FEET_TO_YARD => 1 / 3.0,
                UnitType.INCH_TO_YARD => 1 / 36.0,
                UnitType.YARD_TO_INCH => 1 * 36.0,
                UnitType.YARD_TO_FEET => 1 * 3.0,
                UnitType.INCH_TO_CENTIMETER => 1 * 2.5,
                UnitType.CENTIMETER_TO_INCH => 1 / 2.5,
                UnitType.GALLON_TO_LITRES => 1 * 3.78,
                UnitType.LITRE_TO_MILLILITRE => 1 * 1000.0,
                UnitType.MILLILITRE_TO_LITRE => 1 / 1000.0,
                UnitType.KILOGRAM_TO_GRAM => 1 * 1000.0,
                _ => 0.0,
            };
        }
    }
}
