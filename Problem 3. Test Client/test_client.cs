using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Test_Client
{
	class test_client
	{
		static void Main(string[] args)
		{
			var account_DICT = new Dictionary<int, BankAcc>();
			string command;

			while ((command = Console.ReadLine()) != "end")
			{
				var command_SPLIT = command.Split();
				var client_ID = int.Parse(command_SPLIT[1]);
				switch (command_SPLIT [0])
				{
					case "Create":
						if (account_DICT.ContainsKey (client_ID ))
						{
							Console.WriteLine("Account already exists");
						}
						else
						{
							var account = new BankAcc();
							account.Id = client_ID; 
							account_DICT.Add(client_ID, account	);
						}
						break;
					case "Deposit":
						if (ValidateAccount(client_ID, account_DICT ))
						{
							account_DICT[client_ID].Deposit(int.Parse(command_SPLIT[2]));
						}
						break;
					case "Withdraw":
						if (ValidateAccount(client_ID, account_DICT))
						{
							account_DICT[client_ID].Withdraw(int.Parse(command_SPLIT[2]));
						}
						break;
					case "Print":
						if (ValidateAccount(client_ID, account_DICT))
						{
							Console.WriteLine(account_DICT[client_ID]);
						}
						break;
					default:
						break;
				}
			}
		}
		static bool ValidateAccount(int account_ID, Dictionary<int, BankAcc>accounts)
		{
			if (accounts.ContainsKey(account_ID))
			{
				return true;
			}
			else
			{
				Console.WriteLine("Account does not exist");
				return false;
			}
		}
	}
}
