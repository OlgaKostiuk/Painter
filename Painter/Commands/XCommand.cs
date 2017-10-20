using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painter.Commands.Actions;
using Painter.Views.Drawing;

namespace Painter.Commands
{
    public class XCommand : IXCommand
    {
        public PTabControl PTabControl { get; set; }

        public IActionOpen ActionOpen { get; }
        public IActionSave ActionSave { get; }
        public IActionAddTab ActionAddTab { get; }
        public IActionSelectTab ActionSelectTab { get; }
        public IActionLanguage ActionLanguage { get; }

        public XCommand()
        {
            ActionOpen = new ActionOpen(this);
            ActionSave = new ActionSave(this);
            ActionAddTab = new ActionAddTab(this);
            ActionSelectTab = new ActionSelectTab(this);
            ActionLanguage = new ActionLanguage(this);
        }
    }
}
