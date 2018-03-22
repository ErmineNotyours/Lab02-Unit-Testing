using System;
using Xunit;
using ATM;
using static ATM.Program;

namespace ATMtest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturn1()
        {
            Assert.Equal(1, ViewBalance(1));
        }

        [Fact]
        public void CanReturnDeposit1000()
        { 
            Assert.Equal(2500, Deposit(1000, 1500));
        }

        // Create more tests
        
        // view balance

        [Theory]
        [InlineData(50,100,150)]
        [InlineData(-100, 50, 50)] // negative attempt

        public void CanDepositMoney(decimal amount, decimal balance, decimal expected)
        {
            Assert.Equal(expected, Deposit(amount, balance));
        }

        [Theory]
        [InlineData(50, 100, 50)]
        [InlineData(100, 50, 50)] // overdraw attempt

        public void CanWithdrawMoney(decimal amount, decimal balance, decimal expected)
        {
            Assert.Equal(expected, Withdrawl(amount, balance));
        }

        [Fact]
        public void CanWithdraw200()
        {
            decimal balance = 500m;
            Assert.Equal(300, Withdrawl(200, balance));
        }

    
    }
}
