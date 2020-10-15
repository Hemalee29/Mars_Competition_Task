using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void AddShareSkillDetails()
            {
                Thread.Sleep(3000);

                //Add Share skill details on page
                ShareSkill _shareSkill = new ShareSkill();
                _shareSkill.GoToShareSkill();
                _shareSkill.EnterShareSkill(2);

                ////Check Record is add
                //ManageListings _manageListing = new ManageListings();
                //_manageListing.GoToManageList();
                //_manageListing.CheckRecordAdded();

            }

            [Test]
            public void EditShareSkillDetails()
            {
                Thread.Sleep(3000);

                //Add Share skill details on page
                ManageListings _manageListings = new ManageListings();
                _manageListings.GoToManageListing();
                _manageListings.ClickOnEditButton();
                _manageListings.EditManageListing(2);

            }
            [Test]
            public void DeleteShareSkillDetails()
            {
                Thread.Sleep(3000);

                //Add Share skill details on page
                ManageListings _manageListings = new ManageListings();
                Thread.Sleep(2000);
                _manageListings.GoToManageListing();
                _manageListings.DeleteManageListing();
                _manageListings.CheckRecordDeleted(3);



            }

        }

    }
}