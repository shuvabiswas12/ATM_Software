using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Utilities.CustomValidations
{
    public class ValidStartingBalanceAttribute : ValidationAttribute
    {
        private readonly double _startingBalance;

        public ValidStartingBalanceAttribute(double startingBalance)
        {
            this._startingBalance = startingBalance;
        }

        public override bool IsValid(object value)
        {
            double newBalance = (double) value;

            return _startingBalance < newBalance;
        }
    }
}
