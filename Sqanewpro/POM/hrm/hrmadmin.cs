using AutoIt;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sqanewpro.POM.hrm
{
    public class hrmadmin : Base
    {
        //locators
        By adminLBL = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");
        //delete record
        By deleterecBTN = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div[1]/div/div[6]/div/button[1]");
        By deleteBTN = By.XPath("//*[@id=\"app\"]/div[3]/div/div/div/div[3]/button[2]");
        By nameTXT = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input");
        By empNameTXT = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div/div/input");
        By pimLBL = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");
        By uploadBTN = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div[1]/div/div[2]/div/button");
        By addempBTN = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");


        //

        //methods
        #region Properties



        #endregion
        public void admin_method_dlt()
        {

            Click(adminLBL);
            Thread.Sleep(2000);
           
            Click(deleterecBTN);
            Thread.Sleep(2000);
            Click(deleteBTN);
            Thread.Sleep(3000);
        }

        public void admin_method_search(string txtuser, string txtempname) 
        {
            Click(adminLBL);
            Thread.Sleep(2000);
            write(nameTXT, txtuser);
            write(empNameTXT, txtempname);
            Thread.Sleep(2000);

        }

        public void PIM_uploadimage()
        {
            Click(pimLBL);
            Thread.Sleep(2000);
            Click(addempBTN);
            Thread.Sleep(2000);

            Click(uploadBTN);
            
            Thread.Sleep(2000);
            AutoItX.Send("C:\\Users\\KAMRAN TRADER`s\\Downloads\\DSC_0001.JPG");
            AutoItX.Send("{Enter}");
            Thread.Sleep(2000);


        }
    }
}

