using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MarsFramework.Excel_Data_Reader;
using MarsFramework.Pages;
using MarsFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;


namespace MarsFramework
{
    [TestFixture]
    internal class Class1:CommonDriver
    {

        [Test, Order(1)]
        public void ExcelReaderMethod()
        {
            try
            {
                ExcelReader.ClearData();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        [Test, Order(2)]
        public void CreateShareSkill() 
        {
           
            ExcelReader.ReadDataTable(stream, "ShareSkill");
            try
            {
               // ExtentTest test = null;
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

        
        [Test, Order(3)]
        public void EditShareSkill()
        {
            try
            {
               // ExtentTest test = null;
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

        
        [Test, Order(4)]
        public void DeleteShareSkill_Test()
        {
            try
            {

                //ExtentTest test = null;
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

      
    }
}
