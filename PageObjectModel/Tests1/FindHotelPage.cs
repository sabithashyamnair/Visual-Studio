using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Tests1
{
    public class FindHotelPage
    {

        private IWebDriver driver;

        public SelectElement location => new SelectElement(driver.FindElement(By.Id("location")));
        public SelectElement noOfRooms => new SelectElement(driver.FindElement(By.Id("room_nos")));
        public IWebElement checkInDate => driver.FindElement(By.Id("datepick_in"));
        public IWebElement checkOutDate => driver.FindElement(By.Id("datepick_out"));
        public SelectElement adultsPerRoom => new SelectElement(driver.FindElement(By.Id("adult_room")));
        public IWebElement search => driver.FindElement(By.Id("Submit"));
        public IWebElement selectHotel => driver.FindElement(By.ClassName("login_title"));

        public FindHotelPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
