using OpenQA.Selenium;


namespace HomeTask62.Pages
{
    public class CheckInfoPage : BasePage
    {
        public CheckInfoPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement Table => Driver.FindElement(By.XPath("//*[@style = 'width:100%']//child::tr//th"));
        

        public string GetTable()
        {
            return Table.Text;
        }

        private IWebElement Title => Driver.FindElement(By.TagName("h1"));

        public string GetTitle()
        {
            return Title.Text;
        }

    }
}