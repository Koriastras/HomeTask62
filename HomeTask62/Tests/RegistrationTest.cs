using HomeTask62.Framework;
using HomeTask62.Framework.Models;
using HomeTask62.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System;




namespace HomeTask62.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private User firstUser;
        private User secondUser;
        private User thirdUser;
        private User fourtUser;
        private User fifthUser;
        private const string TitleName = "Wellcome To Your Personal Road Assitance";


        [SetUp]

        protected void Initialize()
        {
            firstUser = User.User1();
            //secondUser = User.User2();
            //thirdUser = User.User3();
            //fourtUser = User.User4();
            //fifthUser = User.User5();


        }



        [Test]
        public void RegistrationTestForUser1()
        {

            CheckInfoPage tablePage = SiteNavigator.NavigateToTablePage(Driver).EntryRegistrationData(firstUser);

            IWebElement tableElements = Driver.FindElement(By.XPath("//*[@style = 'width:100%']//tbody"));
            List<IWebElement> tableArray = new List<IWebElement>(tableElements.FindElements(By.TagName("th")));

            string strRowData = "";

            string[] TableUser1 = { User.User1().Username, User.User1().Password, User.User1().FirstName, User.User1().LastName };
            if (tableArray.Count > 0)
            {
                foreach (var elemTd in tableArray)
                {

                    strRowData = strRowData + elemTd.Text + "\t\t";

                }
            }

            foreach (string el in TableUser1)
            {

                Assert.That(strRowData.Contains(el));
            }

            LoginPage loginPage1 = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(firstUser);

            Assert.AreEqual(TitleName, tablePage.GetTitle(), "Title text differs from expected!");



            //    CheckInfoPage tablePage2 = SiteNavigator.NavigateToTablePage(Driver).EntryRegistrationData(secondUser);

            //    string[] TableUser2 = { User.User2().Username, User.User2().Password, User.User2().FirstName, User.User2().LastName };
            //    if (tableArray.Count > 0)
            //    {
            //        foreach (var elemTd in tableArray)
            //        {

            //            strRowData = strRowData + elemTd.Text + "\t\t";

            //        }
            //    }

            //    foreach (string el in TableUser2)
            //    {

            //        Assert.That(strRowData.Contains(el));
            //    }

            //    LoginPage loginPage2 = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(secondUser);

            //    Assert.AreEqual(TitleName, tablePage2.GetTitle(), "Title text differs from expected!");

            //    string[] TableUser3 = { User.User3().Username, User.User3().Password, User.User3().FirstName, User.User3().LastName };
            //    if (tableArray.Count > 0)
            //    {
            //        foreach (var elemTd in tableArray)
            //        {

            //            strRowData = strRowData + elemTd.Text + "\t\t";

            //        }
            //    }

            //    foreach (string el in TableUser1)
            //    {

            //        Assert.That(strRowData.Contains(el));
            //    }

            //    LoginPage loginPage3 = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(thirdUser);

            //    Assert.AreEqual(TitleName, tablePage.GetTitle(), "Title text differs from expected!");
            //}
        }
    }
}
        
                
            
            

     



