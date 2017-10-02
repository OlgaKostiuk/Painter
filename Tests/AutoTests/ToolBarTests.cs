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
    class ToolBarTests
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
        public void TestExistToolBar()
        {
            List<Button> tools = new List<Button> { POM.ToolBar.SaveTool, POM.ToolBar.OpenTool,
            POM.ToolBar.NewTool, POM.ToolBar.ReNTool, POM.ToolBar.DelTool};

            foreach (Button btn in tools)
            {
                Assert.AreEqual(true, btn.Enabled);
            }
        }

     /*   [Test]
        public void TestExistToolBar1()
        {
            List<Label> tools = new List<Label> { POM.ToolBar.FileTool, POM.ToolBar.TabTool};

            foreach (Label lbl in tools)
            {
                Assert.AreEqual(true, lbl.Enabled);
            }
        }*/

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}
