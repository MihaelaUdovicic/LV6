using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char c in stringToCheck)
            {
                if (char.IsLower(c))
                    return true;

            }
            return false;
        }
    }
}
