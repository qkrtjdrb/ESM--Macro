using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ESM광고Macro.Resources;
using ESM광고Macro.Chrome;

namespace ESM광고Macro.Service
{
    internal class ESM_OnOffManage
    {
        
        public static void OnList(IWebDriver driver, DataGridView drg, int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            try
            {
                ClickXpathButton(driver, XpathLibrary.SimpleGroupTabBtnXpath, timeout);
                ClickXpathButton(driver, XpathLibrary.OpenViewListBtnXpath, timeout);
                ClickXpathButton(driver, XpathLibrary.ViewListAllBtnXpath, timeout);
                WaitUntilTableStable(driver, Config.listsearchtimer);
                ClickXpathButton(driver, XpathLibrary.CheckAllBtnXpath, timeout);
                ClickXpathButton(driver, XpathLibrary.OnBtnXpath, timeout);

                wait.Until(ExpectedConditions.AlertIsPresent());
                BrowserActions.Alertdismiss(driver);
            }
            catch (WebDriverTimeoutException)
            {
                MessageBox.Show("구글 알림 창 팝업 오류 : 페이지 로딩 타이머를 올려주세요 (기본값:10초)");
            }
        }

        public static void OffList(IWebDriver driver, DataGridView drg, int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            try
            {
                ClickXpathButton(driver, XpathLibrary.SimpleGroupTabBtnXpath, timeout);
                ClickXpathButton(driver, XpathLibrary.OpenViewListBtnXpath, timeout);
                ClickXpathButton(driver, XpathLibrary.ViewListAllBtnXpath, timeout);
                WaitUntilTableStable(driver, Config.listsearchtimer);
                ClickXpathButton(driver, XpathLibrary.CheckAllBtnXpath, timeout);
                ClickXpathButton(driver, XpathLibrary.OffBtnXpath, timeout);

                wait.Until(ExpectedConditions.AlertIsPresent());
                BrowserActions.Alertdismiss(driver);
            }
            catch (WebDriverTimeoutException)
            {
                MessageBox.Show("구글 알림 창 팝업 오류 : 페이지 로딩 타이머를 올려주세요 (기본값:10초)");
            }
        }

        public static void AllOn(IWebDriver driver, DataGridView drg, int timeout)
        {
            ESMLogin esmLogin = new ESMLogin();
            int index = 0;
            foreach (var userdata in Userdata.GetAllUserdatas())
            {
                if (driver.FindElements(By.XPath(XpathLibrary.LogoutBtnXpath)).Count > 0)
                {
                    ESMLogin.Logout(driver, timeout);
                }
                esmLogin.Login(driver, userdata, timeout);
                OnList(driver, drg, timeout);
                drg.Rows[index].Cells[2].Value = "ON";
                index++;
                ESMLogin.Logout(driver, timeout);
            }
        }

        public static void Alloff(IWebDriver driver, DataGridView drg, int timeout)
        {
            ESMLogin esmLogin = new ESMLogin();
            int index = 0;
            foreach (var userdata in Userdata.GetAllUserdatas())
            {
                if (driver.FindElements(By.XPath(XpathLibrary.LogoutBtnXpath)).Count > 0)
                {
                    ESMLogin.Logout(driver, timeout);
                }
                esmLogin.Login(driver, userdata, timeout);
                OffList(driver, drg, timeout);
                drg.Rows[index].Cells[2].Value = "OFF";
                index++;
                ESMLogin.Logout(driver, timeout);
            }
        }

        private static void ClickXpathButton(IWebDriver driver, string xpath, int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            var button = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
            button.Click();
        }
        public static void WaitUntilTableStable(IWebDriver driver, int timer)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                wait.Until(d => d.FindElements(By.XPath(XpathLibrary.TableRowsXpath)).Count > 1);
                Thread.Sleep(timer); 
            }
            catch (WebDriverTimeoutException)
            {
                MessageBox.Show("리스트 불러오기 실패");
            }
        }

        public static void CheckGridOn(DataGridView drg)
        {
            if (drg.SelectedRows.Count > 0)
            {
                int selectedRowIndex = drg.SelectedRows[0].Index;
                drg.Rows[selectedRowIndex].Cells[2].Value = "ON";
            }
        }

        public static void CheckGridOff(DataGridView drg)
        {
            if (drg.SelectedRows.Count > 0)
            {
                int selectedRowIndex = drg.SelectedRows[0].Index;
                drg.Rows[selectedRowIndex].Cells[2].Value = "OFF";
            }
        }
    }
}
