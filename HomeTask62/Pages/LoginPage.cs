using OpenQA.Selenium;
using HomeTask62.Framework.Models;
using OpenQA.Selenium.Support.UI;
using System;

namespace HomeTask62.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameBox => Driver.FindElement(By.XPath("//input[@type = 'text']"));


        private IWebElement PasswordBox => Driver.FindElement(By.Name("password"));

        private IWebElement SubmitButton => Driver.FindElement(By.XPath("//button[@type= 'submit']"));

        public LoginPage EntryLoginData(User user)

        {
  
            UsernameBox.Click();
            UsernameBox.SendKeys(user.Username);
            PasswordBox.Click();
            PasswordBox.SendKeys(user.Password);
            SubmitButton.Click();


            return new LoginPage(Driver);
        }


    }
}
