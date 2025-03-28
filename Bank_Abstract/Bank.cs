using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Abstract
{
	internal class Bank
	{
		BankAccount[] accounts;

		public Bank(int maxAccount) 
		{
			accounts = new BankAccount[maxAccount];
		}

		public BankAccount NewAccount(Owner owner, double creditlimit)
		{
			if(creditlimit == 0)
			{
				return new SavingsAccount(owner);
			}
			else
			{
				return new CreditAccount(owner, creditlimit);
			}

		}
		double totalBalance(Owner owner)
		{
			double osszeg =0;
			foreach(var account in accounts)
			{
				osszeg += account.Balance;
			}
			return osszeg;
		}

		public BankAccount maximalBalanceAccount(Owner owner)
		{
			BankAccount maxBankAccount = accounts[0];
			
			for(int i = 0; i < accounts.Length; i++)
			{
				if (accounts[i].Balance> maxBankAccount.Balance)
				{
					maxBankAccount = accounts[i];
				}
			}
			return maxBankAccount;
		}

		public double TotalCreditLimit()
		{
			double osszeg = 0;
			foreach (var account in accounts)
			{
				if(account is CreditAccount)
				{
					osszeg += (account as CreditAccount).Creditlimit;
				}
			}
			return osszeg;
		}
	}
}
