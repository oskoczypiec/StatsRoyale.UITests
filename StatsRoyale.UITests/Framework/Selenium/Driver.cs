using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StatsRoyale.UITests.Framework.Selenium
{
    public static class Driver
    {
        [ThreadStatic]
        public static IWebDriver _driver;

        public static void Init()
        {
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }

        internal static IWebElement FindElement(By by)
        {
            return Current.FindElement(by);
        }

        public static IWebDriver Current => _driver==null ? throw new NullReferenceException("Initialize the driver first!") : _driver;
        
    }
}
