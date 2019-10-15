using OpenQA.Selenium;

namespace test_for_horse_web_piper
{
    internal class LoginPage
    {
        public void login(IWebDriver driver)
        {

            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            IWebElement login_btn = driver.FindElement(By.XPath("//input[contains(@type,'submit')]"));
            login_btn.Click();

        }

    }
}