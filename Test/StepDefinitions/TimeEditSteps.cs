using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using test_for_horse_web_piper;

namespace Test.StepDefinitions
{
    [Binding]
    public class TimeEditSteps
    {
        IWebDriver driver;
        [Given(@"I have navigated to time and material page and I have clicked edit button and change the code")]
        public void GivenIHaveNavigatedToTimeAndMaterialPageAndIHaveClickedEditButtonAndChangeTheCode()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            IWebElement login_btn = driver.FindElement(By.XPath("//input[contains(@type,'submit')]"));
            login_btn.Click();
            // go to navigation bar
            NavigationPage navigationPage = new NavigationPage(driver);
            navigationPage.admin_menu();
            navigationPage.time_materials_menu();

       
        }
        
        [Then(@"the row I chosen should be edited")]
        public void ThenTheRowIChosenShouldBeEdited()
        {
            // create a new time&material row
            TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
            timeMaterialPage.Edit();
        }
    }
}
