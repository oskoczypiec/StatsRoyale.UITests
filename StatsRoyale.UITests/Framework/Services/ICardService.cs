using StatsRoyale.UITests.Framework.Models;

namespace StatsRoyale.UITests.Framework.Services
{
    public interface ICardService
    {
        Card GetCardByName(string cardName);
    }
}
