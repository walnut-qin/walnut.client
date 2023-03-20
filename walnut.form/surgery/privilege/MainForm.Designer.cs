namespace walnut.form.surgery.privilege
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.privilegeCardRight = new walnut.form.surgery.privilege.PrivilegeCard();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.privilegeCardLeft = new walnut.form.surgery.privilege.PrivilegeCard();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.pnlMain);
            this.pnl.Controls.Add(this.pnlBottom);
            this.pnl.Controls.Add(this.pnlUp);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Padding = new System.Windows.Forms.Padding(1);
            this.pnl.Size = new System.Drawing.Size(957, 574);
            this.pnl.TabIndex = 0;
            // 
            // pnlUp
            // 
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(1, 1);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUp.Size = new System.Drawing.Size(955, 68);
            this.pnlUp.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.privilegeCardRight);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(575, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(1);
            this.pnlRight.Size = new System.Drawing.Size(379, 425);
            this.pnlRight.TabIndex = 2;
            // 
            // privilegeCardRight
            // 
            this.privilegeCardRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.privilegeCardRight.header = "标题";
            this.privilegeCardRight.Location = new System.Drawing.Point(1, 1);
            this.privilegeCardRight.Name = "privilegeCardRight";
            this.privilegeCardRight.Size = new System.Drawing.Size(377, 423);
            this.privilegeCardRight.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.privilegeCardLeft);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(1);
            this.pnlLeft.Size = new System.Drawing.Size(379, 425);
            this.pnlLeft.TabIndex = 1;
            // 
            // privilegeCardLeft
            // 
            this.privilegeCardLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.privilegeCardLeft.header = "标题";
            this.privilegeCardLeft.Location = new System.Drawing.Point(1, 1);
            this.privilegeCardLeft.Name = "privilegeCardLeft";
            this.privilegeCardLeft.Size = new System.Drawing.Size(377, 423);
            this.privilegeCardLeft.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlCenter);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(1, 69);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(1);
            this.pnlMain.Size = new System.Drawing.Size(955, 427);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(1, 496);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBottom.Size = new System.Drawing.Size(955, 77);
            this.pnlBottom.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(380, 1);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Padding = new System.Windows.Forms.Padding(1);
            this.pnlCenter.Size = new System.Drawing.Size(195, 425);
            this.pnlCenter.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(997, 574);
            this.pnl.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnlRight;
        private PrivilegeCard privilegeCardRight;
        private System.Windows.Forms.Panel pnlLeft;
        private PrivilegeCard privilegeCardLeft;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
    }
}
