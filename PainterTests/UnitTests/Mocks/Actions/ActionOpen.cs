using System;
using Painter.Commands.Actions;
using PainterTests.UnitTests.Mocks;
using Painter.Commands;

namespace Actions
{
    internal class ActionOpen : IActionOpen
    {
        IXCommand cmd;
        public ActionOpen(IXCommand cmd)
        {
            this.cmd = cmd;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            (cmd as UXCommand).Result = "Open";
        }

    }
}