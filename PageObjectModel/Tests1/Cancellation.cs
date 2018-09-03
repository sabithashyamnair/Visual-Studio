using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace Tests1
{
    public class Cancellation
    {

        private IWebDriver driver;

      
        //public IWebElement bookedorderid => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[2]/td/table/tbody/tr[2]/td/input"));
       
        public IWebElement bookedorderid => driver.FindElement(By.XPath("//table[contains(@class, 'login')]//tr[2]//tr[2]//input"));
 
       // public IWebElement cancelorderid => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[3]/td/input"));

        public IWebElement cancelorderid => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[3]//input"));

       // public IWebElement cancelordermsg => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr/td/table/tbody/tr/td[2]/label"));

        public IWebElement cancelordermsg => driver.FindElement(By.XPath("//table[contains(@class, 'login')]//label"));


        public Cancellation(IWebDriver driver)
        {
            this.driver = driver;
        }

      

    }

}
