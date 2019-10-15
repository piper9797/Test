using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_for_horse_web_piper
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Log in the page as Admin
            LoginPage loginPage = new LoginPage();
            loginPage.login(driver);

            // go to navigation bar
            NavigationPage navigationPage = new NavigationPage(driver);
            navigationPage.admin_menu();
            navigationPage.time_materials_menu();

            // click the "create" button
            TimeMaterialCreatePage timeMaterialCreatePage = new TimeMaterialCreatePage(driver);
            timeMaterialCreatePage.createNew();


            // create a new time&material row
            TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
            timeMaterialPage.fill_in(driver);
            timeMaterialPage.save();

            timeMaterialCreatePage.validateRecord();



            driver.Quit();
        }
    }
}
