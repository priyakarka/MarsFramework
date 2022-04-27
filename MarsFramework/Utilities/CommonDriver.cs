using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
/*using MarsFramework.ExcelDataReader;*/
using OpenQA.Selenium;

namespace MarsFramework.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public static string screenshotDirectory;
        public static ExtentReports extentreportobj;
        public static ExtentTest test;
        public static ExtentHtmlReporter htmlReporter;
      
        
        /*public void ExcelReaderMethod()
        {
            try
            {
                string fileName = @"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\ExcelDataReader\TestData.xlsx";
                FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                ExcelOperations.ReadDataTable(stream, "LoginSheet");
                Console.WriteLine("***************************");
                ExcelOperations.ReadDataTable(stream, "ShareSkill");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }*/
    }
   


}
