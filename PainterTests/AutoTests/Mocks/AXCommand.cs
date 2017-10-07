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

        public AXCommand()
        {
            ActionOpen = new Actions.ActionOpen();
            ActionSave = new Actions.ActionSave();
            ActionAddTab = new Actions.ActionAddTab();
            ActionSelectTab = new Actions.ActionSelectTab();
        }
    }
}
