using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views.Drawing
{
    public partial class PTabControl : TabControl
    {
        public XCommand xcom;
        public int TabsCount = 0;

        public PTabControl()
        {
            InitializeComponent();
            ControlAdded += PTabControl_ControlAdded;
        }

        private void PTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            TabsCount++;
        }
    }
}
