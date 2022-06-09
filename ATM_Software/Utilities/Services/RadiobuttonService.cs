using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Utilities.Services
{
    public class RadiobuttonService
    {
        public static double[] GetFastCashOptions()
        {
            return new double[] { 500, 1000, 3000, 5000 };
        }
    }
}
