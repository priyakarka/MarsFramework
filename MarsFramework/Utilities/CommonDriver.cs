using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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

    }

   
}
