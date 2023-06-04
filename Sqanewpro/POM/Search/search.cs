using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sqanewpro.POM.Search
{
    public class search : Base
    {
        //locator
        By locationTXT = By.Id("location");
        By hotelTXT = By.Id("hotels");
        By roomtypeTXT = By.Id("room_type");
        By norTXT = By.Id("room_nos");
        By checkinTXT = By.Id("datepick_in");
        By chechoutTXT = By.Id("datepick_out");
        By adultperroomTXT = By.Id("adult_room");
        By childrenperroomTXT = By.Id("child_room");
        By submitBTN = By.Id("Submit");

        //methods
        public string CheckIN { get; set; }
        public string CheckOUT { get; set; }
     
        public void Searchmethod() 
        {

            Click(locationTXT);
            write(locationTXT, "S");
            Thread.Sleep(4000);
            Click(hotelTXT);
            Click(roomtypeTXT);
            Click(norTXT);
            write(checkinTXT,"04/12/21");
            write(chechoutTXT, "23/12/21");
            Thread.Sleep(4000);
            Click(adultperroomTXT);
            Click(childrenperroomTXT);
            Click(submitBTN);
            Thread.Sleep(4000);


        }

    }
}
