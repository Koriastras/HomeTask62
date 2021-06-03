using OpenQA.Selenium;
using HomeTask62.Framework.Models;

namespace HomeTask62.Pages
{
    public class RegistrationPage : BasePage
    {

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameBox => Driver.FindElement(By.CssSelector("input[name = 'username']"));

        private IWebElement PasswordBox => Driver.FindElement(By.CssSelector("input[name = 'password']"));

        private IWebElement FirstNameBox => Driver.FindElement(By.CssSelector("input[name = 'firstname']"));

        private IWebElement LastNameBox => Driver.FindElement(By.CssSelector("input[name = 'lastname']"));
        private IWebElement SubmitButton => Driver.FindElement(By.XPath("//input[@value = 'Submit']"));

        public CheckInfoPage EntryRegistrationData(User user)
        {
            UsernameBox.Click();
            UsernameBox.SendKeys(user.Username);
            PasswordBox.Click();
            PasswordBox.SendKeys(user.Password);
            FirstNameBox.Click();
            FirstNameBox.SendKeys(user.FirstName);
            LastNameBox.Click();
            LastNameBox.SendKeys(user.LastName);
            SubmitButton.Click();

            return new CheckInfoPage(Driver);
        }

    }
}