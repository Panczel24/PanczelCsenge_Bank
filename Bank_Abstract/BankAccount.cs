using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Abstract
{
	internal abstract class BankAccount : BankingService
	{
		double balance;
		public double Balance { get; protected set; }
		protected BankAccount(Owner owner) : base(owner)
		{
		}

		public void Deposit(double amount)
		{
			balance += amount;
		}

		public abstract bool Withdraw (double amount); 
	}
}
