using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Abstract
{
	internal class CreditAccount : BankAccount
	{
		double creditlimit; // ha ezt kijelölöm és quick actions akkor ott add parameter

		//public double Balance { get; protected set; }

		public double Creditlimit { get; }
		public CreditAccount(Owner owner, double creditlimit) : base(owner)
		{
			this.creditlimit = creditlimit;
		}

		public override bool Withdraw(double amount)
		{
			if (this.Balance - amount >= creditlimit)
			{
				this.Balance -= amount;
				return true;
			}
			return false;
		}
	}
}
