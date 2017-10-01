using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter.Commands.Actions
{
    public class ActionOpen
    {
        XCommand xcom;
        public ActionOpen(XCommand xcom)
        {
            this.xcom = xcom;
        }
        public void ActionPerformed(object sender, EventArgs e)
        {

        }
    }
}
