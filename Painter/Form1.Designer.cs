using Painter.Views;
using Painter.Views.Drawing;
using Painter.Views.ToolBox;

namespace Painter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pRightToolBox1 = new PRightToolBox();
            this.pLeftToolBox1 = new PLeftToolBox();
            this.pStatusBar1 = new PStatusBar();
            this.pToolBar1 = new PToolBar();
            this.pMenu1 = new PMenu();
            this.pTabControl1 = new PTabControl();
            this.SuspendLayout();
            // 
            // pRightToolBox1
            // 
            this.pRightToolBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRightToolBox1.Location = new System.Drawing.Point(798, 55);
            this.pRightToolBox1.Name = "pRightToolBox1";
            this.pRightToolBox1.Size = new System.Drawing.Size(181, 544);
            this.pRightToolBox1.TabIndex = 6;
            // 
            // pLeftToolBox1
            // 
            this.pLeftToolBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftToolBox1.Location = new System.Drawing.Point(0, 55);
            this.pLeftToolBox1.Name = "pLeftToolBox1";
            this.pLeftToolBox1.Size = new System.Drawing.Size(181, 544);
            this.pLeftToolBox1.TabIndex = 5;
            // 
            // pStatusBar1
            // 
            this.pStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pStatusBar1.Location = new System.Drawing.Point(0, 599);
            this.pStatusBar1.Name = "pStatusBar1";
            this.pStatusBar1.Size = new System.Drawing.Size(979, 24);
            this.pStatusBar1.TabIndex = 4;
            // 
            // pToolBar1
            // 
            this.pToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolBar1.Location = new System.Drawing.Point(0, 26);
            this.pToolBar1.Name = "pToolBar1";
            this.pToolBar1.Size = new System.Drawing.Size(979, 29);
            this.pToolBar1.TabIndex = 1;
            // 
            // pMenu1
            // 
            this.pMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu1.Location = new System.Drawing.Point(0, 0);
            this.pMenu1.Name = "pMenu1";
            this.pMenu1.Size = new System.Drawing.Size(979, 26);
            this.pMenu1.TabIndex = 0;
            // 
            // pTabControl1
            // 
            this.pTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTabControl1.Location = new System.Drawing.Point(181, 55);
            this.pTabControl1.Name = "pTabControl1";
            this.pTabControl1.Size = new System.Drawing.Size(617, 544);
            this.pTabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 623);
            this.Controls.Add(this.pTabControl1);
            this.Controls.Add(this.pRightToolBox1);
            this.Controls.Add(this.pLeftToolBox1);
            this.Controls.Add(this.pStatusBar1);
            this.Controls.Add(this.pToolBar1);
            this.Controls.Add(this.pMenu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PMenu pMenu1;
        private PToolBar pToolBar1;
        private PStatusBar pStatusBar1;
        private PLeftToolBox pLeftToolBox1;
        private PRightToolBox pRightToolBox1;
        private PTabControl pTabControl1;
    }
}

