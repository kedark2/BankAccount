/*******************************************************************************
*  APPLICATION :    BankAccount
*  PURPOSE     :    Create Bank Account and accessing services like depositing, withdrawing
*  AUTHOR      :    Kedar Kanel 
*  Date        :    9th May 2014
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            String owner;
            Owner aOwner = new Owner("Kedar Kanel", "Pengerkatu", 9841404524);
            owner = aOwner.getName();
            decimal currentBalance = 0;
            BankAccount account = new BankAccount(owner, 5968, 10);
            currentBalance = account.Balance();
            Console.Write(Environment.NewLine + "The current balance of " + owner + " is : " + currentBalance);
            Console.Read();
        }
    }
}
