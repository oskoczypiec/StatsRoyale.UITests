using StatsRoyale.UITests.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsRoyale.UITests.Framework.Services
{
    public interface ICardService
    {
        Card GetCardByName(string cardName);
    }
}
