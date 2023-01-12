using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.FW
{
    public static class SpecFlowDemoVariable
    {

        public static class DefaultValue
        {
            public const string Empty = "";
            public const string Select = "Select";
            public const string ScenarioId = nameof(ScenarioId);
            public const string ScreenShots = nameof(ScreenShots);
            public const string ScreenShotFormat = ".png";
        }

        public static class XPath_Menus
        { 
            public const string btnAdmin = "(//*[@class='bi bi-grid'])";
            public const string btnChurch = "(//*[@class='fa fa-calendar-check'])";
            public const string btnQuestions = "(//*[@class='fa fa-question-circle'])";
            public const string btnSection = "(//*[@class='fa fa-plus-square'])";
        }

        public static class XPath_Login
        {
           
            public const string btnSignIn = "(//*[@class='linkedin tsignin'])";
            public const string UserName = "//*[@type='text']";
            public const string Password = "//*[@id='password']";
            public const string SignButton = "//*[@type='submit']"; 


        }
        public static class XPath_Members
        {

            public const string btnSignIn = "(//*[@class='linkedin tsignin'])";
            public const string UserName = "//*[@type='text']";
            public const string Password = "//*[@id='password']";
            public const string SignButton = "//*[@type='submit']";


        }

        public static class XPath_UserDetails
        {
            public const string txtfirstname = nameof(txtfirstname);
            public const string txtlastname = nameof(txtlastname);
            public const string rolename = nameof(rolename);
            public const string txtemail = nameof(txtemail);
            public const string txtpassword = nameof(txtpassword);

            public const string Documentation = "staffDirectoryModel_Documentation";


        } 
        public static class XPath_Button
        {
            public const string btnSave = nameof(btnSave);
            public const string btnCancel = nameof(btnCancel);
            public const string btnAddUser = nameof(btnAddUser);
            public const string btnEditUser = nameof(btnEditUser);
            public const string btnDeleteUser = nameof(btnDeleteUser);
            public const string mdRequestbtn = nameof(mdRequestbtn);

            public const string Login = nameof(Login);

        }

    }
}
