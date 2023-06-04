using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sqanewpro.POM.LOGIN
{
    public class loginhrm : Base
    {
        //  #region Locators
        By usernameTXT = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input");
        By passwordTXT = By.Name("password");
        By loginBTN = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");


        //methods
        #region Properties
        public string username { get; set; }
        public string password { get; set; }

        #endregion
        public void login_method(string txtUsername, string txtPassword)
        {

            write(usernameTXT, username);
            write(passwordTXT, password);
            Click(loginBTN);
            Thread.Sleep(3000);

        }
    }
}
