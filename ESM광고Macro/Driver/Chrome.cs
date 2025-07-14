using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ESM광고Macro.Chrome
{
    internal class BrowserActions
    {
        public static void GotoURL(IWebDriver driver, string url, int timer)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timer));
            try
            {
                driver.Navigate().GoToUrl(url);
                wait.Until(ExpectedConditions.UrlContains(url));
            }
            catch (WebDriverTimeoutException)
            {
                MessageBox.Show($"{url} 페이지 로드 실패");
            }
        }

        public static void Alertdismiss(IWebDriver driver)
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Dismiss(); // 또는 alert.Accept();
            }
            catch (NoAlertPresentException)
            {
                // 알림창이 없는 경우 무시
            }
        }

        public static IWebDriver ChromeESMStart()
        {
            //Botcheckremove.botcheckremove();

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(service, options);
            driver.Navigate().GoToUrl("https://ad.esmplus.com/cpc/bidmng/bidmanagement");



            return driver;
        }
    }
}

