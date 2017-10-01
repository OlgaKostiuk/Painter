using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugins
{
    public interface IFigurePlugin
    {
        ToolStripMenuItem getMenu();
        ToolStrip getBar();
        Button getToolBox();
        UserControl getPropertyEditor();
        void ActivatePlugin(PictureBox pictureBox);
    }
}
