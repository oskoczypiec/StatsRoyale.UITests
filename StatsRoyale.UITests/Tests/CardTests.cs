using NUnit.Framework;
using StatsRoyale.UITests.Framework.Selenium;
using StatsRoyale.UITests.Framework.Services;
using StatsRoyale.UITests.Pages;

namespace StatsRoyale.UITests.Tests
{
    public class CardTests
    {

        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
            Driver.Current.Url= "https://statsroyale.com";
            BasePage basePage = new BasePage();
            basePage.clickAcceptAllCookies();
            basePage.clickCardsLink();
        }
       
        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }

        [Test]
        public void Ice_Spirit_is_on_cards_page()
        {
            CardsPage cardsPage = new CardsPage();
            
            Assert.That(cardsPage.iceSpiritCardIsDisplayed());
            cardsPage.clickCardName("Ice Spirit");
        }

        [Test]
        public void IceSpirit_headers_are_correct_on_card_details_page()
        {
            CardsPage cardsPage = new CardsPage();

            cardsPage.clickCardName("Ice Spirit");
            var currentName= cardsPage.getCardName();
            var currentRarity = cardsPage.getRarity();

            Assert.That(currentName, Is.EqualTo("Ice Spirit"));
            Assert.That(currentRarity, Is.EqualTo("Common"));
        }

        [Test]
        [TestCase("Mega Minion")]
        [TestCase("Dart Goblin")]
        [TestCase("Ice Spirit")]
        [Parallelizable(ParallelScope.Children)]
        public void Mega_Minion_headers_are_correct_on_card_details_page(string cardName)
        {
            CardsPage cardsPage = new CardsPage();

            cardsPage.clickCardName(cardName);

            var currentCard = cardsPage.getBaseCard();
            var expectedCard = new InMemoryCardService().GetCardByName(cardName);
            
            Assert.That(currentCard.Name, Is.EqualTo(expectedCard.Name));
            Assert.That(currentCard.Rarity, Is.EqualTo(expectedCard.Rarity));
        }

    }
}