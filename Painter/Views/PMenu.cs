using System;
using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views
{
    public partial class PMenu : UserControl
    {
        public IXCommand xcom;
      
        public PMenu()
        {
           
            InitializeComponent();

            newTabToolStripMenuItem.Click += new EventHandler((s, e) => xcom.ActionAddTab.ActionPerformed(s, e));
          //  russianToolStripMenuItem.Click += new EventHandler((s, e) => xcom.ActionLanguage.ActionPerformed(s, e));
        }

        public void ActionAddTab_onCreateTab(string tabName)
        {
            ToolStripMenuItem newMenuTab = new ToolStripMenuItem();
            newMenuTab.Name = tabName;
            newMenuTab.Text = tabName;
            pagesToolStripMenuItem.DropDownItems.Add(newMenuTab);
            newMenuTab.Click += new EventHandler((s, e) => xcom.ActionSelectTab.ActionPerformed(s, e));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MyString.ExitRequest, MyString.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ((Form)this.Parent).Close();
            }
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "ru";
            Properties.Settings.Default.Save();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "en";
            Properties.Settings.Default.Save();
        }
    }
}
