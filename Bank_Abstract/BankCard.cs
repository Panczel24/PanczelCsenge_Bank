using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Abstract
{
	internal class BankCard : BankingService
	{
		double accountBalance;
		string cardNumber;
		public string CarndNumber { get; }
	public double AccountBalance { get; }

		public BankCard(Owner owner, double accountBalance, string cardNumber) : base(owner)
		{
			this.accountBalance = accountBalance;
			this.cardNumber = cardNumber;
		}

		public bool Purchase(double amount)
		{
			if(AccountBalance -amount>= 0)
			{
				AccountBalance -= amount;
				return true;
			}
			return false;
		}
	}
}
