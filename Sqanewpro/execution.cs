using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqanewpro
{
    [TestClass]
    public class execution : Base
    {
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            LogReport("Test Report");
            Console.WriteLine("AssemblyInitialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            ExtentFlush();
            Console.WriteLine("AssemblyCleanup");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Console.WriteLine("ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            NodeCreation(TestContext.TestName);
            ExecuteBrowser("Chrome");
          //driver.Url="http://adactinhotelapp.com/";
          driver.Url= "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        }

        [TestCleanup]
        public void TestCleanup()
        {
           driver.Quit();
        }
    }
}
