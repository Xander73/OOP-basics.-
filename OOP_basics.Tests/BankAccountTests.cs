using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOP_basics.Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void PutMoney_100_200Returned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            int expected = 200;
            _bankAccount.PutMoney(100);
            double actual = _bankAccount.Balance;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void PutMoney_10_OkReturned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            string expected = "Текущая сумма на счете 110.";
            string actual = _bankAccount.PutMoney(10);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void PutMoney_Minus10_ErrReturned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            string expected = "Необходимо внести сумму больше 0.";
            string actual = _bankAccount.PutMoney(-10);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Withdrawmoney_10_90Returned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            int expected = 90;
            _bankAccount.Withdrawmoney(10);
            double actual = _bankAccount.Balance;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Withdrawmoney_10_OkReturned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            string expected = "Текущая сумма на счете 90.";
            string actual =  _bankAccount.Withdrawmoney(10);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Withdrawmoney_Minus10_ErrReturned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            string expected = "Необходимо внести сумму больше 0.";
            string actual =  _bankAccount.Withdrawmoney(-10);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Withdrawmoney_200_ErrReturned()
        {
            BankAccount _bankAccount = new BankAccount(100, AccountType.Current);
            string expected = "На счете недостаточно средств.";
            string actual = _bankAccount.Withdrawmoney(200);

            Assert.Equal(expected, actual);
        }
    }
}
