using Homework_20.Pages;
using NUnit.Allure.Core;

namespace Homework_20.Tests
{
    [AllureNUnit]
    internal class MainPageTest : BaseTest
    {
        
        [Test]
        [Description("Sort by Name test")]
        public void MainPageTest1()
        {
            LoginPage.Login();

            MainPage.ClickAndChooseDropdownOption(1);

            var result = MainPage.AreNamesSorted();
            Assert.That(result, Is.True);
        }

        [Test]
        [Description("Sort by Price test")]
        public void MainPageTest2()
        {
            LoginPage.Login();

            MainPage.ClickAndChooseDropdownOption(3);

            var result = MainPage.ArePricesSorted();
            Assert.That(result, Is.True);
        }

    }
}
