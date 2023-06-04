using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqanewpro.POM.LOGIN
{
    public class login : Base
    {
        #region Locators
        By usernameTXT = By.Id("username");
        By passwordTXT = By.Id("password");
        By loginBTN = By.Id("login");
        #endregion

        //methods
        #region Properties
        public string username { get; set; }
        public string password { get; set; }
       
        #endregion
        public void login_method(String txtUsername, string txtPassword)
        {
           
            write(usernameTXT, username);
            write(passwordTXT, password);
            Click(loginBTN);
            
        }
    }
}
