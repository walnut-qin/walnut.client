namespace Tests
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.walnutDivider = new walnut.client.ui.WalnutDivider();
            this.walnutLabel = new walnut.client.ui.WalnutLabel();
            this.walnutComboBox = new walnut.client.ui.WalnutSelect();
            this.walnutInput1 = new walnut.client.ui.WalnutInput();
            this.walnutDatePicker1 = new walnut.client.ui.WalnutDatePicker();
            this.walnutSwitch = new walnut.client.ui.WalnutSwitch();
            this.walnutInputWithDialog = new walnut.client.ui.WalnutInputWithDialog();
            this.walnutTreeView1 = new walnut.client.ui.WalnutTreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.walnutDivider, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.walnutLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.walnutComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.walnutInput1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.walnutDatePicker1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.walnutSwitch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.walnutInputWithDialog, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.walnutTreeView1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // walnutDivider
            // 
            this.walnutDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutDivider.Location = new System.Drawing.Point(5, 5);
            this.walnutDivider.Margin = new System.Windows.Forms.Padding(5);
            this.walnutDivider.Name = "walnutDivider";
            this.walnutDivider.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.walnutDivider.Size = new System.Drawing.Size(190, 102);
            this.walnutDivider.TabIndex = 0;
            // 
            // walnutLabel
            // 
            this.walnutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutLabel.Location = new System.Drawing.Point(205, 5);
            this.walnutLabel.Margin = new System.Windows.Forms.Padding(5);
            this.walnutLabel.Name = "walnutLabel";
            this.walnutLabel.Size = new System.Drawing.Size(190, 102);
            this.walnutLabel.TabIndex = 1;
            this.walnutLabel.Title = "label";
            this.walnutLabel.Value = "标签测试";
            // 
            // walnutComboBox
            // 
            this.walnutComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutComboBox.Location = new System.Drawing.Point(405, 5);
            this.walnutComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.walnutComboBox.Name = "walnutComboBox";
            this.walnutComboBox.Size = new System.Drawing.Size(190, 102);
            this.walnutComboBox.TabIndex = 2;
            this.walnutComboBox.Title = "select";
            this.walnutComboBox.Value = "";
            // 
            // walnutInput1
            // 
            this.walnutInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutInput1.Location = new System.Drawing.Point(605, 5);
            this.walnutInput1.Margin = new System.Windows.Forms.Padding(5);
            this.walnutInput1.Name = "walnutInput1";
            this.walnutInput1.Size = new System.Drawing.Size(190, 102);
            this.walnutInput1.TabIndex = 3;
            this.walnutInput1.Title = "input";
            this.walnutInput1.Value = "";
            // 
            // walnutDatePicker1
            // 
            this.walnutDatePicker1.DateFormat = "yyyy-MM-dd";
            this.walnutDatePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutDatePicker1.Location = new System.Drawing.Point(5, 117);
            this.walnutDatePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.walnutDatePicker1.Name = "walnutDatePicker1";
            this.walnutDatePicker1.Size = new System.Drawing.Size(190, 102);
            this.walnutDatePicker1.TabIndex = 4;
            this.walnutDatePicker1.Title = "datePicker";
            this.walnutDatePicker1.Value = new System.DateTime(2023, 3, 24, 14, 55, 27, 138);
            // 
            // walnutSwitch
            // 
            this.walnutSwitch.Checked = false;
            this.walnutSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutSwitch.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.walnutSwitch.FalseText = "否";
            this.walnutSwitch.Location = new System.Drawing.Point(205, 117);
            this.walnutSwitch.Margin = new System.Windows.Forms.Padding(5);
            this.walnutSwitch.Name = "walnutSwitch";
            this.walnutSwitch.Size = new System.Drawing.Size(190, 102);
            this.walnutSwitch.SwitchType = walnut.client.ui.helper.Switch.SwitchTypeEnum.Ellipse;
            this.walnutSwitch.TabIndex = 5;
            this.walnutSwitch.Title = "label";
            this.walnutSwitch.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.walnutSwitch.TrueText = "是";
            // 
            // walnutInputWithDialog
            // 
            this.walnutInputWithDialog.Dialog = null;
            this.walnutInputWithDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutInputWithDialog.Location = new System.Drawing.Point(405, 117);
            this.walnutInputWithDialog.Margin = new System.Windows.Forms.Padding(5);
            this.walnutInputWithDialog.Name = "walnutInputWithDialog";
            this.walnutInputWithDialog.Size = new System.Drawing.Size(190, 102);
            this.walnutInputWithDialog.TabIndex = 6;
            this.walnutInputWithDialog.Title = "label";
            this.walnutInputWithDialog.Value = null;
            // 
            // walnutTreeView1
            // 
            this.walnutTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walnutTreeView1.Location = new System.Drawing.Point(605, 117);
            this.walnutTreeView1.Margin = new System.Windows.Forms.Padding(5);
            this.walnutTreeView1.Name = "walnutTreeView1";
            this.walnutTreeView1.Size = new System.Drawing.Size(190, 102);
            this.walnutTreeView1.TabIndex = 7;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private walnut.client.ui.WalnutDivider walnutDivider;
        private walnut.client.ui.WalnutLabel walnutLabel;
        private walnut.client.ui.WalnutSelect walnutComboBox;
        private walnut.client.ui.WalnutInput walnutInput1;
        private walnut.client.ui.WalnutDatePicker walnutDatePicker1;
        private walnut.client.ui.WalnutSwitch walnutSwitch;
        private walnut.client.ui.WalnutInputWithDialog walnutInputWithDialog;
        private walnut.client.ui.WalnutTreeView walnutTreeView1;
    }
}

