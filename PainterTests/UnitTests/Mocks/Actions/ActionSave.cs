using Painter.Commands;
using Painter.Commands.Actions;
using PainterTests.UnitTests.Mocks;
using System;

namespace Actions
{
    internal class ActionSave : IActionSave
    {
        IXCommand cmd;
        public ActionSave(IXCommand cmd)
        {
            this.cmd = cmd;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            (cmd as UXCommand).Result = "Save";
        }
    }
}