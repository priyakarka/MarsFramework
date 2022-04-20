﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            Login loginObj = new Login();
            loginObj.LoginSteps(driver);

        }
        [Test]
        public void A_CreateShareSkill()
        {
            ShareSkill shareskillObj = new ShareSkill();
            shareskillObj.CreateShareSkill(driver);
        }

        [Test]
        public void B_EditShareSkill()
        {


            ShareSkill shareskillObj = new ShareSkill();
            shareskillObj.EditShareSkill(driver);
        }

        [Test]
        public void C_DeleteShareSkill_Test()
        {
            // Delete Shareskill
            ShareSkill shareSkillPageObj = new ShareSkill();
            shareSkillPageObj.DeleteShareSkill(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {



        }
    }
}