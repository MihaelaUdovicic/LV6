using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class MementoBank
    {
        public string ownerName { get; set; }
        public string ownerAddress { get; set; }
        public decimal balance { get; set; }
        public MementoBank(string ownerName,string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
    }
}
