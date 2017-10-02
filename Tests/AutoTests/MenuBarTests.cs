using System;
using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.ListViewItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System.Collections.Generic;

namespace UnitTestProject1.AutoTests
{
    [TestFixture]
    class MenuBarTests
    {
        Window window = null;
        [SetUp]
        public void StartUp()
        {
            Application application = Application.Launch(POM.AppPath);
            window = application.GetWindow(POM.WindowName, InitializeOption.NoCache);
            POM.Window = window;
        }

        [Test]
        public void TestExistMenuBar()
        {
            List<Menu> menues = new List<Menu> { POM.MenuBar.FileMenu, POM.MenuBar.TabMenu, POM.MenuBar.PagesMenu, POM.MenuBar.LanguageMenu,
            POM.MenuBar.FigurePluginsMenu, POM.MenuBar.FormatPluginsMenu, POM.MenuBar.CloudMenu, POM.MenuBar.SkinsMenu, POM.MenuBar.HelpMenu};
            foreach (Menu menu in menues)
            {
                Assert.AreEqual(true, menu.Enabled);
            }
        }

        [Test]
        public void TestFileMenu()
        {
            POM.MenuBar.FileMenu.Click();
            Assert.AreEqual(true, POM.MenuBar.SOpenMenu.Enabled);
            Assert.AreEqual(true, POM.MenuBar.SSaveMenu.Enabled);
            Assert.AreEqual(true, POM.MenuBar.SExitMenu.Enabled);
        }

        [Test]
        public void TestTabMenu()
        {
            POM.MenuBar.TabMenu.Click();
            Assert.AreEqual(true, POM.MenuBar.SNewTMenu.Enabled);
            Assert.AreEqual(true, POM.MenuBar.SRenTMenu.Enabled);
            Assert.AreEqual(true, POM.MenuBar.SCloseTMenu.Enabled);
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}
