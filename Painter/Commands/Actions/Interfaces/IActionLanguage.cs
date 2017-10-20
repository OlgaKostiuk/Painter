using System;

namespace Painter.Commands
{
    public interface IActionLanguage
    {
        void ActionPerformed(object sender, EventArgs e);
    }
}