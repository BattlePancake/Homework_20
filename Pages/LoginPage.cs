using Homework_20.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_20.Pages
{
    internal class LoginPage : BasePage
    {

        private const string _userName = "standard_user";
        private const string _password = "secret_sauce";

        private static IWebElement userNameField => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='user-name']")));
        private static IWebElement passwordField => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='password']")));
        private static IWebElement loginButton => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login-button']")));

        public static void Login()
        {
            userNameField.SendKeys(_userName);
            passwordField.SendKeys(_password);
            loginButton.Click();
        }

    }
}