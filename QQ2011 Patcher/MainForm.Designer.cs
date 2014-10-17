namespace QQ2011_Patcher
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnLocalSSO = new System.Windows.Forms.Button();
            this.SetQQFloder = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnPlugin = new System.Windows.Forms.Button();
            this.BtnLocalVIP = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnLocalSSO
            // 
            this.BtnLocalSSO.Location = new System.Drawing.Point(46, 185);
            this.BtnLocalSSO.Name = "BtnLocalSSO";
            this.BtnLocalSSO.Size = new System.Drawing.Size(142, 34);
            this.BtnLocalSSO.TabIndex = 1;
            this.BtnLocalSSO.Text = "破解本地SSO";
            this.BtnLocalSSO.UseVisualStyleBackColor = true;
            this.BtnLocalSSO.Click += new System.EventHandler(this.BtnLocalSSO_Click);
            // 
            // SetQQFloder
            // 
            this.SetQQFloder.ForeColor = System.Drawing.Color.ForestGreen;
            this.SetQQFloder.Location = new System.Drawing.Point(194, 185);
            this.SetQQFloder.Name = "SetQQFloder";
            this.SetQQFloder.Size = new System.Drawing.Size(142, 34);
            this.SetQQFloder.TabIndex = 2;
            this.SetQQFloder.Text = "指定QQ主目录";
            this.SetQQFloder.UseVisualStyleBackColor = true;
            this.SetQQFloder.Click += new System.EventHandler(this.SetQQFloder_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(44, 242);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "方法来自iWish论坛，感谢童话等";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnPlugin
            // 
            this.BtnPlugin.Location = new System.Drawing.Point(194, 145);
            this.BtnPlugin.Name = "BtnPlugin";
            this.BtnPlugin.Size = new System.Drawing.Size(142, 34);
            this.BtnPlugin.TabIndex = 4;
            this.BtnPlugin.Text = "破解插件校验";
            this.BtnPlugin.UseVisualStyleBackColor = true;
            this.BtnPlugin.Click += new System.EventHandler(this.BtnPlugin_Click);
            // 
            // BtnLocalVIP
            // 
            this.BtnLocalVIP.Location = new System.Drawing.Point(46, 145);
            this.BtnLocalVIP.Name = "BtnLocalVIP";
            this.BtnLocalVIP.Size = new System.Drawing.Size(142, 34);
            this.BtnLocalVIP.TabIndex = 5;
            this.BtnLocalVIP.Text = "破解本地会员";
            this.BtnLocalVIP.UseVisualStyleBackColor = true;
            this.BtnLocalVIP.Click += new System.EventHandler(this.BtnLocalVIP_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(283, 242);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 12);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "请先点我";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QQ2011_Patcher.Properties.Resources.QQLogin;
            this.ClientSize = new System.Drawing.Size(382, 272);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.BtnLocalVIP);
            this.Controls.Add(this.BtnPlugin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SetQQFloder);
            this.Controls.Add(this.BtnLocalSSO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ2011 Patcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLocalSSO;
        private System.Windows.Forms.Button SetQQFloder;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BtnPlugin;
        private System.Windows.Forms.Button BtnLocalVIP;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

