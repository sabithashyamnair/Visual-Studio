using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Tests1
{
    public class Browser
    {

        public static IWebDriver driver =  new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
       
       
       
    }
}
