using System;
using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views
{
    public partial class PMenu : UserControl
    {
        public XCommand xcom;
        public PMenu()
        {
            InitializeComponent();

            newTabToolStripMenuItem.Click += new EventHandler((s,e)=>xcom.ActionAddTab.ActionPerformed(s,e));

            Load += PMenu_Load;
        }

        private void PMenu_Load(object sender, EventArgs e)
        {
            xcom.ActionAddTab.onCreateTab += ActionAddTab_onCreateTab;
        }

        private void ActionAddTab_onCreateTab(string tabName)
        {
            ToolStripMenuItem newMenuTab = new ToolStripMenuItem();
            newMenuTab.Name = tabName;
            newMenuTab.Text = tabName;
            pagesToolStripMenuItem.DropDownItems.Add(newMenuTab);
            newMenuTab.Click += new EventHandler((s, e) => xcom.ActionSelectTab.ActionPerformed(s, e));
        }
    }
}
