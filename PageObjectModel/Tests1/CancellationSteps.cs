using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Tests1
{
    [Binding]
    public class CancellationSteps
    {

        LoginPage1 loginpage1 = new LoginPage1(Browser.driver);
        Cancellation Cancellation1 = new Cancellation(Browser.driver);


        [Given("User has successfully Loggedin and clicked on Booked Itinerary")]
        public void GivenSucessfullLogin()
            {
                new LoginPage1(Browser.driver).Login();
                loginpage1.bookedItinerary.Click();

            }



        [When("User clicks the checkbox of any orderid and clicks on cancel selected button")]
        public void WhenclickOnOrderidCheckBox()
        {
            Cancellation1.bookedorderid.Click();
            Cancellation1.cancelorderid.Click();

            IAlert alert = Browser.driver.SwitchTo().Alert();
            alert.Accept();
           
        }

        [Then("Selected booking Are cancelled should be displayed")]
        public void ThendisplayCancelMsg()
        {
            Assert.AreEqual("Selected booking Are cancelled.", Cancellation1.cancelordermsg.Text);
        }
    }
}
