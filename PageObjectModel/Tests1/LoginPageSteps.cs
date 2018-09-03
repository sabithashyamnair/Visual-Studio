using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Tests1
{
    [Binding]
    public class LoginPageSteps
    {

       // public static IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        static LoginPage1 loginpage1 = new LoginPage1(Browser.driver);

        [Given("User is in Login Page")]
        public void given()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Url = "http://www.adactin.com/HotelAppBuild2/";

        }

        [When("User enters incorrect login credentials")]
        public void when()
        {
            loginpage1.username.SendKeys("sampleuser101");
            loginpage1.password.SendKeys("passu1");
            loginpage1.loginBt.Click();


        }

    

        [Then("error message is displayed")]
        public void then()
        {
            Assert.AreEqual("Invalid Login Details", loginpage1.errorMessage.Text);
        }


      

        [When("User enters correct login credentials '(.*)' and '(.*)' ")]
        public void whenSuc(string x, string y )
        {
            // loginpage1.username.SendKeys("sampleuser101");
            //loginpage1.password.SendKeys("passuser1");
            loginpage1.username.SendKeys(x);
            loginpage1.username.SendKeys(y);

            loginpage1.loginBt.Click();

        }
       

        [Then("Welcome to AdactIn Group of Hotels is displayed")]
        public void thenSuc()
        {
           // Assert.Equals(loginpage1.errorMessage.Text, "Invalid Login Details");
            Assert.AreEqual("Welcome to AdactIn Group of Hotels", loginpage1.successlogin.Text);
        }
    }
}
