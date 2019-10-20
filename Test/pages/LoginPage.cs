using OpenQA.Selenium;
using Test.Utilities;

namespace test_for_horse_web_piper
{
    internal class LoginPage
    {
        public void login(IWebDriver driver)
        {

        
            // get data from excel and create collection during runtime
            ExcelUtility.PopulateInCollection(@"C:\Users\PIPER\source\repos\Test\Test\TestData\TestData.xls","LoginPage");
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            IWebElement password = driver.FindElement(By.Id("Password"));
            // userName.SendKeys("hari");
            userName.SendKeys(ExcelUtility.ReadData(2, "UserName"));
            //password.SendKeys("123123");
            password.SendKeys(ExcelUtility.ReadData(2, "Password"));
            IWebElement login_btn = driver.FindElement(By.XPath("//input[contains(@type,'submit')]"));
            login_btn.Click();

        }

    }
}