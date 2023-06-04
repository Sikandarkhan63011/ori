using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sqanewpro.POM.LOGIN
{
    [TestClass]
    public class loginhrmTC : execution
    {


        loginhrm lgh = new loginhrm();


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "Loginhrm", DataAccessMethod.Sequential)]
        public void validlogin()
        {
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            lgh.username = user;
            lgh.password = pass;


            lgh.login_method(lgh.username, lgh.password);
            Thread.Sleep(4000);
            string success = driver.FindElement(By.ClassName("oxd-userdropdown-name")).Text;
            Check("Paul Collings", success);//Paul Collings
            //Assert.AreEqual("Hello tester777!",success);

        }

    }
}
