using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.ListViewItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;

namespace UnitTestProject1.AutoTests
{
    public class POM
    {
        public static Window Window { get; set; }
        public static string AppPath => @"E:\work\PainterForVladYaroslav\GIT\PainterTests\Painter\bin\Debug\Painter";
        public static string WindowName => "Form1";

        public static class MenuBar
        {
            public static Menu FileMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("File"));
            public static Menu TabMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Tab"));
            public static Menu PagesMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Pages"));
            public static Menu LanguageMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Language"));
            public static Menu FigurePluginsMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Figure Plugins"));
            public static Menu FormatPluginsMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Format Plugins"));
            public static Menu CloudMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Cloud"));
            public static Menu SkinsMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Skins"));
            public static Menu HelpMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help"));


            public static Menu SSaveMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Save");
            public static Menu SOpenMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Open");
            public static Menu SExitMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Exit");

            public static Menu SNewTMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Tab")).SubMenu("New Tab");
            public static Menu SRenTMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Tab")).SubMenu("Rename Tab");
            public static Menu SCloseTMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Tab")).SubMenu("Close Tab");

        }
        public static class ToolBar
        {
            //   public static Label FileTool => Window.ToolStrip.Get<Label>(SearchCriteria.ByText("File"));
            public static Button SaveTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Save"));
            public static Button OpenTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Open"));
            //   public static Label TabTool => Window.ToolStrip.Get<Label>(SearchCriteria.ByText("Tab"));
            public static Button NewTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("New"));
            public static Button DelTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Del"));
            public static Button ReNTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("ReN"));
        }

        public static class ToolBoxRight
        {
            public static GroupBox PropGB => Window.Get<GroupBox>(SearchCriteria.ByText("Properties"));
            public static Button RectBtn => Window.Get<Button>(SearchCriteria.ByText("Rectangle"));
            public static Button RRectBtn => Window.Get<Button>(SearchCriteria.ByText("RRectangle"));
            public static Button CurvBtn => Window.Get<Button>(SearchCriteria.ByText("Curve"));
            public static Button LineBtn => Window.Get<Button>(SearchCriteria.ByText("Line"));
            public static Button EllipsBtn => Window.Get<Button>(SearchCriteria.ByText("Ellipse"));

            public static GroupBox FileGB => Window.Get<GroupBox>(SearchCriteria.ByText("File"));
            public static Button SaveBtn => Window.Get<Button>(SearchCriteria.ByText("Save"));
            public static Button LoadBtn => Window.Get<Button>(SearchCriteria.ByText("Load"));
        }

        public static class ToolBoxLeft
        {
            public static GroupBox FiguerTGB => Window.Get<GroupBox>(SearchCriteria.ByText("Figure Type"));

        }
    }
}
