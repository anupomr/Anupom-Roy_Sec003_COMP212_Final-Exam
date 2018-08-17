using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Sec003_Ex_01
{
    public class BankAccount
    {
        int AccountNum { get; set; }
        string Name { get; set; }
        double Balance { get; set; }
        string BankerName { get; set; }

        public BankAccount(int accNum, string name, double balance, string banker)
        {
            AccountNum = accNum;
            Name = name;
            Balance = balance;
            BankerName = banker;
        }
        public override string ToString() => $"Account Number : {AccountNum}  Name : {Name}   Balance : {Balance}  Banker Name : {BankerName}  ";
    }
}
