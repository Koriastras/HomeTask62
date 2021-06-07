using System.Configuration;
using HomeTask62.Pages;
using OpenQA.Selenium;

namespace HomeTask62.Framework
{
    public class SiteNavigator
    {
        public static RegistrationPage NavigateToTablePage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://testingchallenges.thetestingmap.org/challenge10.php");
            return new RegistrationPage(driver);

        }
        public static LoginPage NavigateToLoginPage(IWebDriver driver)
        {
       
            driver.Navigate().GoToUrl("http://testingchallenges.thetestingmap.org/login/login.php"); 
            return new LoginPage(driver);
        }
    }
}
