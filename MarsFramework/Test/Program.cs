using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            
            [Test, Order(1)]
            public void AddShareSkillDetails()
            {
                Thread.Sleep(3000);
                test = extent.StartTest("AddShareSkill_Test");
                //Add Share skill details on page
                ShareSkill _shareSkill = new ShareSkill();
                _shareSkill.GoToShareSkill();
                _shareSkill.EnterShareSkill(2);
                ManageListings _manageListings = new ManageListings();
                _manageListings.GoToManageListing();
                _manageListings.CheckRecordAddorNot(2);



            }

            [Test, Order(2)]
            public void EditShareSkillDetails()
            {
                Thread.Sleep(3000);
                test = extent.StartTest("EditShareSkill_Test");

                //Add Share skill details on page
                ManageListings _manageListings = new ManageListings();
                _manageListings.GoToManageListing();
                _manageListings.ClickOnEditButton();
                _manageListings.EditManageListing(2);
                _manageListings.GoToManageListing();
                _manageListings.CheckRecordEdited(2);

            }
            [Test, Order(3)]
            public void DeleteShareSkillDetails()
            {
                Thread.Sleep(3000);
                test = extent.StartTest("DeleteShareSkill_Test");
                //Add Share skill details on page
                ManageListings _manageListings = new ManageListings();
                Thread.Sleep(2000);
                _manageListings.GoToManageListing();
                _manageListings.DeleteManageListing();
                _manageListings.CheckRecordDeleted(3);



            }

            //[Test, Order(4)]
            //public void Langauge_Add()
            //{
            //    Thread.Sleep(2000);
            //    Langauge _Language = new Langauge();
            //    _Language.Langauge_Add(2);

            //}
        }

    }
}