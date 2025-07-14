using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static System.Windows.Forms.Design.AxImporter;
using ESM광고Macro.Resources;
using ESM광고Macro.Chrome;

namespace ESM광고Macro.Service

{
    internal class ESMLogin
    {
        
        public void Login(IWebDriver driver, Userdata userdata, int timer) //자동으로 광고관리 페이지 까지 이동
        {
            BrowserActions.GotoURL(driver, PageUrls.LoginUrl , timer);
            PerformLogin(driver, userdata, timer);
            BrowserActions.GotoURL(driver, "https://ad.esmplus.com/cpc/bidmng/bidmanagement", timer);
        }

        private void PerformLogin(IWebDriver driver, Userdata userdata, int timer) //실제 로그인 자동 수행 함수
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timer));
            try
            {
                var idInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SellerId")));
                idInput.SendKeys(userdata.GetUserID());

                var pwdInput = driver.FindElement(By.Id("SellerPassword"));
                pwdInput.SendKeys(userdata.GetUserPassWord());

                var loginBtn = driver.FindElement(By.XPath(XpathLibrary.LoginBtnXpath));
                loginBtn.Click();
            }
            catch (WebDriverTimeoutException)
            {
                MessageBox.Show("로그인 실패");
            }
        }


        public void GridLogin(IWebDriver driver, DataGridView grd, int timer) //그리드 선택을 통해 로그인
        {
            // 선택된 행이 없거나 유효하지 않은 경우 예외 처리
            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("로그인할 사용자를 선택하세요.");
                return;
            }
            int selectedRowIndex = grd.SelectedRows[0].Index;
            if (selectedRowIndex < 0 || selectedRowIndex >= grd.Rows.Count)
            {
                MessageBox.Show("유효하지 않은 선택입니다.");
                return;
            }

            List<Userdata> allUsers = Userdata.GetAllUserdatas();
            Userdata selectedUser = allUsers[selectedRowIndex];
            Login(driver, selectedUser, timer);
        }
        public static void Logout(IWebDriver driver, int timer)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timer));
            driver.FindElement(By.XPath(XpathLibrary.LogoutBtnXpath)).Click();
            wait.Until(ExpectedConditions.UrlContains("https://ad.esmplus.com/Member/SignIn/LogOn?ReturnValue=-9"));
        }

        public void AutoLoginOut(IWebDriver driver, DataGridView grd, int timer)
        {
            try
            {
                Logout(driver, timer);
                Thread.Sleep(1000);
                GridLogin(driver, grd, timer);

            }
            catch (Exception)
            {
                Thread.Sleep(1000);
                GridLogin(driver, grd, timer);
            }
        }
    }
}
