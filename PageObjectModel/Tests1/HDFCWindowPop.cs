using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace Tests1
{
    public class HDFCWindowPop
    {
        private IWebDriver driver;

      
       
       
        public string CurrentWindow => driver.CurrentWindowHandle;

        // Find the element that triggers the popup when clicked on.
        public IWebElement login => driver.FindElement(By.Id("loginsubmit"));

     public PopupWindowFinder finder => new PopupWindowFinder(driver);
        //  public string popupWindowHandle => finder.Click(login);

        public string popupWindowHandle;

        public WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            
        public IWebElement continueBt => driver.FindElement(By.LinkText("Continue to NetBanking"));


 

      /*  public string CurrentWindow => driver.CurrentWindowHandle;
       * IWebElement element = driver.FindElement(By.XPath("//*[@id='webtraffic_popup_start_button']"));
   
        PopupWindowFinder finder => new PopupWindowFinder(driver);

string popupWindowHandle = finder.Click(element);

driver.SwitchTo().Window(popupWindowHandle);

// Do whatever you need to on the popup browser, then...
driver.Close();
driver.SwitchToWindow(currentHandle);*/


/*   // Console.WriteLine(finder);
       public  string newHandle => finder.Click(driver.FindElement(By.LinkText("Continue to NetBanking")));
     
       driver.SwitchTo().Window(newHandle);*/



        public HDFCWindowPop(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Url = "https://www.hdfcbank.com/";

            login.Click();
        }
    }
}


/*
// Get the current window handle so you can switch back later.
string currentHandle = driver.CurrentWindowHandle;

// Find the element that triggers the popup when clicked on.
IWebElement element = driver.FindElement(By.XPath("//*[@id='webtraffic_popup_start_button']"));

// The Click method of the PopupWindowFinder class will click
// the desired element, wait for the popup to appear, and return
// the window handle to the popped-up browser window. Note that
// you still need to switch to the window to manipulate the page
// displayed by the popup window.
PopupWindowFinder finder = new PopupWindowFinder(driver);
string popupWindowHandle = finder.Click(element);

driver.SwitchTo().Window(popupWindowHandle);

// Do whatever you need to on the popup browser, then...
driver.Close();
driver.SwitchToWindow(currentHandle);*/