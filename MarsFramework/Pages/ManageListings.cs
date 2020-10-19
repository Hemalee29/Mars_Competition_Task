using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings:ShareSkill
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        ////Click on edit button


        //[FindsBy(How = How.XPath, Using = "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i]";
        //private IWebElement Editbutton { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

       

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
       

        private IWebElement edit { get; set; }

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
        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

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

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }



        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")]
        private IWebElement deleteBtn { get; set; }

        //Click yes on alert button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement AlertYes { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Check for Title in manage list
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")]
        private IWebElement getTitle { get; set; }

        //Check for Des in manage list
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")]
        private IWebElement getDes { get; set; }

        //Check for catgory in manage list
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")]
        private IWebElement getcategory { get; set; }
        //
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/thead/tr/th[3]")]
        private IWebElement CheckRow { get; set; }

        //
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[")]
        private IWebElement beforeCheckRow { get; set; }

        //
        [FindsBy(How = How.XPath, Using = "]/td[3]")]
        private IWebElement afterCheckRow { get; set; }

        internal void GoToManageListing()
        {
            Thread.Sleep(2000);
            manageListingsLink.Click();
            


        }
        internal void CheckRecordAddorNot(int dataRow)
        {
            Thread.Sleep(2000);
            //Initialize Excel file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SkillDetails");
            string actualText = GlobalDefinitions.ExcelLib.ReadData(dataRow, "Title");
            string actualDes = GlobalDefinitions.ExcelLib.ReadData(dataRow, "Description");
            string actualcatgory = GlobalDefinitions.ExcelLib.ReadData(dataRow, "Category");
            if (getTitle.Text == actualText && getDes.Text == actualDes && getcategory.Text == actualcatgory)
            {
                Assert.Pass("Record is  Added ", "Test Pass");
            }
            else
            {
                Assert.Fail("Record is not Added successfuly", "Test Fail");
            }
        }
        internal void ClickOnEditButton()
        {
            Thread.Sleep(5000);
            edit.Click();


        }


        internal void Edit_InputData(int dataRow)
        {
            Thread.Sleep(2000);
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            Thread.Sleep(2000);

            //CategoryDropDown.Clear();
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            //CategoryDropDown.Click();

            Thread.Sleep(2000);
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            SubCategoryDropDown.Click();
            Tags.Clear();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            Tags.Click();

            //Edit Service Type
            Thread.Sleep(2000);
            string ServiceType = GlobalDefinitions.ExcelLib.ReadData(dataRow, "ServiceType");
            if (ServiceType == "Hourly basis service")
            {
                ServiceHourly.Click();
                


            }
            else
            {

                ServiceOneOff.Click();
            }


            //Edit Location Type
            Thread.Sleep(2000);
            string LocationType = GlobalDefinitions.ExcelLib.ReadData(dataRow, "LocationType");
            if (LocationType == "Online")
            {
                LocationOnline.Click();
                
            }
            else
            {
                LocationOnSite.Click();
            }

            //Date and  time

            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            // Fill End Date
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));

           

            //Days.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Selectday"));

            //StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "Startdate") + Keys.Enter);
            //StartDateDropDown.Click();
            //EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "Enddate") + Keys.Enter);
            //EndDateDropDown.Click();




            StartTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "StartTime") + Keys.Enter);
            StartTimeDropDown.Click();
            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "EndTime") + Keys.Enter);
            EndTimeDropDown.Click();

            SkillExchange.Click();
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "Skill-Exchange") + Keys.Enter);
            ActiveOption.Click();
            Thread.Sleep(2000);

        }


        internal void EditManageListing(int dataRow)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Edit_InputData(dataRow);


            Save.Click();

            Thread.Sleep(2000);
        }

        internal void CheckRecordEdited(int dataRow)
        {
            Thread.Sleep(2000);
            //Initialize Excel file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            string actualText = GlobalDefinitions.ExcelLib.ReadData(dataRow, "Title");
            if (getTitle.Text == actualText)
            {
                Assert.Pass("Record is Edited successfuly", "Test Pass");
            }
            else
            {
                Assert.Pass("Record is not Edited ", "Test Fail");
            }
        }

        internal void DeleteRecordIfExist(int dataRow)
        {
            // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")  , 10);
            //Get Title From Excel to check record
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            string getTitle = GlobalDefinitions.ExcelLib.ReadData(dataRow, "Title");
            int CheckRow = GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr")).Count();

            for (int i = 1; i <= CheckRow; i++)
            {
                IWebElement CheckString = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]"));

                if (CheckString.Text == getTitle)
                {
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[3]/i")).Click();
                    AlertYes.Click();
                    break;
                }
            }
        }
        internal void ClickOnDeleteBtn()
        {
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"), 2);
            deleteBtn.Click();
            AlertYes.Click();
        }

        internal void DeleteManageListing()
        {
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(2000);
            ClickOnDeleteBtn();



        }

        internal void CheckRecordDeleted(int dataRow)
        {
            Thread.Sleep(5000);
            //Initialize Excel file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            string actualText = GlobalDefinitions.ExcelLib.ReadData(dataRow, "Title");
            if (getTitle.Text != actualText)
            {
                Assert.Pass("Record is Delete successfuly", "Test Pass");
            }
            else
            {
                Assert.Pass("Record is not Deleted", "Test Fail");

            }
        }
    }
}
