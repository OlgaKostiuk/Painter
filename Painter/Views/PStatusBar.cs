using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views
{
    public partial class PStatusBar : UserControl
    {
        public XCommand xcom;
        public PStatusBar()
        {
            InitializeComponent();
        }
    }
}
