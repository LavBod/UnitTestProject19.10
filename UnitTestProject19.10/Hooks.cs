using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject19._10
{
    class Hooks
    {
        protected IWebDriver Driver;

        [SetUp]
        //[OneTimeSetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
