using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Painter.Commands;
using Plugins;

namespace Painter.Views.ToolBox
{
    public partial class PLeftToolBox : UserControl
    {
        public XCommand xcom;
        public PRightToolBox PropertyEditor;
        public IList<IFigurePlugin> AddedPluginsList = new List<IFigurePlugin>();
        public IFigurePlugin ActiveFigurePlugin;

        public PLeftToolBox()
        {
            InitializeComponent();
        }

        public void AddPlugin(IFigurePlugin plugin)
        {
            if(AddedPluginsList.Contains(plugin))
                return;
            Button btn = plugin.getToolBox();
            if (groupBox1.Controls.OfType<Button>().Count() != 0)
            {
                Button prevButton = groupBox1.Controls.OfType<Button>().Last();
                btn.Location = new Point(prevButton.Location.X, prevButton.Location.Y + prevButton.Height);
                ActiveFigurePlugin = plugin;
            }
            groupBox1.Controls.Add(btn);
            btn.Click += (sender,e)=>
            {
                ActiveFigurePlugin = plugin;
                PropertyEditor.AddPlugin(plugin);

            };
            AddedPluginsList.Add(plugin);
        }
    }
}
