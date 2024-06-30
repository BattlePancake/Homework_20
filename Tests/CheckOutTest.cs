using Homework_20.Pages;
using NUnit.Allure.Core;

namespace Homework_20.Tests
{
    [AllureNUnit]
    internal class CheckOutTest : BaseTest
    {

        [Test]
        [Description("Check that elements are added to the CheckOut")]
        public void CartPageTest1()
        {
            LoginPage.Login();

            MainPage.AddItemToCart(3);
            MainPage.AddItemToCart(4);
            MainPage.NavigateToCart();
            CartPage.ClickCheckOutButton();

            CheckOutPageStepOne.EnterValueFirstName("Test_User");
            CheckOutPageStepOne.EnterValueLastName("Test_Last_Name");
            CheckOutPageStepOne.EnterValueZip("12341234");
            CheckOutPageStepOne.ClickContinueButton();

            var result1 = CheckOutPageStepTwo.CheckThatItemsInCheckOut(3);
            var result2 = CheckOutPageStepTwo.CheckThatItemsInCheckOut(4);

            Assert.That(result1, Is.True);
            Assert.That(result2, Is.True);
        }
    }
}
