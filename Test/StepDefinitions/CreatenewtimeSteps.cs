using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using test_for_horse_web_piper;

namespace Test.StepDefinitions
{
    [Binding]
    public class CreatenewtimeSteps
    {
        IWebDriver driver;
        [Given(@"I have logged in to Turn Up portal")]
        public void GivenIHaveLoggedInToTurnUpPortal()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            LoginPage loginPage = new LoginPage();
            loginPage.login(driver);
        }
        
        [Given(@"I have navigated to Time and Material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            // go to navigation bar
            NavigationPage navigationPage = new NavigationPage(driver);
            navigationPage.admin_menu();
            navigationPage.time_materials_menu();
        }
        
        [When(@"I have clicked on the create button and filled all the information in the form")]
        public void WhenIHaveClickedOnTheCreateButtonAndFilledAllTheInformationInTheForm()
        {
            // click the "create" button
            TimeMaterialCreatePage timeMaterialCreatePage = new TimeMaterialCreatePage(driver);
            timeMaterialCreatePage.createNew();


            // create a new time&material row
            TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
            timeMaterialPage.fill_in(driver);
        }
        
        [Then(@"I should be able to create a time record sucessfully")]
        public void ThenIShouldBeAbleToCreateATimeRecordSucessfully()
        {
            TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
            timeMaterialPage.save();
        }
    }
}
