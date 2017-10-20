using System;
using Painter.Commands;

namespace PainterTests.AutoTests.Mocks.Actions
{
    internal class ActionLanguage : IActionLanguage
    {
        private AXCommand aXCommand;

        public ActionLanguage(AXCommand aXCommand)
        {
            this.aXCommand = aXCommand;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}