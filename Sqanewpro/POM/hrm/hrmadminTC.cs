using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sqanewpro.POM.LOGIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sqanewpro.POM.hrm
{
    [TestClass]
    public class hrmadminTC : execution
    {

        loginhrm lgh = new loginhrm();
        hrmadmin ahr = new hrmadmin();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "Loginhrm", DataAccessMethod.Sequential)]
        public void deleterecordTC001()
        {
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            lgh.username = user;
            lgh.password = pass;


            lgh.login_method(lgh.username, lgh.password);
            ahr.admin_method_dlt();

        }
        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "Loginhrm", DataAccessMethod.Sequential)]
        public void searchrecordTC001()
        {
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string empname = TestContext.DataRow["empName"].ToString();

            lgh.username = user;
            lgh.password = pass;


            lgh.login_method(lgh.username, lgh.password);

            ahr.PIM_uploadimage();

            //ahr.admin_method_search(user, empname);

        }

        
    }
}
