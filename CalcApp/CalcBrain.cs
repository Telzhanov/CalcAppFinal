using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcApp
{
    public class CalcBrain
    {
        public double firstoperand;
        public double secondoperand;
        public double result;
        public double Plus()
        {
            result = firstoperand + secondoperand;
            return result;
        }
        public double Minus()
        {
            result = firstoperand - secondoperand;
            return result;
        }
        public double Multiple()
        {
            result = firstoperand * secondoperand;
            return result;
        }
        public double Divide()
        {
            result = firstoperand / secondoperand;
            return result;
        }
    }

}
