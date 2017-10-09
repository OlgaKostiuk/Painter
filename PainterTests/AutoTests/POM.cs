﻿using System;
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
        //public static string AppPath => @"E:\work\PainterForVladYaroslav\GIT\PainterTests\Painter\bin\Debug\Painter";
        public static string AppPath => @".\Painter\bin\Debug\Painter"; //path relative to solution folder
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


            public static Menu SSaveMenu => FileMenu.SubMenu("Save");
            public static Menu SOpenMenu => FileMenu.SubMenu("Open");
            public static Menu SExitMenu => FileMenu.SubMenu("Exit");

            public static Menu SNewTMenu => TabMenu.SubMenu("New Tab");
            public static Menu SRenTMenu => TabMenu.SubMenu("Rename Tab");
            public static Menu SCloseTMenu => TabMenu.SubMenu("Close Tab");

            public static Menu SRusMenu => LanguageMenu.SubMenu("Language").SubMenu("Russian");
            public static Menu SEngMenu => LanguageMenu.SubMenu("Language").SubMenu("English");
            public static Menu SUkrMenu => LanguageMenu.SubMenu("Language").SubMenu("Ukrainian");

            public static Menu SSaveCloudMenu => CloudMenu.SubMenu("Save");
            public static Menu SLoadCloudMenu => CloudMenu.SubMenu("Load");

            public static Menu Skin1SkinsMenu => SkinsMenu.SubMenu("1");
            public static Menu Skin2SkinsMenu => SkinsMenu.SubMenu("2");
            public static Menu Skin3SkinsMenu => SkinsMenu.SubMenu("3");

            public static Menu SFaqHelpMenu => HelpMenu.SubMenu("FAQ");
            public static Menu SAboutHelpMenu => HelpMenu.SubMenu("About");
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
