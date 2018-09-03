using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Tests1
{
    public class SelectHotelPage
    {
        private IWebDriver driver;

        public IWebElement radioButton => driver.FindElement(By.Id("radiobutton_2"));
        public IWebElement continue1 => driver.FindElement(By.Id("continue"));


        public SelectHotelPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
