using Painter.Commands;
using Painter.Commands.Actions;
using PainterTests.UnitTests.Mocks;
using System;

namespace Actions
{
    internal class ActionSelectTab : IActionSelectTab
    {
        IXCommand cmd;
        public ActionSelectTab(IXCommand cmd)
        {
            this.cmd = cmd;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            (cmd as UXCommand).Result = "SelectTab";
        }
    }
}