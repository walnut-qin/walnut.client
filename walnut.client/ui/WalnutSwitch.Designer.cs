namespace walnut.client.ui
{
    partial class WalnutSwitch
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
            this.toggleSwitch = new walnut.client.ui.helper.Switch();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.toggleSwitch);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5, 13, 5, 13);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Checked = false;
            this.toggleSwitch.Dock = System.Windows.Forms.DockStyle.Left;
            this.toggleSwitch.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.toggleSwitch.FalseText = "否";
            this.toggleSwitch.Location = new System.Drawing.Point(5, 13);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Size = new System.Drawing.Size(60, 24);
            this.toggleSwitch.SwitchType = walnut.client.ui.helper.Switch.SwitchTypeEnum.Ellipse;
            this.toggleSwitch.TabIndex = 0;
            this.toggleSwitch.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.toggleSwitch.TrueText = "是";
            // 
            // WalnutSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "WalnutSwitch";
            this.Load += new System.EventHandler(this.WalnutSwitch_Load);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private helper.Switch toggleSwitch;
    }
}
