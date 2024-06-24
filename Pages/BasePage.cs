using Homework_20.Factory;
using OpenQA.Selenium;

namespace Homework_20.Pages
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();

        public static void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
