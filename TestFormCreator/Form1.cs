using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painter.Views;
using PainterTests.AutoTests.Mocks;

namespace TestFormCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AXCommand axcom = new AXCommand();

            PMenu testPMenu = new PMenu();
            testPMenu.xcom = axcom;
            Controls.Add(testPMenu);

            PToolBar testPToolBar = new PToolBar();
            testPToolBar.xcom = axcom;
         //   Controls.Add(testPToolBar);
        }
    }
}
