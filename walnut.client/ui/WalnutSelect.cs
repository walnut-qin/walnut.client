using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutSelect : walnut.client.ui.helper.LabelContainer
    {
        public WalnutSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载后，重新计算布局，确保下拉框位于容器中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WalnutComboBox_Load(object sender, EventArgs e)
        {
            var offset = this.splitContainer.Size.Height - this.comboBox.Size.Height;
            if (offset > 0)
            {
                this.splitContainer.Panel2.Padding = new Padding(this.splitContainer.Panel2.Padding.Left, offset / 2, this.splitContainer.Panel2.Padding.Right, offset / 2);
            }
        }

        public String Value { get { return this.comboBox.Text; } set { this.comboBox.Text = value; } }

        public void setSelectedItems(List<String> items, String defaultValue)
        {
            this.comboBox.Items.Clear();
            this.comboBox.Items.AddRange(items.ToArray());
            this.Value = defaultValue;
        }
    }
}
