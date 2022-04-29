using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using MarsFramework.Excel_Data_Reader;
using OpenQA.Selenium;
using MarsFramework.Pages;
using OpenQA.Selenium.Chrome;

namespace MarsFramework.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public static string screenshotDirectory;
        public static ExtentReports extentreportobj;
        public static ExtentTest test;
        public static ExtentHtmlReporter htmlReporter;
        public static FileStream stream;





        [OneTimeSetUp]
        public void LoginFunction()
        {


            string fileName = @"C:\Users\Priya\source\IC\MarsFramework\MarsFramework\ExcelReaderDetails.xlsx";

            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelReader.ReadDataTable(stream, "LoginSheet");

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

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            extentreportobj.Flush();
            driver.Close();
            driver.Quit();

        }
    }
}

   
