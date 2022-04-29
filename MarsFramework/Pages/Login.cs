using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsFramework.Excel_Data_Reader;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsFramework.Pages
{
    internal class Login
    {
        public void LoginSteps(IWebDriver driver)
        {
           
            //lauch turnup portal
           // driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
                       

            try
            {

                // click on signInbutton
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signInButton.Click();

                //  identify emailaddress and enter valid details
                IWebElement emailaddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                string userName = ExcelReader.ReadData(2, "UserName");
                emailaddress.SendKeys(userName);

                //  identify password and enter valid details
                IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                string Password = ExcelReader.ReadData(2, "Password");
                password.SendKeys(Password);

                // click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
                Assert.Fail("login page did not launch");
                throw;
            }



        }

    }
}
