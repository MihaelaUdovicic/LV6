using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public MementoBank StoreState()
        {
            return new MementoBank(this.ownerName, this.ownerAddress, this.balance);
        }
        public void RestoreState(MementoBank previous)
        {
            this.ownerName = previous.ownerName;
            this.ownerAddress = previous.ownerAddress;
            this.balance = previous.balance;
            
        }


    }
}
