using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Tests1
{
    public class BookingConfirmPage
    {
        private IWebDriver driver;
        public IWebElement my_itinerary => driver.FindElement(By.Id("my_itinerary"));

        public BookingConfirmPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
