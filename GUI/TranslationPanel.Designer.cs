namespace ja_learner.GUI
{
    partial class TranslationPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslationPanel));
            textBoxSentence = new TextBox();
            webBrowserResult = new WebBrowser();
            buttonInterpret = new Button();
            SuspendLayout();
            // 
            // textBoxSentence
            // 
            resources.ApplyResources(textBoxSentence, "textBoxSentence");
            textBoxSentence.Name = "textBoxSentence";
            // 
            // webBrowserResult
            // 
            resources.ApplyResources(webBrowserResult, "webBrowserResult");
            webBrowserResult.Name = "webBrowserResult";
            // 
            // buttonInterpret
            // 
            resources.ApplyResources(buttonInterpret, "buttonInterpret");
            buttonInterpret.Name = "buttonInterpret";
            buttonInterpret.UseVisualStyleBackColor = true;
            buttonInterpret.Click += buttonInterpret_Click;
            // 
            // TranslationPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonInterpret);
            Controls.Add(webBrowserResult);
            Controls.Add(textBoxSentence);
            Name = "TranslationPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private string getHtmlTemplate()
        {
            return $@"
<!DOCTYPE html>
<html>
<head>
    <style>
        body {{ 
            font-family: 'Microsoft YaHei UI', Arial, sans-serif;
            font-size: 20px;
        }}
        h1, h2, h3, h4, h5, h6, p, ol {{ 
            margin-top: 0;
            margin-bottom: 0;
        }}
    </style>
    <script>
        function setMarkdown(markdown) {{
            document.body.innerHTML = markdown;
        }}
    </script>
</head>
<body>
</body>
</html>";
        }

        private TextBox textBoxSentence;
        private WebBrowser webBrowserResult;
        private Button buttonInterpret;
    }
}
