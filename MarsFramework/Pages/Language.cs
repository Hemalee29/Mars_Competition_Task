//using MarsFramework.Global;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MarsFramework.Pages
//{
//    internal class Langauge
//    {
//        private int dataRow;
//        public Langauge()
//        {
//            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
//        }

//        //Click on Langauge tab
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
//        private IWebElement ClickLangaugetab { get; set; }

//        //Add new button
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
//        private IWebElement Addnewbutton { get; set; }

//        //Add Langauge
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
//        private IWebElement AddLangauge { get; set; }

//        //Choose Langauge
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
//        private IWebElement SelectLanguage { get; set; }

//        //Dropdown value
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")]
//        private IWebElement Basic { get; set; }

//        //Click Add button
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
//        private IWebElement AddnewButton { get; set; }

//        //Edit Language



//        //Click Edit button
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")]
//        private IWebElement ClickEditButton { get; set; }

//        //Edit Language
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")]
//        private IWebElement EditLangauge { get; set; }

//        //Edit Dropdown

//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")]
//        private IWebElement EditDropdown { get; set; }

//        //Dropdown value
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]")]
//        private IWebElement Conversetional { get; set; }

//        //Update button
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
//        private IWebElement Updatebutton { get; set; }

//        //Delete
//        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")]
//        private IWebElement Deletebutton { get; set; }


//        internal void Langauge_Add(int dataRow)
//        {
//            Thread.Sleep(2000);
//            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");

//            ClickLangaugetab.Click();
//            Addnewbutton.Click();
//            AddLangauge.Click();
//            AddLangauge.SendKeys(GlobalDefinitions.ExcelLib.ReadData(dataRow, "Language"));
//            //Langauge.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
//            SelectLanguage.Click();
//            Basic.Click();
//            AddnewButton.Click();



//        }

       
//    }
//}
