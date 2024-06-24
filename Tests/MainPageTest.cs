using Homework_20.Pages;

namespace Homework_20.Tests
{
    internal class MainPageTest : BaseTest
    {
        [Test]
        public void MainPageTest1()
        {
            LoginPage.Login();
            var elements = MainPage.clothesElements;

            var result = MainPage.IsNamesSorted();

            Assert.That(result, Is.True);
        }
    }
}
