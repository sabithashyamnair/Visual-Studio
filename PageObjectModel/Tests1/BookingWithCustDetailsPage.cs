using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Tests1
{
    public class BookingWithCustDetailsPage
    {
        private IWebDriver driver;

        public IWebElement firstName => driver.FindElement(By.Id("first_name"));
        public IWebElement lastName => driver.FindElement(By.Id("last_name"));
        public IWebElement address => driver.FindElement(By.Id("address"));
        public IWebElement creditCardNo => driver.FindElement(By.Id("cc_num"));
        public SelectElement creditCardType => new SelectElement(driver.FindElement(By.Id("cc_type")));
        public SelectElement expiryDateMonth => new SelectElement(driver.FindElement(By.Id("cc_exp_month")));
        public SelectElement expiryDateYear => new SelectElement(driver.FindElement(By.Id("cc_exp_year")));
        public IWebElement cvv => driver.FindElement(By.Id("cc_cvv"));
        public IWebElement bookNow => driver.FindElement(By.Id("book_now"));

        public BookingWithCustDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
