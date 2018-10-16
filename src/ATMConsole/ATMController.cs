using System.Collections.Generic;
using System.Linq;

namespace ATMConsole
{
    public class ATMController
    {
        private readonly ILogFile log;

        public IList<Account> Accounts { get; set; }

        public ATMController(ILogFile log)
        {
            this.log = log;
        }

        public bool Withdraw(string username, double amount)
        {
            var selectedAccount = GetAccountByUsername(username);

            const int MinWithdrawAmount = 1;
            var isWithdrawRequestValid = selectedAccount != null
                && selectedAccount.Balance >= amount
                && amount >= MinWithdrawAmount;
            if (!isWithdrawRequestValid) return false;

            selectedAccount.Balance -= amount;
            log.WriteWithdraw(username, amount);
            return isWithdrawRequestValid;
        }

        public Account GetAccountByUsername(string username)
            => Accounts.FirstOrDefault(it => it.Username == username);
    }
}
