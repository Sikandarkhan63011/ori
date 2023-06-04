using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sqanewpro.POM.Search
{
    public class select :Base
    {
        //locators
        By rdBTN = By.Id("radiobutton_1");
        By submitBTN = By.Id("continue");

        //methods
        public void Selectmethod()
        {
            Click(rdBTN);
            Click(submitBTN);
            Thread.Sleep(4000);
        }
    }
}
