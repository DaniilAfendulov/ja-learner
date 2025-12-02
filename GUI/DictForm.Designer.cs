namespace ja_learner
{
    partial class DictForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictForm));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl1 = new TabControl();
            tabPageDict = new TabPage();
            tabPageGpt = new TabPage();
            translationPanel = new ja_learner.GUI.TranslationPanel();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            tabControl1.SuspendLayout();
            tabPageDict.SuspendLayout();
            tabPageGpt.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            resources.ApplyResources(webView, "webView");
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Name = "webView";
            webView.ZoomFactor = 1D;
            webView.WebMessageReceived += webView_WebMessageReceived;
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPageDict);
            tabControl1.Controls.Add(tabPageGpt);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPageDict
            // 
            resources.ApplyResources(tabPageDict, "tabPageDict");
            tabPageDict.Controls.Add(webView);
            tabPageDict.Name = "tabPageDict";
            tabPageDict.UseVisualStyleBackColor = true;
            // 
            // tabPageGpt
            // 
            resources.ApplyResources(tabPageGpt, "tabPageGpt");
            tabPageGpt.Controls.Add(translationPanel);
            tabPageGpt.Name = "tabPageGpt";
            tabPageGpt.UseVisualStyleBackColor = true;
            // 
            // translationPanel
            // 
            resources.ApplyResources(translationPanel, "translationPanel");
            translationPanel.Name = "translationPanel";
            // 
            // DictForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "DictForm";
            FormClosing += DictForm_FormClosing;
            Load += DictForm_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageDict.ResumeLayout(false);
            tabPageGpt.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TabControl tabControl1;
        private TabPage tabPageDict;
        private TabPage tabPageGpt;
        private GUI.TranslationPanel translationPanel;
    }
}