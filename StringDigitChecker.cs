using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach(char c in stringToCheck)
            {
                if (char.IsDigit(c)) 
                    return true;
                
            }
            return false;
        }
    }
}
