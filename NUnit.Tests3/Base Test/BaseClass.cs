using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace NUnit.Tests3.Base_Test
{

    public class BaseClass
    {

        public IWebDriver driver;

        [OneTimeSetUp]

        public void Open()
        {
            driver = new ChromeDriver();
            // TODO: Add your test code here
            driver.Url = "http://localhost:8007/ProLawPortal/#/Login";


        }


        [OneTimeTearDown]
        public void close()
        {

            driver.Quit();
        }




    }
}
