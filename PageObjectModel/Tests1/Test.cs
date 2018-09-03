using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;


namespace Tests1
{
    [TestFixture()]
    public class Test
    {

        static IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);


        [Test()]
        public void TC1Login()
        {

            LoginPage1 loginpage1 = new LoginPage1(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "http://www.adactin.com/HotelAppBuild2/";

            loginpage1.username.SendKeys("sampleuser101");
            loginpage1.password.SendKeys("passuser1");
            loginpage1.loginBt.Click();
        }

        [Test()]

        public void TC2FindHotel()
        {

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //loginpage1 = new LoginPage1(driver);
            FindHotelPage FindHotelPage1 = new FindHotelPage(driver);

            FindHotelPage1.location.SelectByText("Melbourne");
            FindHotelPage1.noOfRooms.SelectByIndex(2);
            FindHotelPage1.checkInDate.Clear();
            FindHotelPage1.checkInDate.SendKeys("29/08/2018");
            FindHotelPage1.checkOutDate.Clear();
            FindHotelPage1.checkOutDate.SendKeys("30/08/2018");
            FindHotelPage1.adultsPerRoom.SelectByIndex(2);
            FindHotelPage1.search.Click();
        }

        [Test()]
        public void TC3tHotel()
        {
            SelectHotelPage SelectHotelPage1 = new SelectHotelPage(driver);
            // loginpage1 = new LoginPage1(driver);
            SelectHotelPage1.radioButton.Click();
            SelectHotelPage1.continue1.Click();
        }

        [Test()]
        public void TC4BookingWithCustDetails()
        {
            BookingWithCustDetailsPage BookingWithCustDetailsPage1 = new BookingWithCustDetailsPage(driver);
            //loginpage1 = new LoginPage1(driver);
            BookingWithCustDetailsPage1.firstName.SendKeys("Sabitha");
            BookingWithCustDetailsPage1.lastName.SendKeys("Nair");
            BookingWithCustDetailsPage1.address.SendKeys("2/5, Beverley St \n Glen Huntly");
            BookingWithCustDetailsPage1.creditCardNo.SendKeys("0123456789012345");
            BookingWithCustDetailsPage1.creditCardType.SelectByIndex(2);
            BookingWithCustDetailsPage1.expiryDateMonth.SelectByIndex(7);
            BookingWithCustDetailsPage1.expiryDateYear.SelectByValue("2021");
            BookingWithCustDetailsPage1.cvv.SendKeys("676");
            BookingWithCustDetailsPage1.bookNow.Click();


        }

        [Test()]
        public void TC5BookingConfirm()
        {
            BookingConfirmPage BookingConfirmPage1 = new BookingConfirmPage(driver);
            //loginpage1 = new LoginPage1(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // wait.Until(d => driver.FindElement(By.Id("my_itinerary")).Displayed);
            // wait.Until(loginpage1.my_itinerary.Displayed());
            // wait.Until<>(loginpage1.my_itinerary.Displayed());
            BookingConfirmPage1.my_itinerary.Click();

            //driver.Quit();

        }


        [Test()]
        public void TC6Cancellation()
        {
            Cancellation Cancellation1 = new Cancellation(driver);
            // loginpage1 = new LoginPage1(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Cancellation1.bookedorderid.Click();
            Cancellation1.cancelorderid.Click();
           
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }


   
        

    }
}
