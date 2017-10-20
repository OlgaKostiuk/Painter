using Painter.Commands;
using Painter.Commands.Actions;
using Painter.Views.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterTests.UnitTests.Mocks
{
    public class UXCommand : IXCommand
    {
        public PTabControl PTabControl { get; set; }
        public IActionOpen ActionOpen { get; }
        public IActionSave ActionSave { get; }
        public IActionAddTab ActionAddTab { get; }
        public IActionSelectTab ActionSelectTab { get; }
        public IActionLanguage ActionLanguage { get; }

        public string Result;

        public UXCommand()
        {
            ActionOpen = new Actions.ActionOpen(this);
            ActionSave = new Actions.ActionSave(this);
            ActionAddTab = new Actions.ActionAddTab(this);
            ActionSelectTab = new Actions.ActionSelectTab(this);
            ActionLanguage = new Actions.ActionLanguage(this);
        }
    }
}
