﻿
namespace TestLinkTransfer
{
    partial class Form
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.getFilePathBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filePathTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xeRb = new System.Windows.Forms.RadioButton();
            this.exRb = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.DonateLab = new System.Windows.Forms.Label();
            this.outputRtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getFilePathBtn
            // 
            this.getFilePathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getFilePathBtn.Location = new System.Drawing.Point(361, 58);
            this.getFilePathBtn.Name = "getFilePathBtn";
            this.getFilePathBtn.Size = new System.Drawing.Size(46, 23);
            this.getFilePathBtn.TabIndex = 0;
            this.getFilePathBtn.Text = "...";
            this.getFilePathBtn.UseVisualStyleBackColor = true;
            this.getFilePathBtn.Click += new System.EventHandler(this.getFilePathBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "所有文件(*.*)|*.*";
            // 
            // filePathTb
            // 
            this.filePathTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTb.Location = new System.Drawing.Point(70, 60);
            this.filePathTb.Name = "filePathTb";
            this.filePathTb.Size = new System.Drawing.Size(285, 21);
            this.filePathTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
            // 
            // xeRb
            // 
            this.xeRb.AutoSize = true;
            this.xeRb.Checked = true;
            this.xeRb.Location = new System.Drawing.Point(74, 19);
            this.xeRb.Name = "xeRb";
            this.xeRb.Size = new System.Drawing.Size(95, 16);
            this.xeRb.TabIndex = 3;
            this.xeRb.TabStop = true;
            this.xeRb.Text = "XML -> Excel";
            this.xeRb.UseVisualStyleBackColor = true;
            this.xeRb.CheckedChanged += new System.EventHandler(this.xeRb_CheckedChanged);
            // 
            // exRb
            // 
            this.exRb.AutoSize = true;
            this.exRb.Location = new System.Drawing.Point(191, 19);
            this.exRb.Name = "exRb";
            this.exRb.Size = new System.Drawing.Size(95, 16);
            this.exRb.TabIndex = 4;
            this.exRb.Text = "Excel -> XML";
            this.exRb.UseVisualStyleBackColor = true;
            this.exRb.CheckedChanged += new System.EventHandler(this.exRb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "转换形式：";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(361, 106);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(8, 106);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(347, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(6, 415);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(53, 12);
            this.linkLabel.TabIndex = 8;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "© yaitza";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // DonateLab
            // 
            this.DonateLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DonateLab.AutoSize = true;
            this.DonateLab.BackColor = System.Drawing.Color.LightCoral;
            this.DonateLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateLab.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DonateLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DonateLab.Location = new System.Drawing.Point(349, 415);
            this.DonateLab.Name = "DonateLab";
            this.DonateLab.Size = new System.Drawing.Size(87, 17);
            this.DonateLab.TabIndex = 11;
            this.DonateLab.Text = "赞赏(Donate)";
            this.DonateLab.Click += new System.EventHandler(this.DonateLab_Click);
            // 
            // outputRtb
            // 
            this.outputRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputRtb.BackColor = System.Drawing.SystemColors.MenuText;
            this.outputRtb.ForeColor = System.Drawing.Color.Red;
            this.outputRtb.Location = new System.Drawing.Point(6, 147);
            this.outputRtb.Name = "outputRtb";
            this.outputRtb.Size = new System.Drawing.Size(445, 265);
            this.outputRtb.TabIndex = 12;
            this.outputRtb.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 436);
            this.Controls.Add(this.outputRtb);
            this.Controls.Add(this.DonateLab);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exRb);
            this.Controls.Add(this.xeRb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTb);
            this.Controls.Add(this.getFilePathBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "TestLinkConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button getFilePathBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox filePathTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton xeRb;
        private System.Windows.Forms.RadioButton exRb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label DonateLab;
        private System.Windows.Forms.RichTextBox outputRtb;
    }
}

