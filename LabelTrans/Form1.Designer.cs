
namespace LabelTrans
{
    partial class Form1
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
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.buttonopen = new System.Windows.Forms.Button();
            this.buttondo = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxinfo.Location = new System.Drawing.Point(13, 79);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxinfo.Size = new System.Drawing.Size(775, 359);
            this.textBoxinfo.TabIndex = 0;
            // 
            // buttonopen
            // 
            this.buttonopen.Location = new System.Drawing.Point(13, 26);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(125, 25);
            this.buttonopen.TabIndex = 1;
            this.buttonopen.Text = "选择文件夹";
            this.buttonopen.UseVisualStyleBackColor = true;
            this.buttonopen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // buttondo
            // 
            this.buttondo.Location = new System.Drawing.Point(493, 26);
            this.buttondo.Name = "buttondo";
            this.buttondo.Size = new System.Drawing.Size(125, 25);
            this.buttondo.TabIndex = 1;
            this.buttondo.Text = "开始转换";
            this.buttondo.UseVisualStyleBackColor = true;
            this.buttondo.Click += new System.EventHandler(this.buttondo_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 445);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(775, 23);
            this.progressBar.TabIndex = 2;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(663, 26);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(125, 25);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "生成文件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = ".xml";
            // 
            // textBoxfilename
            // 
            this.textBoxfilename.Location = new System.Drawing.Point(265, 26);
            this.textBoxfilename.Name = "textBoxfilename";
            this.textBoxfilename.Size = new System.Drawing.Size(149, 25);
            this.textBoxfilename.TabIndex = 5;
            this.textBoxfilename.Text = "train";
            this.textBoxfilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.textBoxfilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttondo);
            this.Controls.Add(this.buttonopen);
            this.Controls.Add(this.textBoxinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelTrans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.Button buttonopen;
        private System.Windows.Forms.Button buttondo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfilename;
    }
}

