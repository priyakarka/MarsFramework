using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MarsFramework.Pages;
using MarsFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MarsFramework.Test
{
    [TestFixture]
    internal class Class1 : CommonDriver
    {

        [OneTimeSetUp]
        public void LoginFunction()
        {
            try
            {
                extentreportobj = new ExtentReports();
                var htmlreporter = new ExtentHtmlReporter(@"C:\Users\Priya\source\IC\MarsFramework\MarsFramework\ExtentReports\Class1.html");
                extentreportobj.AttachReporter(htmlreporter);

                ExtentTest test = null;
                test = extentreportobj.CreateTest("LoginFunction").Info("Test started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                Login loginObj = new Login();
                loginObj.LoginSteps(driver);
                test.Log(Status.Info, "Chrome Browser launched");
                test.Log(Status.Pass, "login  sucessfully, test passed");
            }
            catch
            {
                test.Log(Status.Fail, "login failed");
            }


        }

        [Test] 
        public void ACreateShareSkill() 
        {
            try
            {
                ExtentTest test = null;
                test = extentreportobj.CreateTest("CreateShareSkill").Info("add shareskill testing");
                ShareSkill shareskillObj = new ShareSkill();
                shareskillObj.CreateShareSkill(driver);
                test.Log(Status.Info, "shareskill saved successfully");
                test.Log(Status.Pass, "creatingshareskill saved sucessfully, test passed");

            }
            catch
            {
                test.Log(Status.Fail, "creatingshareskill failed");
            }



        }

        [Test]
        public void BEditShareSkill()
        {
            try
            {
                ExtentTest test = null;
                test = extentreportobj.CreateTest("EditShareSkill").Info("edited shareskill testing");
                ShareSkill shareskillObj = new ShareSkill();
                shareskillObj.EditShareSkill(driver);
                test.Log(Status.Info, "shareskill saved successfully");
                test.Log(Status.Pass, "editedshareskill saved sucessfully, test passed");
            }           
            catch
            {
                test.Log(Status.Fail, "editedshareskill failed");
            }
        }

        [Test]
        public void CDeleteShareSkill_Test()
        {
            try
            {

                ExtentTest test = null;
                test = extentreportobj.CreateTest("DeleteShareSkill").Info("deleted shareskill testing");
                // Delete Shareskill
                ShareSkill shareSkillPageObj = new ShareSkill();
                shareSkillPageObj.DeleteShareSkill(driver);
                test.Log(Status.Info, "shareskill saved successfully");
                test.Log(Status.Pass, "deletedshareskill, test passed");
            }
            catch
            {
                test.Log(Status.Fail, "deletedshareskill failed");
            }
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            extentreportobj.Flush();
           driver.Close();
          driver.Quit();

        }
    }
}
