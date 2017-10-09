using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Painter.Views;
using System.Windows.Forms;
using PainterTests.UnitTests.Mocks;

namespace Tests
{
    [TestFixture]
    public class MenuActionTests
    {
        UXCommand ucommand;
        PMenu menuBar;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        [SetUp]
        public void SetUp()
        {
            ucommand = new UXCommand();
            menuBar = new PMenu();
            menuBar.xcom = ucommand;
        }

        [TestCase("Open", "Open")]
        //  [TestCase("Save", "Save")]
        //   [TestCase("Exit", "Exit")]
        public void TestFileMenuActions(string name, string result)
        {
            ToolStripMenuItem fileItem = menuBar.menuStrip1.Items["File"] as ToolStripMenuItem;
            fileItem.DropDownItems[name].PerformClick();
            NUnit.Framework.Assert.AreEqual(result, ucommand.Result);

        }
    }
}
