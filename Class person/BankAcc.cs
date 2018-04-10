using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_person
{
	class BankAcc
	{
		int id;
		decimal balance;
		//backing field
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		//backing field
		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}
		//method
		public void Deposit(decimal amount)
		{
			balance += amount;
		}
		//method
		public void Withdraw(decimal amount)
		{
			Balance -= amount;
		}
	}
}
