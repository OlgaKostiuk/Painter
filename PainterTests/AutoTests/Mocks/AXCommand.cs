using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painter.Commands;
using Painter.Commands.Actions;
using Painter.Views.Drawing;

namespace PainterTests.AutoTests.Mocks
{
    public class AXCommand : IXCommand
    {
        public PTabControl PTabControl { get; set; }
        public IActionOpen ActionOpen { get; }
        public IActionSave ActionSave { get; }
        public IActionAddTab ActionAddTab { get; }
        public IActionSelectTab ActionSelectTab { get; }
        public IActionLanguage ActionLanguage { get; }

        public AXCommand()
        {
            ActionOpen = new Actions.ActionOpen(this);
            ActionSave = new Actions.ActionSave(this);
            ActionAddTab = new Actions.ActionAddTab(this);
            ActionSelectTab = new Actions.ActionSelectTab(this);
            ActionLanguage = new Actions.ActionLanguage(this);
        }
    }
}
