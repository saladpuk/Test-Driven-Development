using System.Linq;

namespace ATMConsole
{
    public class ATMController
    {
        private readonly ILogFile log;
        private readonly IAccountDAC dac;

        public ATMController(ILogFile log, IAccountDAC dac)
        {
            this.log = log;
            this.dac = dac;
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
            => dac.GetAllAccounts().FirstOrDefault(it => it.Username == username);
    }
}
