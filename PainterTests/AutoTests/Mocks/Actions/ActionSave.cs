using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painter.Commands.Actions;
using Painter.Commands;
using System.Windows.Forms;

namespace PainterTests.AutoTests.Mocks.Actions
{
    class ActionSave : IActionSave
    {
        IXCommand cmd;
        public ActionSave(IXCommand cmd)
        {
            this.cmd = cmd;
        }

        public void ActionPerformed(object sender, EventArgs e)
        {
            MessageBox.Show("Save", "Save");
        }
    }
}
