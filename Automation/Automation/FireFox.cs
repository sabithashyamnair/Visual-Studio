using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Automation
{
    public class FireFox : GoogleSearch
    {
        int x;

        public IWebDriver driver = new FirefoxDriver(AppDomain.CurrentDomain.BaseDirectory);

        public FireFox()
        {
        }
    }
}
