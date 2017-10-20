using System;

namespace Painter.Commands.Actions
{
    public class ActionLanguage: IActionLanguage
    {
        private XCommand xCommand;

        public ActionLanguage(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}