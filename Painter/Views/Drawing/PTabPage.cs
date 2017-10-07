using System.Windows.Forms;
using Painter.Commands;

namespace Painter.Views.Drawing
{
    public partial class PTabPage : TabPage
    {
        public PDraw pdraw;
        public string path = null;
        public PTabPage(IXCommand xcom)
        {
            InitializeComponent();
            pdraw = new PDraw();
            pdraw.xcom = xcom;
            Controls.Add(pdraw);
        }
    }
}
