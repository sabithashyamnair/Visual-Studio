using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;



namespace Automation
{
    public class GoogleSearch
    {
        // private object driver;

        //private const string V = "lst-ib";

        IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
       
      // IWebDriver driver = new FirefoxDriver(AppDomain.CurrentDomain.BaseDirectory);
        //IWebDriver driver = new FirefoxDriver();

         

        public void LoginPage()
        {
          //  IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);

          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);--Implicit wait
          

            driver.Url = "http:\\adactin.com/HotelApp/";


            IWebElement username = driver.FindElement(By.Id("username"));
            IWebElement password = driver.FindElement(By.Id("password"));
            IWebElement login = driver.FindElement(By.Id("login"));

            username.Clear();
            username.SendKeys("sampleuser101");

            password.Clear();
            password.SendKeys("passuser1");

            login.Click();
        }


        public void FindHotelPage()
        {
           
            SelectElement location = new SelectElement(driver.FindElement(By.Id("location")));
            location.SelectByText("Melbourne");

            SelectElement noOfRooms = new SelectElement(driver.FindElement(By.Id("room_nos")));
            noOfRooms.SelectByIndex(2);


            IWebElement checkInDate = driver.FindElement(By.Id("datepick_in"));
            checkInDate.Clear();
            checkInDate.SendKeys("10/08/2018");

            IWebElement checkOutDate = driver.FindElement(By.Id("datepick_out"));
            checkOutDate.Clear();
            checkOutDate.SendKeys("12/08/2018");

            SelectElement adultsPerRoom = new SelectElement(driver.FindElement(By.Id("adult_room")));
            adultsPerRoom.SelectByIndex(2);

            IWebElement search = driver.FindElement(By.Id("Submit"));
            search.Click();


        }

        public void SelectHotelPage()
        {

            IWebElement radioButton = driver.FindElement(By.Id("radiobutton_2"));
            radioButton.Click();

            IWebElement continue1 = driver.FindElement(By.Id("continue"));
            continue1.Click();


        }

        public void BookingWithCustDetailsPage()
        {

            IWebElement firstName = driver.FindElement(By.Id("first_name"));
            firstName.Clear();
            firstName.SendKeys("Sabitha");

            IWebElement lastName = driver.FindElement(By.Id("last_name"));
            lastName.Clear();
            lastName.SendKeys("Nair");

            IWebElement address = driver.FindElement(By.Id("address"));
            address.Clear();
            address.SendKeys("2/5, Beverley St \n Glen Huntly");

            IWebElement creditCardNo = driver.FindElement(By.Id("cc_num"));
            creditCardNo.Clear();
            creditCardNo.SendKeys("0123456789012345");

            SelectElement creditCardType = new SelectElement(driver.FindElement(By.Id("cc_type")));
            creditCardType.SelectByIndex(2);

            SelectElement expiryDateMonth = new SelectElement(driver.FindElement(By.Id("cc_exp_month")));
            expiryDateMonth.SelectByIndex(7);


            SelectElement expiryDateYear = new SelectElement(driver.FindElement(By.Id("cc_exp_year")));
            expiryDateYear.SelectByValue("2021");

            IWebElement cvv = driver.FindElement(By.Id("cc_cvv"));
            cvv.Clear();
            cvv.SendKeys("676");

           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           // wait.Until(d => driver.FindElement(By.Id("book_now")).Displayed);


            IWebElement bookNow = driver.FindElement(By.Id("book_now"));
            bookNow.Click();

         
        }

        public void BookingConfirmPage()
        {

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          wait.Until(d => driver.FindElement(By.Id("my_itinerary")).Displayed);

            IWebElement my_itinerary = driver.FindElement(By.Id("my_itinerary"));
            my_itinerary.Click();

            //  IWebElement select = driver.FindElement(By.ClassName("select_text"));

            // IWebElement bookingid = driver.FindElement(By.Id("order_id_263302"));

            //  List<GoogleSearch> bookingidlist = (System.Collections.Generic.List<Automation.GoogleSearch>)driver.FindElement(By.Id("order_id_263302"));
            /*foreach (IWebElement option in allOptions)
            {
                Console.WriteLine("Value is: " + option.GetAttribute("value"));
ß
            }*/
            /*    for (int i = 0; i <= bookingidlist.Count; i++)
                {

                    Console.WriteLine("Value is: " + i.GetTypeCode("value"));
                }*/
            /*   IWebElement orderid = driver.FindElement(By.Id("order_id_263302"));


               List<GoogleSearch> bookingid = new List<GoogleSearch>() ;


               for (int i = 0; i < bookingid.Count; i++)
               {

                   Console.WriteLine("Value is: " + bookingid1(i));

               }*/

            /*  IWebElement select = driver.FindElement(By.Id("booked_form"));
              IList<IWebElement> orderID = select.FindElements(By.Id("booked_form"));
              foreach (IWebElement bookingid in orderID)
              {
                  Console.WriteLine("Value is: " + bookingid.GetAttribute("value"));
                  //option.Click();
              }*/




            /* IList<IWebElement> elements = driver.FindElements(By.XPath("//input[starts-with(@name,'order_id_')]"));
              //input[starts-with(@id, 'text-')]
              string[] orderid = new string[elements.Count];

              foreach(IWebElement element in elements)
              {
                  Console.WriteLine(element.GetAttribute("value"));
              }*/


            //*[@id="booked_form"]/table/tbody/tr[1]/td/table/tbody/tr/td[1]
            //*[@id="booked_form"]/table/tbody/tr[1]/td/table/tbody/tr/td[1]



            /*string[] rowid = new string[tableRow.Count];
            foreach (IWebElement row in tableRow)
            {
                //rowTD = row.FindElements(By.TagName("td"));
                Console.WriteLine(row.GetAttribute("value"));*/
            // IWebElement myTable = driver.FindElement(By.XPath("//*[@id='booked_form']/table/tbody/tr[1]"));

            // IList<IWebElement> rows = new List<IWebElement>(myTable.FindElements(By.TagName("tr")));


            // IWebElement myTable = driver.FindElement(By.XPath("//*[@id='example-datatable']/tbody"));

            //*[@id="order_id_264665"]
            //*[@id="booked_form"]/table/tbody/tr[2]/td/table/tbody/tr[2]/td[1]/input
            //*[@id="check_all"]
            //*[@id="booked_form"]/table/tbody/tr[1]
            //*[@id="booked_form"]/table/tbody/tr[2]/td/table/tbody/tr[1]
            //*[@id="booked_form"]/table/tbody/tr[2]/td/table/tbody

            //*[@id="booked_form"]/table/tbody/tr[2]/td/table/tbody/tr[3]
            //Getting Number of rows in table

         /*   IWebElement myTable = driver.FindElement(By.XPath("//table[contains(@class,'login')]"));


            IList<IWebElement> rows = new List<IWebElement>(myTable.FindElements(By.XPath("//table[contains(@class,'login')]/tbody/tr[2]/td/table/tbody/tr")));

               foreach (IWebElement colElement in rows)

                   {

                       //Getting Number of cols in row table

                IList<IWebElement> cols = new List<IWebElement>(colElement.FindElements(By.XPath("//table[contains(@class,'login')]/tbody/tr[2]/td/table/tbody/tr[1]/td")));

                if(cols.Count > 0)
                       {
                           //Iterating through each cell

                       foreach (IWebElement cellData in cols)

                           {

                               //getting each cell data

                              String data = cellData.Text;

                               Console.WriteLine(data);

                          // Console.WriteLine(data);

                           foreach (IWebElement colvalue in cols)
                           {
                               Console.WriteLine(colvalue.GetAttribute("value"));
                               //option.Click();
                           }


                           }

                       }

               }*/

           IWebElement data;
            int i, j;
            string row_xpath = "//table[contains (@class, 'login')]/tbody/tr[2]/td/table/tbody/tr";
            string col_xpath = "//table[contains (@class, 'login')]/tbody/tr[2]/td/table/tbody/tr[1]/td";

            IWebElement Table = driver.FindElement(By.XPath("//table[contains (@class, 'login')]"));
            int row, col;
            row = driver.FindElements(By.XPath(row_xpath)).Count;
            col = driver.FindElements(By.XPath(col_xpath)).Count;

            Console.WriteLine("Row" +row);
            Console.WriteLine("Col"+col);

            for (i = 2; i <= row; i++)
            {
                for (j = 1; j <= col; j++)
                {
                    data = driver.FindElement(By.XPath(row_xpath + "[" + i + "]/td[" + j + "]/input"));
                    Console.WriteLine(data.GetAttribute("value"));

                }
            }
        }


        public static void Main()
        {
            /* IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
             driver.Url= "http:\\google.com";
             //driver.FindElement();

             IWebElement element = driver.FindElement(By.Id("lst-ib"));

             //driver.Close();*/


            //  IWebElement username= driver.FindElement(By.XPath(//))


           /* List<IWebDriver> iwebdrivers = new List<IWebDriver>();

            ChromeDriver chrome = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            iwebdrivers.Add(chrome);

            FirefoxDriver firefox = new FirefoxDriver(AppDomain.CurrentDomain.BaseDirectory);
            iwebdrivers.Add(firefox);*/

            GoogleSearch mygs = new GoogleSearch();


            mygs.LoginPage();
            mygs.FindHotelPage();
            mygs.SelectHotelPage();
            mygs.BookingWithCustDetailsPage();
            mygs.BookingConfirmPage();


           /* firefox.LoginPage();
            firefox.FindHotelPage();
            firefox.SelectHotelPage();
            firefox.BookingWithCustDetailsPage();
            firefox.BookingConfirmPage();*/



          /*  List<GoogleSearch> bookingidlist = new List<GoogleSearch>();

            List<GoogleSearch> bookingidlist = driver.findElements(By.tagName("a"));


            for (int i = 1; i <= links.size(); i = i + 1)

            {

                System.out.println(links.get(i).getText());

            }*/

      /*     List<GoogleSearch> bookingidlist = new List<GoogleSearch>();

            IWebElement bookingidlist = driver.FindElements(By.ClassName("select_text"));
            for (int i = 0; i < bookingidlist.size(); i++)
            {
                String bookingid = bookingidlist.get(i).getText();
                Console.WriteLine(bookingid);
            } */
          
           

          //  IWebElement logout = driver.FindElement(By.Id("logout"));
           // logout.Click();


            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));--Explicit Wait
           // wait.Until(d => driver.FindElement(By.Id("")).Displayed);
                                                     

        }

    }
}

