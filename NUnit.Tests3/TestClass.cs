// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Tests3.Base_Test;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass : BaseClass
    {
        [Test]
        public void TestMethod()
        {

           
            Thread.Sleep(5000);

            // IWebElement element = driver.FindElement(By.XPath("(//input[contains(@class,'k-textbox login-input')])[1]"));

            IWebElement element = driver.FindElement(By.CssSelector("#UserID"));

            element.SendKeys("gaurav");
          
        
        
        
        }
    }
}
