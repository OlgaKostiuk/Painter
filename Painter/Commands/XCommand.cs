using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painter.Commands.Actions;
using Painter.Views.Drawing;

namespace Painter.Commands
{
    public class XCommand
    {
        public PTabControl pTabControl;

        public ActionOpen actionOpen;
        public ActionSave actionSave;

        public XCommand()
        {
            actionOpen = new ActionOpen(this);
            actionSave = new ActionSave(this);
        }
    }
}
