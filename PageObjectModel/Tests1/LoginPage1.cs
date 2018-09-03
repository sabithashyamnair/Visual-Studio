using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace Tests1
{
    public class LoginPage1
    {
        private IWebDriver driver;
        public IWebElement username => driver.FindElement(By.Id("username"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement loginBt => driver.FindElement(By.Id("login"));
        public IWebElement errorMessage => driver.FindElement(By.TagName("b"));
        public IWebElement successlogin => driver.FindElement(By.XPath("//table[contains(@class, 'content')]//tbody//tr[1]//td[1]"));
        public IWebElement bookedItinerary => driver.FindElement(By.LinkText("Booked Itinerary"));



        public LoginPage1(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Url = "http://www.adactin.com/HotelAppBuild2/";

            username.SendKeys("sampleuser101");
            password.SendKeys("passuser1");
            loginBt.Click();
        }
    }
}
