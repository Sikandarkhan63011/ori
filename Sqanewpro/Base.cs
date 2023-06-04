using AutoIt;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Safari;
using SikuliModule;
using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using System.Net.NetworkInformation;

namespace Sqanewpro
{

    public class Base
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath = "C:\\TestExecutionReport\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\\";
        public static IWebDriver driver;

        public IWebDriver SeleniumInit(string browser)
        {
            driver = null;
            if (browser == "Chrome")
            {
                return driver = new ChromeDriver();
            }
            else if (browser == "FireFox")
            {
                return driver = new FirefoxDriver();
            }
            else if (browser == "IE")
            {
                return driver = new InternetExplorerDriver();
            }
            else if (browser == "Edge")
            {
                return driver = new EdgeDriver();
            }
            else if (browser == "Safari")
            {
                return driver = new SafariDriver();
            }
            return driver;
        }
        public void ExecuteBrowser(string browser)
        {
            SeleniumInit(browser);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }
        public void write(By by, string val)
        {
            try
            {
                driver.FindElement(by).SendKeys(val);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Action Unsuccessful" + ex.Message);
            }
        }
        public void Click(By locator)
        {
            driver.FindElement(locator).Click();

        }

        public void Check(string expected , string actual) 
        {
                
            
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                TakeScreenshot();
                Assert.AreEqual(expected, actual);
            }

        }
        public static void TakeScreenshot()
        {
            string path = "E:\\Coding\\Sqanewpro\\Sqanewpro\\bin\\Debug\\ScreenShot\\myscreen.png" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);

        }
        public static void LogReport(string testcase)
        {
            //dirpath = @"C:\\TestExecutionReport\\" + '_' + testcase;
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

            #region LogReport
            htmlReporter.Config.DocumentTitle = "Automation Test Project";
            //htmlReporter.Config.ReportName = "TestReport" + currentDateAndTime;
            htmlReporter.Config.Theme = Theme.Dark;

            extentReports = new ExtentReports();
            extentReports.AttachReporter(htmlReporter);

            extentReports.AddSystemInfo("AUT", "Hotel Adactin");
            extentReports.AddSystemInfo("Enviorment", "QA");
            extentReports.AddSystemInfo("Machine", Environment.MachineName);
            extentReports.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            #endregion
        }
        public void NodeCreation(string methodName)
        {
            exChildTest = exParentTest.CreateNode(methodName);
        }
        public static void ExtentFlush()
        {
            extentReports.Flush();
        }
        
    }


}

