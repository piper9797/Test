using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_for_horse_web_piper;

namespace Test.tests
{
    class TimeAndMaterials_Test
    {
        IWebDriver driver;
        
        [SetUp]

        public void SetUp()
        {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            LoginPage loginPage = new LoginPage();
            loginPage.login(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }

        [Test]
       
        public void TimeCreateTest()
        {
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

        }




        [Test]
       
        public void TimeEditTest()
        {
            // go to navigation bar
            NavigationPage navigationPage = new NavigationPage(driver);
            navigationPage.admin_menu();
            navigationPage.time_materials_menu();
                    
            // create a new time&material row
            TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
            timeMaterialPage.Edit();

        }



        [Test]

        public void TimeDeleteTest()
        {
            // go to navigation bar
            NavigationPage navigationPage = new NavigationPage(driver);
            navigationPage.admin_menu();
            navigationPage.time_materials_menu();

            // create a new time&material row
            TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
            timeMaterialPage.Delete();

        }






    }
}
