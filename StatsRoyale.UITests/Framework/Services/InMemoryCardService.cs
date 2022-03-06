using StatsRoyale.UITests.Framework.Models;

namespace StatsRoyale.UITests.Framework.Services
{
    public class InMemoryCardService : ICardService
    {
        public Card GetCardByName(string cardName)
        {
            switch (cardName)
            {
                case "Dart Goblin":
                    return new DartGoblinCard();
                case "Mega Minion":
                    return new MegaMinionCard();
                case "Ice Spirit":
                    return new IceSpiritCard();
                default:
                    throw new ArgumentException($"Card is not available: {cardName}");
                
            }
        }
    }
}
