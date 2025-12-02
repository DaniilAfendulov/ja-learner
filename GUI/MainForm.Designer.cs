namespace ja_learner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timerWindowAttach = new System.Windows.Forms.Timer(components);
            timerSelectWindow = new System.Windows.Forms.Timer(components);
            tabPageSettings = new TabPage();
            checkBoxUseProxy = new CheckBox();
            comboBoxExtraPrompts = new ComboBox();
            checkBoxUseExtraPrompt = new CheckBox();
            buttonUpdateExtraPrompt = new Button();
            checkBoxDark = new CheckBox();
            checkBoxTopmost = new CheckBox();
            textBoxHwnd = new TextBox();
            btnSelectWindow = new Button();
            checkBoxWindowAttach = new CheckBox();
            tabPageText = new TabPage();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl = new TabControl();
            timerGetClipboard = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            buttonDebug = new Button();
            comboBoxTranslator = new ComboBox();
            checkBoxTranslateKatakana = new CheckBox();
            checkBoxAutoTranslate = new CheckBox();
            buttonTranslate = new Button();
            buttonShowDictForm = new Button();
            btnInputText = new Button();
            checkBoxClipboardMode = new CheckBox();
            tabPageSettings.SuspendLayout();
            tabPageText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            tabControl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timerWindowAttach
            // 
            timerWindowAttach.Interval = 15;
            timerWindowAttach.Tick += timerWindowAttach_Tick;
            // 
            // timerSelectWindow
            // 
            timerSelectWindow.Tick += timerSelectWindow_Tick;
            // 
            // tabPageSettings
            // 
            resources.ApplyResources(tabPageSettings, "tabPageSettings");
            tabPageSettings.Controls.Add(checkBoxUseProxy);
            tabPageSettings.Controls.Add(comboBoxExtraPrompts);
            tabPageSettings.Controls.Add(checkBoxUseExtraPrompt);
            tabPageSettings.Controls.Add(buttonUpdateExtraPrompt);
            tabPageSettings.Controls.Add(checkBoxDark);
            tabPageSettings.Controls.Add(checkBoxTopmost);
            tabPageSettings.Controls.Add(textBoxHwnd);
            tabPageSettings.Controls.Add(btnSelectWindow);
            tabPageSettings.Controls.Add(checkBoxWindowAttach);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseProxy
            // 
            resources.ApplyResources(checkBoxUseProxy, "checkBoxUseProxy");
            checkBoxUseProxy.Name = "checkBoxUseProxy";
            checkBoxUseProxy.UseVisualStyleBackColor = true;
            checkBoxUseProxy.CheckedChanged += checkBoxUseProxy_CheckedChanged;
            // 
            // comboBoxExtraPrompts
            // 
            resources.ApplyResources(comboBoxExtraPrompts, "comboBoxExtraPrompts");
            comboBoxExtraPrompts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExtraPrompts.FormattingEnabled = true;
            comboBoxExtraPrompts.Name = "comboBoxExtraPrompts";
            comboBoxExtraPrompts.Sorted = true;
            comboBoxExtraPrompts.SelectedIndexChanged += comboBoxExtraPrompts_SelectedIndexChanged;
            comboBoxExtraPrompts.Click += comboBoxExtraPrompts_Click;
            // 
            // checkBoxUseExtraPrompt
            // 
            resources.ApplyResources(checkBoxUseExtraPrompt, "checkBoxUseExtraPrompt");
            checkBoxUseExtraPrompt.Name = "checkBoxUseExtraPrompt";
            checkBoxUseExtraPrompt.UseVisualStyleBackColor = true;
            checkBoxUseExtraPrompt.CheckedChanged += checkBoxUseExtraPrompt_CheckedChanged;
            // 
            // buttonUpdateExtraPrompt
            // 
            resources.ApplyResources(buttonUpdateExtraPrompt, "buttonUpdateExtraPrompt");
            buttonUpdateExtraPrompt.Name = "buttonUpdateExtraPrompt";
            buttonUpdateExtraPrompt.UseVisualStyleBackColor = true;
            buttonUpdateExtraPrompt.Click += buttonUpdateExtraPrompt_Click;
            // 
            // checkBoxDark
            // 
            resources.ApplyResources(checkBoxDark, "checkBoxDark");
            checkBoxDark.Name = "checkBoxDark";
            checkBoxDark.UseVisualStyleBackColor = true;
            checkBoxDark.Click += checkBoxDark_CheckedChanged;
            // 
            // checkBoxTopmost
            // 
            resources.ApplyResources(checkBoxTopmost, "checkBoxTopmost");
            checkBoxTopmost.Name = "checkBoxTopmost";
            checkBoxTopmost.UseVisualStyleBackColor = true;
            checkBoxTopmost.CheckedChanged += checkBoxTopmost_CheckedChanged;
            // 
            // textBoxHwnd
            // 
            resources.ApplyResources(textBoxHwnd, "textBoxHwnd");
            textBoxHwnd.Name = "textBoxHwnd";
            textBoxHwnd.ReadOnly = true;
            textBoxHwnd.TextChanged += textBoxHwnd_TextChanged;
            // 
            // btnSelectWindow
            // 
            resources.ApplyResources(btnSelectWindow, "btnSelectWindow");
            btnSelectWindow.Name = "btnSelectWindow";
            btnSelectWindow.UseVisualStyleBackColor = true;
            btnSelectWindow.Click += btnSelectWindow_Click;
            // 
            // checkBoxWindowAttach
            // 
            resources.ApplyResources(checkBoxWindowAttach, "checkBoxWindowAttach");
            checkBoxWindowAttach.Name = "checkBoxWindowAttach";
            checkBoxWindowAttach.UseVisualStyleBackColor = true;
            checkBoxWindowAttach.CheckedChanged += checkBoxWindowAttach_CheckedChanged;
            // 
            // tabPageText
            // 
            resources.ApplyResources(tabPageText, "tabPageText");
            tabPageText.Controls.Add(webView);
            tabPageText.Name = "tabPageText";
            tabPageText.UseVisualStyleBackColor = true;
            // 
            // webView
            // 
            resources.ApplyResources(webView, "webView");
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Name = "webView";
            webView.ZoomFactor = 1D;
            // 
            // tabControl
            // 
            resources.ApplyResources(tabControl, "tabControl");
            tabControl.Controls.Add(tabPageText);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            // 
            // timerGetClipboard
            // 
            timerGetClipboard.Interval = 15;
            timerGetClipboard.Tick += timerGetClipboard_Tick;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(buttonDebug);
            panel1.Controls.Add(comboBoxTranslator);
            panel1.Controls.Add(checkBoxTranslateKatakana);
            panel1.Controls.Add(checkBoxAutoTranslate);
            panel1.Controls.Add(buttonTranslate);
            panel1.Controls.Add(buttonShowDictForm);
            panel1.Controls.Add(btnInputText);
            panel1.Controls.Add(checkBoxClipboardMode);
            panel1.Name = "panel1";
            // 
            // buttonDebug
            // 
            resources.ApplyResources(buttonDebug, "buttonDebug");
            buttonDebug.Name = "buttonDebug";
            buttonDebug.UseVisualStyleBackColor = true;
            buttonDebug.Click += buttonDebug_Click;
            // 
            // comboBoxTranslator
            // 
            resources.ApplyResources(comboBoxTranslator, "comboBoxTranslator");
            comboBoxTranslator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTranslator.FormattingEnabled = true;
            comboBoxTranslator.Items.AddRange(new object[] { resources.GetString("comboBoxTranslator.Items"), resources.GetString("comboBoxTranslator.Items1"), resources.GetString("comboBoxTranslator.Items2") });
            comboBoxTranslator.Name = "comboBoxTranslator";
            // 
            // checkBoxTranslateKatakana
            // 
            resources.ApplyResources(checkBoxTranslateKatakana, "checkBoxTranslateKatakana");
            checkBoxTranslateKatakana.Name = "checkBoxTranslateKatakana";
            checkBoxTranslateKatakana.UseVisualStyleBackColor = true;
            checkBoxTranslateKatakana.CheckedChanged += checkBoxTranslateKatakana_CheckedChanged;
            // 
            // checkBoxAutoTranslate
            // 
            resources.ApplyResources(checkBoxAutoTranslate, "checkBoxAutoTranslate");
            checkBoxAutoTranslate.Name = "checkBoxAutoTranslate";
            checkBoxAutoTranslate.UseVisualStyleBackColor = true;
            // 
            // buttonTranslate
            // 
            resources.ApplyResources(buttonTranslate, "buttonTranslate");
            buttonTranslate.Name = "buttonTranslate";
            buttonTranslate.UseVisualStyleBackColor = true;
            buttonTranslate.Click += buttonTranslate_Click;
            // 
            // buttonShowDictForm
            // 
            resources.ApplyResources(buttonShowDictForm, "buttonShowDictForm");
            buttonShowDictForm.Name = "buttonShowDictForm";
            buttonShowDictForm.UseVisualStyleBackColor = true;
            buttonShowDictForm.Click += buttonShowDictForm_Click;
            // 
            // btnInputText
            // 
            resources.ApplyResources(btnInputText, "btnInputText");
            btnInputText.Name = "btnInputText";
            btnInputText.UseVisualStyleBackColor = true;
            btnInputText.Click += btnInputText_Click;
            // 
            // checkBoxClipboardMode
            // 
            resources.ApplyResources(checkBoxClipboardMode, "checkBoxClipboardMode");
            checkBoxClipboardMode.Name = "checkBoxClipboardMode";
            checkBoxClipboardMode.UseVisualStyleBackColor = true;
            checkBoxClipboardMode.CheckedChanged += checkBoxClipboardMode_CheckedChanged;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tabControl);
            Name = "MainForm";
            Load += MainForm_Load;
            SizeChanged += MainForm_SizeChanged;
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            tabPageText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            tabControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerWindowAttach;
        private System.Windows.Forms.Timer timerSelectWindow;
        private TabPage tabPageSettings;
        private TabPage tabPageText;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TabControl tabControl;
        private System.Windows.Forms.Timer timerGetClipboard;
        private TextBox textBoxHwnd;
        private Button btnSelectWindow;
        private CheckBox checkBoxWindowAttach;
        private Panel panel1;
        private Button buttonShowDictForm;
        private CheckBox checkBoxDark;
        private Button btnInputText;
        private CheckBox checkBoxClipboardMode;
        private GUI.TranslationPanel translationPanel;
        private Button buttonTranslate;
        private CheckBox checkBoxAutoTranslate;
        private CheckBox checkBoxTopmost;
        private CheckBox checkBoxUseExtraPrompt;
        private Button buttonUpdateExtraPrompt;
        private ComboBox comboBoxExtraPrompts;
        private CheckBox checkBoxTranslateKatakana;
        private ComboBox comboBoxTranslator;
        private CheckBox checkBoxUseProxy;
        private Button buttonDebug;
    }
}