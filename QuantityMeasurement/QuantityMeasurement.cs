namespace QuantityMeasurementProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class QuantityMeasurement
    {
        public double GetFeetValue(double feetValue)
        {
            return feetValue;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
