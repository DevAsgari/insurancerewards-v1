using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvanceretProgrammeringEksamen.Models;
using AvanceretProgrammeringEksamen.Strategies;

namespace TestProject1
{
    [TestClass]
    public class RewardStrategiesTests
    {
        [TestMethod]
        public void CalculateReward_SalesPriceRewardStrategy_ShouldReturnCorrectReward()
        {
            // Arrange
            Sale sale = new Sale
            {
                SaleType = "CarInsurance",
                Price = 1000,
                CustomerSatisfaction = 5
            };

            IRewardStrategy strategy = new SalesPriceRewardStrategy();
            decimal expectedReward = sale.Price * 0.05m;

            // Act
            decimal actualReward = strategy.CalculateReward(sale);

            // Assert
            Assert.AreEqual(expectedReward, actualReward);
        }

        [TestMethod]
        public void CalculateReward_CombinedRewardStrategy_ShouldReturnCorrectReward()
        {
            // Arrange
            Sale sale = new Sale
            {
                SaleType = "HomeInsurance",
                Price = 1500,
                CustomerSatisfaction = 6
            };

            IRewardStrategy strategy = new CombinedRewardStrategy();
            decimal expectedReward = (sale.Price * 0.05m) + (sale.CustomerSatisfaction * 20m);

            // Act
            decimal actualReward = strategy.CalculateReward(sale);

            // Assert
            Assert.AreEqual(expectedReward, actualReward);
        }

        [TestMethod]
        public void CalculateReward_CustomerSatisfactionRewardStrategy_ShouldReturnCorrectReward()
        {
            // Arrange
            Sale sale = new Sale
            {
                SaleType = "CarInsurance",
                Price = 1000,
                CustomerSatisfaction = 4  
            };

            IRewardStrategy strategy = new CustomerSatisfactionRewardStrategy();
            decimal expectedReward = sale.CustomerSatisfaction * 10m;

            // Act
            decimal actualReward = strategy.CalculateReward(sale);

            // Assert
            Assert.AreEqual(expectedReward, actualReward);
        }
    }
}
