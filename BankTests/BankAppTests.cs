using BankApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankAppTests
    {
        [TestMethod]
        [Owner("Dongli Liu")]
        [TestCategory("Important")]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            // Arrange
            double depositAmount = 100;
            double exceptedBalance = 1100;

            // Act
            BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 1000);
            mybank.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(exceptedBalance, mybank.Balance);
        }

        [TestMethod]
        [Owner("Dongli Liu")]
        [TestCategory("Important")]
        public void Withdraw_ValidAmount_UpdateBalance()
        {
            {
                // Arrange
                double withdrawAmount = 100;
                double exceptedBalance = 900;

                // Act
                BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 1000);
                mybank.Withdraw(withdrawAmount);

                // Assert
                Assert.AreEqual(exceptedBalance, mybank.Balance);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Owner("Dongli Liu")]
        [TestCategory("VeryImportant")]
        public void Withdraw_OverdrawAmount_WithException()
        {
            // Arrange
            double withdrawAmount = 1000;

            // Act
            BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 900);
            mybank.Withdraw(withdrawAmount);
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        [Owner("Dongli Liu")]
        [TestCategory("VeryImportant")]
        public void Withdraw_WithdrawZero_WithException()
        {
            // Arrange
            double withdrawAmount = 0;

            // Act
            BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 900);
            mybank.Withdraw(withdrawAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Owner("Dongli Liu")]
        [TestCategory("VeryImportant")]
        public void Withdraw_WithdrawNegative_WithException()
        {
            // Arrange
            double withdrawAmount = -100;

            // Act
            BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 900);
            mybank.Withdraw(withdrawAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Owner("Dongli Liu")]
        [TestCategory("VeryImportant")]
        public void Deposit_DepositZero_WithException()
        {
            // Arrange
            double depositAmount = 0;

            // Act
            BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 900);
            mybank.Deposit(depositAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Owner("Dongli Liu")]
        [TestCategory("VeryImportant")]
        public void Deposit_DepositNegative_WithException()
        {
            // Arrange
            double depositAmount = -100;

            // Act
            BankAccount mybank = new BankAccount(301268638, "Dongli Liu", 900);
            mybank.Deposit(depositAmount);
        }
    }
}