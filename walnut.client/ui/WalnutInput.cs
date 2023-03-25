using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutInput : walnut.client.ui.helper.LabelContainer
    {
        public WalnutInput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载后，重新计算布局，确保输入框位于容器中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WalnutInput_Load(object sender, EventArgs e)
        {
            var offset = this.splitContainer.Size.Height - this.textBox.Size.Height;
            if (offset > 0)
            {
                this.splitContainer.Panel2.Padding = new Padding(this.splitContainer.Panel2.Padding.Left, offset / 2, this.splitContainer.Panel2.Padding.Right, offset / 2);
            }
        }

        public String Value { get { return this.textBox.Text; } set { this.textBox.Text = value; } }
    }
}
