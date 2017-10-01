using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views.Drawing
{
    public partial class PTabControl : UserControl
    {
        public XCommand xcom;
        public PTabControl()
        {
            InitializeComponent();
        }
    }
}
