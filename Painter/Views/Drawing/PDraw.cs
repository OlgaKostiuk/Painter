using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views.Drawing
{
    public partial class PDraw : PictureBox
    {
        public IXCommand xcom;
        public PDraw()
        {
            InitializeComponent();
        }
    }
}
