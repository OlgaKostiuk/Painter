using System;
using Painter.Commands;
using PainterTests.UnitTests.Mocks;

namespace Actions
{
    internal class ActionLanguage : IActionLanguage
    {
        private UXCommand uXCommand;

        public ActionLanguage(UXCommand uXCommand)
        {
            this.uXCommand = uXCommand;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}