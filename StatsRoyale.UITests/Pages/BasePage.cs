using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StatsRoyale.UITests.Framework.Selenium;

namespace StatsRoyale.UITests.Pages
{

    public class BasePage
    {
      
        private IWebDriver driver;

        private By
            cardsLink = By.CssSelector("a[href='/cards']"),
            acceptAllCookies = By.Id("cmpbntyestxt");


        public BasePage()
        {
            this.driver = Driver.Current;
        }

        public void isCookieConsentVisible()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(acceptAllCookies).Displayed);
        }

        public void clickAcceptAllCookies()
        {
            isCookieConsentVisible();
            driver.FindElement(acceptAllCookies).Click();
        }
        public void clickCardsLink()
        {
            driver.FindElement(cardsLink).Click();
        }
    }
}
