using System;
using System.Collections.Generic;
using System.Text;

namespace NumUtils.NelderMeadSimplex
{
    public sealed class SimplexConstant
    {
        private double _value;
        private double _initialPerturbation;
        /// <summary>
        /// to set up the simplexConstant. this is equivalent to the paramenter set up
        /// pertubation is used to 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="initialPerturbation"></param>
        public SimplexConstant(double value, double initialPerturbation)
        {
            _value = value;
            _initialPerturbation = initialPerturbation;
        }

        /// <summary>
        /// The value of the constant
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        // The size of the initial perturbation
        public double InitialPerturbation
        {
            get { return _initialPerturbation; }
            set { _initialPerturbation = value; }
        }

        public string ToString()
        {
            string ss = "value:" + _value;
            ss = ss + ";initialPer:" + _initialPerturbation;
            return ss;
        }
    }
}
