using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sqanewpro.POM.LOGIN;
using Sqanewpro.POM.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqanewpro.POM.Select
{
    [TestClass]
    public class selectTC : execution
    {
        login lg = new login();
        search sh = new search();
        select st = new select();


        [TestMethod]
       

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "Login", DataAccessMethod.Sequential)]

        public void selectTC001()

        {

            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            lg.username = user;
            lg.password = pass;

            lg.login_method(lg.username, lg.password);
            sh.Searchmethod();
            st.Selectmethod();
        }
    }
}
