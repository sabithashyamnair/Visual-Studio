using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Tests1
{
    [Binding]
    public class FindHotelSteps
    {

        //static IWebDriver driver = LoginPageSteps.driver;
        // static FindHotelPage FindHotelPage1 = new FindHotelPage(LoginPageSteps.driver);


        FindHotelPage FindHotelPage1 = new FindHotelPage(Browser.driver);

        [Given("User has successfully Loggedin")]
        public void GivenSucessfullLogin()
        {
            new LoginPage1(Browser.driver).Login();
        }

        [When("User selects and enters mandatory fields")]
        public void WhenEnterManField()
        {
            FindHotelPage1.location.SelectByText("Melbourne");
            FindHotelPage1.noOfRooms.SelectByIndex(2);
            FindHotelPage1.checkInDate.Clear();
            FindHotelPage1.checkInDate.SendKeys("30/08/2018");
            FindHotelPage1.checkOutDate.Clear();
            FindHotelPage1.checkOutDate.SendKeys("31/08/2018");
            FindHotelPage1.adultsPerRoom.SelectByIndex(2);
            FindHotelPage1.search.Click();

        }

        [Then("Hotels selection page should be displayed")]
        public void ThenTheResultShouldBe()
        {
            Assert.AreEqual("Select Hotel ", FindHotelPage1.selectHotel.Text);

        }
    }
}
