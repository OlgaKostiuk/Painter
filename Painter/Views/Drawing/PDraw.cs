using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views.Drawing
{
    public partial class PDraw : PictureBox
    {
        public XCommand xcom;
        public PDraw()
        {
            InitializeComponent();
        }
    }
}
