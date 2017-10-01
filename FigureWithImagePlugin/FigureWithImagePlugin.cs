using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugins;

namespace FigureWithImagePlugin
{
    public class FigureWithImagePlugin : IFigurePlugin
    {
        public ToolStrip getBar()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem getMenu()
        {
            return new ToolStripMenuItem("Figure with image");
        }

        public UserControl getPropertyEditor()
        {
            throw new NotImplementedException();
        }

        public void ActivatePlugin(PictureBox pictureBox)
        {
            throw new NotImplementedException();
        }

        public Button getToolBox()
        {
            Button btn = new Button();
            btn.Text = "Figure with image";
            return btn;
        }
    }
}
