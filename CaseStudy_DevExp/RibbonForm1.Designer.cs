namespace CaseStudy_DevExp
{
    partial class RibbonForm1
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
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            Save = new DevExpress.XtraEditors.SimpleButton();
            richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            Delete = new DevExpress.XtraEditors.SimpleButton();
            Print = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 1;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2, ribbonPage3 });
            ribbon.Size = new System.Drawing.Size(698, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 675);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(698, 24);
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(12, 71);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(42, 30);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Open";
            simpleButton1.Click += Open;
            // 
            // Save
            // 
            Save.Location = new System.Drawing.Point(60, 71);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(42, 30);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.Click += Save_Click;
            // 
            // richEditControl1
            // 
            richEditControl1.Location = new System.Drawing.Point(0, 164);
            richEditControl1.MenuManager = ribbon;
            richEditControl1.Name = "richEditControl1";
            richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richEditControl1.Size = new System.Drawing.Size(698, 505);
            richEditControl1.TabIndex = 11;
            richEditControl1.Click += richEditControl1_Click;
            // 
            // Delete
            // 
            Delete.Location = new System.Drawing.Point(13, 107);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(41, 30);
            Delete.TabIndex = 14;
            Delete.Text = "Delete";
            Delete.Click += Delete_Click;
            // 
            // Print
            // 
            Print.Location = new System.Drawing.Point(60, 107);
            Print.Name = "Print";
            Print.Size = new System.Drawing.Size(42, 30);
            Print.TabIndex = 17;
            Print.Text = "Print";
            Print.Click += Print_Click;
            // 
            // RibbonForm1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(698, 699);
            Controls.Add(Print);
            Controls.Add(Delete);
            Controls.Add(richEditControl1);
            Controls.Add(Save);
            Controls.Add(simpleButton1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "RibbonForm1";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "RibbonForm1";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Print;
    }
}