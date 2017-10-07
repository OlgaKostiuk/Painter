using System;
using System.Windows.Forms;
using Painter.Commands;
using Plugins;

namespace Painter.Views.ToolBox
{
    public partial class PRightToolBox : UserControl
    {
        public IXCommand xcom;
        public PRightToolBox()
        {
            InitializeComponent();
        }

        public void AddPlugin(IFigurePlugin plugin)
        {
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(plugin.getPropertyEditor());


        }
    }
}
