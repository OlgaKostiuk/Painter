using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painter.Views.Drawing;

namespace Painter.Commands.Actions
{
    public class ActionAddTab : IActionAddTab
    {
        XCommand xcom;

        public delegate void CreateTab(string tabName);

        public event CreateTab OnCreateTab;

        public ActionAddTab(XCommand xcom)
        {
            this.xcom = xcom;
        }
        public void ActionPerformed(object sender, EventArgs e)
        {
            PTabPage tab = new PTabPage(xcom);
            tab.Name = "New " + xcom.PTabControl.TabsCount;
            tab.Text = "New " + xcom.PTabControl.TabsCount;

            xcom.PTabControl.Controls.Add(tab);
            xcom.PTabControl.SelectTab(tab);

            OnCreateTab(tab.Name);
        }
    }
}
