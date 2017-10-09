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
            //Application application = Application.Launch(POM.AppPath);
            //window = application.GetWindow(POM.WindowName, InitializeOption.NoCache);
            //POM.Window = window;
          //  Application application = Application.Launch(@".\TestFormCreator\bin\Debug\TestFormCreator");
            Application application = Application.Launch(@"E:\work\AllPainters\WinForms\forVladYaroslav\GIT\Painter\TestFormCreator\bin\Debug\TestFormCreator");
            window = application.GetWindow("Form1", InitializeOption.NoCache);
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
            //POM.MenuBar.FileMenu.Click();
            //Assert.AreEqual(true, POM.MenuBar.SOpenMenu.Enabled);
            //Assert.AreEqual(true, POM.MenuBar.SSaveMenu.Enabled);
            //Assert.AreEqual(true, POM.MenuBar.SExitMenu.Enabled);
            TestMenuClick(POM.MenuBar.SSaveMenu, "Save");
            TestMenuClick(POM.MenuBar.SOpenMenu, "Open");
            TestMenuClick(POM.MenuBar.SExitMenu, "Exit");
        }

        [Test]
        public void TestTabMenu()
        {
            POM.MenuBar.TabMenu.Click();
            Assert.AreEqual(true, POM.MenuBar.SNewTMenu.Enabled);
            Assert.AreEqual(true, POM.MenuBar.SRenTMenu.Enabled);
            Assert.AreEqual(true, POM.MenuBar.SCloseTMenu.Enabled);
        }

        private void TestMenuClick(Menu menu, string result)
        {
            menu.Click();

            if (window.GetElement(SearchCriteria.ByText(result)).Current.Name == result)
                window.Get<Button>(SearchCriteria.ByText("OK")).Click();
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}
