using System;
using System.Linq;
using Homework_20.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_20.Pages
{
    internal class MainPage : BasePage
    {

        public static List<IWebElement> clothesElements => driver.FindElements(By.XPath("//*[@class='inventory_item_name ']")).ToList();



        private static List<string> clothesElementsNames = new List<string>();

        private static List<string> GetNames()
        {
            foreach(var a in clothesElements)
            {
                clothesElementsNames.Add(a.Text);
            }
            return clothesElementsNames;
        }

        private static List<string> clothesElementsNames1 = new List<string>();
        private static List<string> GetNames1()
        {
            foreach (var a in clothesElements)
            {
                clothesElementsNames1.Add(a.Text);
            }
            return clothesElementsNames1;
        }

        public static bool IsNamesSorted()
        {
            var notSortedNames = GetNames();
            //var sortedNames = notSortedNames;
            notSortedNames.Sort();
            bool decision = notSortedNames.SequenceEqual(GetNames1());
            return decision;
        }
    }
}
