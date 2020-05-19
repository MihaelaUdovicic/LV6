using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class PasswordValidator 
    {
        StringChecker first;
        StringChecker last;
        public PasswordValidator(StringChecker first)
        {
            this.first = first;
            this.last = first;
        }
        public void addLink(StringChecker link)
        {
            last.SetNext(link);
            last = link;
        }
        public bool CheckPassword(string Password)
        {
            return first.Check(Password);
        }


    }
}
