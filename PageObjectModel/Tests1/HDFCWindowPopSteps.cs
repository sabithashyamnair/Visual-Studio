using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Tests1
{
    [Binding]
    public class HDFCWindowPopSteps
    {

        HDFCWindowPop HDFCWindow1 = new HDFCWindowPop(Browser.driver);



        [Given("User is in HDFC Bank Webpage")]
        public void GivenHDFCBankWebpage()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Url = "https://www.hdfcbank.com/";
        }

        [When("User clicks on Login Button")]
        public void WhenClickLoginButton()
        {
            HDFCWindow1.popupWindowHandle= HDFCWindow1.finder.Click(HDFCWindow1.login);
           // HDFCWindow1.login.Click();
        }

        [Then("new window should Popup with Continue Button")]
        public void ThenNewWindowPop()
        {
            Browser.driver.SwitchTo().Window(HDFCWindow1.popupWindowHandle);

            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            HDFCWindow1.wait.Until(d => Browser.driver.FindElement(By.LinkText("Continue to NetBanking")).Displayed);

            HDFCWindow1.continueBt.Click();

            Browser.driver.Close();

            Browser.driver.SwitchTo().Window(HDFCWindow1.CurrentWindow);

           
           
           // Browser.driver.SwitchTo().Window(popupWindowHandle);
           

           // Browser.driver.Close();
            // Browser.driver.SwitchToWindow(currentHandle);



        }
    }
}
