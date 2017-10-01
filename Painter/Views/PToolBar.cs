using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views
{
    public partial class PToolBar : UserControl
    {
        public XCommand xcom;
        public PToolBar()
        {
            InitializeComponent();
        }
    }
}
