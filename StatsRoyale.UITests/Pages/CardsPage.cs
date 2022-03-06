using OpenQA.Selenium;
using StatsRoyale.UITests.Framework.Models;
using StatsRoyale.UITests.Framework.Selenium;

namespace StatsRoyale.UITests.Pages
{
    public class CardsPage : BasePage
    {

        public IWebElement IceSpiritCard => Driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
        public IWebElement Card(string name) => Driver.FindElement(By.CssSelector($"a[href*='{name}']"));
        public IWebElement CardName => Driver.FindElement(By.CssSelector(".card__cardName"));
        public IWebElement CardRarity => Driver.FindElement(By.CssSelector(".card__count :nth-child(1)"));



        public void clickIceSpiritCard()
        {
            IceSpiritCard.Click();
        }

        public bool iceSpiritCardIsDisplayed()
        {
            return IceSpiritCard.Displayed;
        }

        public void clickCardName(string name)
        {
            if(name.Contains(" "))
            {
                name = name.Replace(" ", "+");
            }
            Card(name).Click();
        }

        public string getCardName()
        {
            return CardName.Text;
        }

        public string getRarity()
        {
            return CardRarity.Text;
        }

        public Card getBaseCard()
        {
            return new Card
            {
                Name = CardName.Text,
                Rarity = CardRarity.Text
            };
        }

    }
}
