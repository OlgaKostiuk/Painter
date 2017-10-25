using System;
using System.Windows.Forms;
using Plugins;

namespace Painter.Plugins.Default
{
    public class SimpleFigurePlugin : IFigurePlugin
    {
        public ToolStrip getBar()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem getMenu()
        {
            return new ToolStripMenuItem("Simple figure");
        }

        public UserControl getPropertyEditor()
        {
            return new PropertyEditor();
        }

        public void ActivatePlugin(PictureBox pictureBox)
        {
            throw new NotImplementedException();
        }

        public Button getToolBox()
        {
            Button btn = new Button();
            btn.Text = "Simple figure";
            btn.AutoSize = true;
            return btn;
        }
    }
}
