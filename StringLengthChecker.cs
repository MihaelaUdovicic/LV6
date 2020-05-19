using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class StringLengthChecker : StringChecker
    {
        private int minLength = 9;
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length >= minLength) return true;
            return false;
        }
    }
}
