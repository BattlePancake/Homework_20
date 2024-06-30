using Homework_20.Factory;
using Homework_20.Pages;

namespace Homework_20.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            BasePage.OpenPage();
        }

        [TearDown]
        public void TearDown()
        { 
            Driver.QuitDriver();
        }
    }
}
