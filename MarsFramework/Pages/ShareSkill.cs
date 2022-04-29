using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;
using MarsFramework.Excel_Data_Reader;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public void CreateShareSkill(IWebDriver driver)
        {
            // click on ShareSkill 
          
            IWebElement shareSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
            shareSkill.Click();
            

            // click on Title
            IWebElement titleTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            string title = ExcelReader.ReadData(1, "Title");
            titleTextBox.SendKeys(title);


            // click on Description 
            IWebElement descriptionText = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            string description = ExcelReader.ReadData(1, "Description");
            descriptionText.SendKeys(description);

            // click on category
            IWebElement dropDownCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
            dropDownCategory.Click();
            string categoryRead = ExcelReader.ReadData(1, "Category");
            dropDownCategory.SendKeys("Programming & Tech");
            dropDownCategory.Click();

           takeScreenShot(driver);

           // click on subcategory
            IWebElement dropDownSubCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            dropDownSubCategory.Click();
            dropDownSubCategory.SendKeys("QA");
            dropDownSubCategory.Click();

            // click on Tags
            IWebElement tagsText = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagsText.Click();
            string tagName = ExcelReader.ReadData(1, "Tags");
            tagsText.SendKeys(tagName);
            tagsText.SendKeys(Keys.Enter);

            // click on service type 
            IWebElement serviceTypeOptions = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div"));
            serviceTypeOptions.Click();

            // click on location type
            Thread.Sleep(2000);
            IWebElement locationTypeOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/label"));
            locationTypeOption.Click();
           
            takeScreenShot(driver);
            


            // click on Avaliable days start date dropdown
            Thread.Sleep(2000);
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            string startDateCol = ExcelReader.ReadData(1, "Start Date");
            startDate.SendKeys(startDateCol);
            startDate.Click();
            Thread.Sleep(2000);


            // click on Avaliable days end date dropdown
            Thread.Sleep(2000);
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            string endDateCol = ExcelReader.ReadData(1, "End Date");
            
            endDate.SendKeys(endDateCol);
            endDate.Click();
            Thread.Sleep(2000);


            //Storing the table of available days
            Thread.Sleep(2000);
            IWebElement Days = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            Days.Click();

            //Storing the starttime dropdown
            Thread.Sleep(2000);
            IWebElement startTimeDropDown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            startTimeDropDown.Click();
            string startTimeCol = ExcelReader.ReadData(1, "Start time");
            startTimeDropDown.SendKeys(startTimeCol);
            startTimeDropDown.Click();

            //Storing the endtime dropdown
            IWebElement endTimeDropDown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            endTimeDropDown.Click();
            string endTimeCol = ExcelReader.ReadData(1, "End time");

            endTimeDropDown.SendKeys(endTimeCol);
            endTimeDropDown.Click();


            //Click on Skill Trade option
            IWebElement skillTradeOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/label"));
            skillTradeOption.Click();


            // Enter skill exchange
            IWebElement skillExchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div[1]/div/div/div/div/input"));
            skillExchange.Click();
            string skillExchangeCol = ExcelReader.ReadData(1, "Skill Exchange");
            skillExchange.SendKeys(skillExchangeCol);
            skillExchange.SendKeys(Keys.Enter);
            

            // AutoIt
            IWebElement workSampleButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            workSampleButton.Click();
            //Thread.Sleep(2000);
            AutoItX3 autoItObj = new AutoItX3();
            autoItObj.WinActivate("Open");
            Thread.Sleep(1000);
            
            autoItObj.Send(@"C:\Users\Priya\OneDrive\Desktop\photo for project.txt");
            Thread.Sleep(1000);
            autoItObj.Send("{Enter}");
            //Thread.Sleep(1000);
            // click on Active option
            IWebElement activeOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/label"));
            activeOption.Click();
            Thread.Sleep(2000);
           
            takeScreenShot(driver);

            //Click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();
           
            Thread.Sleep(2000);
            takeScreenShot(driver);
            Thread.Sleep(1000);



            //check if record is created
            Thread.Sleep(2000);
            IWebElement Category = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
           Thread.Sleep(2000);
            // Option 1
            Assert.That(Category.Text == "Programming & Tech", "Category and expected category do not match");

            
            //Option 2 
            /*if (Category.Text == "Programming & Tech")
            {
                Console.WriteLine("category is created sucessfullly, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }*/

        }

        public void EditShareSkill(IWebDriver driver)
        {                                                 
            // Go to ManageListing Page 
            Thread.Sleep(2000);
            // IWebElement manageListing = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
            IWebElement manageListing = driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));
            manageListing.Click();
            

            // click on  edit icon to edit exiting record
           Thread.Sleep(1000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
            editButton.Click();

            takeScreenShot(driver);


            // click on title to update to new title
            IWebElement titleTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleTextBox.Click();
            titleTextBox.Clear();
            titleTextBox.SendKeys("Software Tester");

            takeScreenShot(driver);

            // click on Description to update to new description
            IWebElement descriptionText = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionText.Click();
            descriptionText.Clear();
            descriptionText.SendKeys("Junior Level");


            
            //Click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();

            

            //check if Title record is created
            Thread.Sleep(2000);
            IWebElement Title = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
            
            //option 1 
            Assert.That(Title.Text == "Software Tester", "Title and expected Title do not match");

           /* // check if Description record is created
            Thread.Sleep(1000);
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));

           //option 1
            Assert.That(Description.Text == "Junior Level", "Description and excepted Description do not match");*/

        }

        public void DeleteShareSkill(IWebDriver driver)
        {
            // Go to ManageListing Page 
            //Thread.Sleep(2000);
            //IWebElement manageListing = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
            driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]")).Click();
           // Thread.Sleep(1000);

            // click on delete button 
            Thread.Sleep(1000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]"));
            deleteButton.Click();

            takeScreenShot(driver);

            // click yes for confirmation 
            IWebElement yesConfirmation = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            yesConfirmation.Click();

        }


        public void takeScreenShot(IWebDriver driver)
        {
            string screenshotFileName = Directory.GetParent(@"../../../").FullName
                 + Path.DirectorySeparatorChar + "Screenshot"
                 + Path.DirectorySeparatorChar + "Screentshot_" + DateTime.Now.ToString("ddMMyyyy HHmmss") + ".png";

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Png);
        }

    }
}        