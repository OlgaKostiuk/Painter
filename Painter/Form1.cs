using System;
using System.Windows.Forms;
using System.Reflection;
using Plugins;
using Painter.Commands;
using Painter.Plugins;

namespace Painter
{
    public partial class Form1 : Form
    {
        public XCommand xcom;
        public PluginsManager PluginsManager;

        public Form1()
        {
            InitializeComponent();
            PluginsManager = new PluginsManager();

            xcom = new XCommand();
            pMenu1.xcom = xcom;
            pStatusBar1.xcom = xcom;
            pToolBar1.xcom = xcom;
            pLeftToolBox1.xcom = xcom;
            pRightToolBox1.xcom = xcom;
            pLeftToolBox1.PropertyEditor = pRightToolBox1;

            pTabControl1.xcom = xcom;

            xcom.PTabControl = pTabControl1;

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var figurePlugin in PluginsManager.FigurePlugins)
            {
                foreach (ToolStripMenuItem menuItem in pMenu1.menuStrip1.Items)
                {
                    if (menuItem.Name == "figurePluginsToolStripMenuItem")
                    {
                        var item = figurePlugin.getMenu();
                        item.Click += (s,ev)=>pLeftToolBox1.AddPlugin(figurePlugin);
                        menuItem.DropDownItems.Add(item);
                    }
                }
            }
            pLeftToolBox1.AddPlugin(PluginsManager.FigurePlugins[0]);
            pRightToolBox1.AddPlugin(PluginsManager.FigurePlugins[0]);
        }


    }
}
