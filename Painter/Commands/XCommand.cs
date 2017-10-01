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
        public PTabControl PTabControl;

        public ActionOpen ActionOpen;
        public ActionSave ActionSave;
        public ActionAddTab ActionAddTab;
        public ActionSelectTab ActionSelectTab;
        public XCommand()
        {
            ActionOpen = new ActionOpen(this);
            ActionSave = new ActionSave(this);
            ActionAddTab = new ActionAddTab(this);
            ActionSelectTab = new ActionSelectTab(this);
        }
    }
}
