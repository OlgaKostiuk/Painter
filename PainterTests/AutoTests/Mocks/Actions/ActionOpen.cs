using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painter.Commands.Actions;

namespace PainterTests.AutoTests.Mocks.Actions
{
    class ActionOpen : IActionOpen
    {
        public void ActionPerformed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
