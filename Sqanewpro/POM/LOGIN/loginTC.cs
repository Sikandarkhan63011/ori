using AutoIt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace Sqanewpro.POM.LOGIN
{
    [TestClass]
    public class loginTC : execution
    {
       
        login lg = new login();

       
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","XMLFile1.xml","Login",DataAccessMethod.Sequential)]
        public void validlogin()
        {
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            lg.username = user;
            lg.password = pass;
          

            lg.login_method(lg.username, lg.password);
            Thread.Sleep(4000);
            string success = driver.FindElement(By.Id("username_show")).GetAttribute("value");
            Check("Hello tester777!",success);
            //Assert.AreEqual("Hello tester777!",success);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void Invalidlogin()
        {
            string user = TestContext.DataRow["wrongusername"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            lg.username = user;
            lg.password = pass;


            lg.login_method(lg.username, lg.password);
            Thread.Sleep(4000);
            string error = driver.FindElement(By.PartialLinkText("Click here")).Text;
            Check("Click here", error);
            //Assert.AreEqual("Hello tester777!",success);

        }
    }
}
