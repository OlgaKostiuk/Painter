using Painter.Commands;
using Painter.Commands.Actions;
using PainterTests.UnitTests.Mocks;
using System;

namespace Actions
{
    internal class ActionAddTab : IActionAddTab
    {
        IXCommand cmd;
        public ActionAddTab(IXCommand cmd)
        {
            this.cmd = cmd;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            (cmd as UXCommand).Result = "AddTab";
        }
    }
}