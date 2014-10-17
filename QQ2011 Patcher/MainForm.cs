using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace QQ2011_Patcher
{
    public partial class MainForm : Form
    {
        String QQFloderPath = null;
        Patcher pt;

        //通用文件对话框
        CommonOpenFileDialog getQQFloder = new CommonOpenFileDialog()
        {
            IsFolderPicker = true,
            InitialDirectory = @"C:\Program Files\Tencent\QQ\Bin",
            DefaultFileName=@"C:\Program Files\Tencent\QQ\Bin",
            ShowPlacesList=true,
            EnsurePathExists=true,
            Title = "指定QQ主程序目录，如\"C:\\Program Files\\Tencent\\QQ\\Bin\"",
        };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //检测QQ进程
            if (IsQQRuning())
            {
                MessageBox.Show("请关闭QQ后再运行补丁", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                Application.Exit();
            }

            BtnLocalSSO.Enabled = false;
            BtnPlugin.Enabled=false;
            BtnLocalVIP.Enabled = false;
        }

        private void SetQQFloder_Click(object sender, EventArgs e)
        {
            //设置QQ主目录
            if (getQQFloder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                QQFloderPath = getQQFloder.FileName;
                BtnLocalSSO.ForeColor = Color.Black;
                BtnPlugin.ForeColor = Color.Black;
                BtnLocalVIP.ForeColor = Color.Black;
            }

            if (QQFloderPath != null)
            {
                BtnLocalSSO.Enabled = true;
                BtnPlugin.Enabled = true;
                BtnLocalVIP.Enabled = true;
                pt = new Patcher(QQFloderPath);
            }
        }



        //检测QQ是否正在运行
        private static Boolean IsQQRuning()
        {
            foreach (var proc in Process.GetProcesses())
            {
                if (proc.ProcessName=="QQ")
                {
                    return true;
                }
            }
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://iwish.5d6d.com");
        }

        private void BtnPlugin_Click(object sender, EventArgs e)
        {
            //破解插件校验
            try
            {
                pt.ModAppMisc();
                pt.ModAppUtil();
                pt.ModChatFrameApp();
                pt.ModMsgMgr();
                pt.ModIM();
                BtnPlugin.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLocalSSO_Click(object sender, EventArgs e)
        {
            //破解本地SSO
            try
            {
                pt.ModKernelUtil();
                pt.ModIM();
                BtnLocalSSO.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLocalVIP_Click(object sender, EventArgs e)
        {
            //破解本地会员
            try
            {
                if (QQFloderPath != null)
                {
                    pt.LocalVIP();
                    BtnLocalVIP.ForeColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("请先选择QQ主程序目录再执行补丁", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("本补丁除破解本地会员以外，其余三个功能仅适用于QQ2011Beta2(2103)，使用前注意查看QQ版本号！", "补丁说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
