using AvanceretProgrammeringEksamen.Controllers;
using AvanceretProgrammeringEksamen.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    [TestClass]
    public class SalesControllerTests
    {
        [TestMethod]
        public void Reward_ShouldUseCorrectStrategy_CustomerSatisfaction()
        {
            // Arrange
            string strategyType = "CustomerSatisfaction";

            SalesController controller = new SalesController();

            // Act
            var result = controller.Reward(strategyType) as ViewResult;

            // Assert
            RewardViewModel? model = result.Model as RewardViewModel;
            Assert.AreEqual(strategyType, model.SelectedStrategy);
        }
    }
}
