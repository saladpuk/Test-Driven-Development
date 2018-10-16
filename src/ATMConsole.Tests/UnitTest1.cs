using Moq;
using System.Collections.Generic;
using Xunit;

namespace ATMConsole.Tests
{
    public class UnitTest1
    {
        private ATMController sut;
        private Mock<ILogFile> logMocking;

        public UnitTest1()
        {
            var mock = new MockRepository(MockBehavior.Default);
            logMocking = mock.Create<ILogFile>();
            sut = new ATMController(logMocking.Object);
            sut.Accounts = new List<Account>
            {
                new Account{ Username = "john", Balance = 500 },
                new Account{ Username = "Doe", Balance = 50 },
            };
        }

        [Theory(DisplayName = "ผู้ใช้กดเงินออกจากตู้ข้อมูลถูกต้อง ระบบทำการหักเงินแล้วนำเงินออกมา")]
        [InlineData("john", 500, 0)]
        [InlineData("john", 450, 50)]
        [InlineData("john", 1, 499)]
        public void WithdrawWithAllDataCorrectSystemAcceptTheRest(string username, double withdrawAmount, double expectedMoney)
        {
            var actual = sut.Withdraw(username, withdrawAmount);
            Assert.True(actual);

            var selectedAccount = sut.GetAccountByUsername(username);
            Assert.Equal(expectedMoney, selectedAccount.Balance);

            logMocking.Verify(log => log.WriteWithdraw
            (
                It.Is<string>(it => it == username),
                It.Is<double>(it => it == withdrawAmount))
            );
        }

        [Theory(DisplayName = "ผู้ใช้กดเงินออกจากตู้ข้อมูลไม่ถูกต้อง ระบบทำการแจ้งเตือน")]
        [InlineData("john", 0, 500)]
        [InlineData("john", -1, 500)]
        public void WithdrawWithSomeDataIncorrectThenSystemMustNotAcceptTheRest(string username, double withdrawAmount, double expectedMoney)
        {
            var actual = sut.Withdraw(username, withdrawAmount);
            Assert.False(actual);

            var selectedAccount = sut.GetAccountByUsername(username);
            Assert.Equal(expectedMoney, selectedAccount.Balance);

            logMocking.Verify(log => log.WriteWithdraw(It.IsAny<string>(), It.IsAny<double>()), Times.Never());
        }

        [Theory(DisplayName = "ผู้ใช้ที่ไม่มีในระบบทำการถอนเงิน ระบบไม่ยอมให้ถอนเงิน")]
        [InlineData("unknow", 100)]
        [InlineData("", 100)]
        [InlineData(null, 100)]
        public void InvalidUserTryToWithdrawThenSystemMustNotAcceptTheResut(string username, double withdrawAmount)
        {
            var actual = sut.Withdraw(username, withdrawAmount);
            Assert.False(actual);

            var selectedAccount = sut.GetAccountByUsername(username);
            Assert.Null(selectedAccount);

            logMocking.Verify(log => log.WriteWithdraw(It.IsAny<string>(), It.IsAny<double>()), Times.Never());
        }

        [Theory(DisplayName = "ผู้ใช้กดเงินออกจากตู้แต่เงินในบัญชีไม่พอ ระบบทำการแจ้งเตือน")]
        [InlineData("Doe", 100, 50)]
        public void WithdrawWhenBalanceIsNotEnoughtThenSystemMustNotAcceptTheResut(string username, double withdrawAmount, double expectedMoney)
        {
            var result = sut.Withdraw(username, withdrawAmount);
            Assert.False(result);

            var selectedAccount = sut.GetAccountByUsername(username);
            Assert.Equal(expectedMoney, selectedAccount.Balance);

            logMocking.Verify(log => log.WriteWithdraw(It.IsAny<string>(), It.IsAny<double>()), Times.Never());
        }
    }
}

//Normal cases
//3.ผู้ใช้กดเงินออกจากตู้ข้อมูลถูกต้อง แต่ตู้มีเงินไม่พอจ่าย ระบบทำการแจ้งเตือน

//Alternative cases
//4.ผู้ใช้บัญชีพิเศษกดเงินมากกว่าที่มีในบัญชี ระบบบันทึกเครดิตแล้วนำเงินออกมา
//5.ผู้ใช้บัญชีพิเศษกดเงินมากกว่าที่มีในบัญชี แต่เครดิตเต็มแล้ว ระบบทำการแจ้งเตือน

//Exception cases
//6.ผู้ใช้ถอนเงินสำเร็จแต่ระบบไม่สามารถตัดเงินออกจากบัญชีได้ ระบบทำการแจ้งเตือน