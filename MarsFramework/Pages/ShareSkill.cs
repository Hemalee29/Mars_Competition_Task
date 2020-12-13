using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using AutoItX3Lib;
using NUnit.Framework;
using System;
using System.IO;
using AutoIt;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        private int dataRow;
        private object getTitle;

        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }




        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Find Service type one-off
        [FindsBy(How = How.XPath, Using = ".//input[@name='serviceType'][@value='1']")]
        private IWebElement ServiceOneOff { get; set; }

        //Find Service type Hourly
        [FindsBy(How = How.XPath, Using = ".//input[@name='serviceType'][@value='0']")]
        private IWebElement ServiceHourly { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Select On-site for location
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationOnSite { get; set; }

        //Select Online for location
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement LocationOnline { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDate { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDate { get; set; }

        //Click on Available date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]")]
        private IWebElement Row1 { get; set; }
        //Click on available days 

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='0']")]
        private IWebElement Sun { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='1']")]
        private IWebElement Mon { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='2']")]
        private IWebElement Tue { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='3']")]
        private IWebElement Wed { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='4']")]
        private IWebElement Thr { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='5']")]
        private IWebElement Fri { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='6']")]
        private IWebElement Sat { get; set; }

        //Click on Start time
        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='0']")]
        private IWebElement SunStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='1']")]
        private IWebElement MonStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='2']")]
        private IWebElement TueStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='3']")]
        private IWebElement WedStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='4']")]
        private IWebElement ThrStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='5']")]
        private IWebElement FriStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='6']")]
        private IWebElement SatStartTime { get; set; }

        // Fill the value in End Time
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='0']")]
        private IWebElement SunEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='1']")]
        private IWebElement MonEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='2']")]
        private IWebElement TueEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='3']")]
        private IWebElement WedEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='4']")]
        private IWebElement ThrEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='5']")]
        private IWebElement FriEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='6']")]
        private IWebElement SatEndTime { get; set; }


        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Select Skill Trade option1
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='true']")]
        private IWebElement SkillTradeOption1 { get; set; }
        //Select Skill Trade option2
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='false']")]
        private IWebElement SkillTradeOption2 { get; set; }

        // Enter amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        ////WorkSample
        //[FindsBy(How = How.XPath, Using = "//*[@id=service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        //private IWebElement FileUpload { get; set; }

        // option1
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='true']")]
        private IWebElement ActiveOption1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='false']")]
        private IWebElement ActiveOption2 { get; set; }

        ////Click on Active/Hidden option
        //[FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        //private IWebElement ActiveOption { get; set; }

        // Add Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement FileUpload { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement Save { get; set; }


        //public object Runtime { get; private set; }




        //Function to navigate Shareskill Page
        internal void GoToShareSkill()
        {
            ShareSkillButton.Click();
        }


        internal void InputData(int dataRow)
        {

            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "Title"));
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "Description"));


        }

        internal void InputCategory(int dataRow)
        {
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);


        }

        internal void Service_Location(int dataRow)
        {
            string ServiceType = GlobalDefinitions.ExcelLib.ReadData(dataRow, "ServiceType");
            if (ServiceType == "Hourly basis service")
            {

                ServiceHourly.Click();

            }
            else
            {

               
                ServiceOneOff.Click();
            }

            string LocationType = GlobalDefinitions.ExcelLib.ReadData(dataRow, "LocationType");
            if (LocationType == "On-site")
            {
                LocationOnSite.Click();
            }
            else
            {
                LocationOnline.Click();
            }




        }

        internal void Avalible_Days_Time_Details(int dataRow)
        {
            DateTime myvalue = DateTime.Now;
            StartDate.SendKeys(myvalue.AddDays(3).ToLongDateString());

            //StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));


            // Fill End Date
            
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));



            //Mon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Select day"));
            Mon.Click();
            Console.WriteLine(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime")).ToString("hh:mmtt"));
            MonStartTime.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime")).ToString("hh:mmtt"));
            //MonStartTime.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime")).ToLongTimeString());
            //DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("HH:mm");

            MonEndTime.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime")).ToString("hh:mmtt"));


            //MonStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime") + Keys.Enter);
            //MonEndTime.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime")).ToLongTimeString());
            //MonEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime") + Keys.Enter);
            

            Tue.Click();
            TueStartTime.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(3, "StartTime")).ToString("hh:mmtt"));

            //MonStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime") + Keys.Enter);
            TueEndTime.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(3, "EndTime")).ToString("hh:mmtt"));
            //MonEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime") + Keys.Enter);

            //TueStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "StartTime"));
            //TueEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "EndTime"));

            

            SkillExchange.Click();
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange") + Keys.Enter);
    

        }
        internal void UploadFile()
        {
            FileUpload.Click();
            AutoItX.WinWait("Open", "File Upload", 1);
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(2000);
            autoIt.Send(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\ExcelData\\abc.txt"));
          //custom path
          //auto IT
            autoIt.Send("{Enter}");
            Thread.Sleep(2000);

        }
        internal void EnterShareSkill(int dataRow)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SkillDetails");
            InputData(dataRow);
            InputCategory(dataRow);
            Service_Location(dataRow);
            Avalible_Days_Time_Details(dataRow);
            UploadFile();
            ActiveOption2.Click();
            
            Save.Click();

            
        }


        



    }
}
