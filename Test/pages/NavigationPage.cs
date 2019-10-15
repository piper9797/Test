using System;
using OpenQA.Selenium;

namespace test_for_horse_web_piper
{
    internal class NavigationPage
    {
        private IWebDriver driver;

        public NavigationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void admin_menu()
        {
            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();

        }


        internal void time_materials_menu()
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial'][contains(.,'Time & Materials')]")).Click();
        }
    }
}