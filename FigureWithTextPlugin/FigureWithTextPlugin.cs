using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugins;

namespace FigureWithTextPlugin
{
    public class FigureWithTextPlugin : IFigurePlugin
    {
        public ToolStrip getBar()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem getMenu()
        {
            return new ToolStripMenuItem("Figure with text");
        }

        public UserControl getPropertyEditor()
        {
            return new PropertyEditor();
        }

        public void ActivatePlugin(PictureBox pictureBox)
        {
            //pictureBox.MouseDown +=
        }

        public Button getToolBox()
        {
            Button btn = new Button();
            btn.AutoSize = true;
            btn.Text = "Figure with text";
            return btn;
        }
    }
}
