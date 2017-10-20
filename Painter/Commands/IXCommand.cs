using Painter.Commands.Actions;
using Painter.Views.Drawing;

namespace Painter.Commands
{
    public interface IXCommand
    {
        PTabControl PTabControl { get; set; }
        IActionOpen ActionOpen { get; }
        IActionSave ActionSave { get; }
        IActionAddTab ActionAddTab { get; }
        IActionSelectTab ActionSelectTab { get; }
        IActionLanguage ActionLanguage { get; }
    }
}