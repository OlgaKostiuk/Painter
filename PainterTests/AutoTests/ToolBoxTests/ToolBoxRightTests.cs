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
    class ToolBoxRightTests
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
        public void TestExistToolBoxRight()
        {
            List<Button> txtBtns = new List<Button> { POM.ToolBoxRight.SaveBtn, POM.ToolBoxRight.LoadBtn, POM.ToolBoxRight.RectBtn, POM.ToolBoxRight.RRectBtn,
            POM.ToolBoxRight.CurvBtn, POM.ToolBoxRight.LineBtn, POM.ToolBoxRight.EllipsBtn};
            List<GroupBox> groupbox = new List<GroupBox> { POM.ToolBoxRight.PropGB, POM.ToolBoxRight.FileGB };

            foreach (Button btn in txtBtns)
            {
                Assert.AreEqual(true, btn.Enabled);
            }

            foreach (GroupBox gb in groupbox)
            {
                Assert.AreEqual(true, gb.Enabled);
            }
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}
