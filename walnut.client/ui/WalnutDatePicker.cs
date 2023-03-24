using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutDatePicker : walnut.client.ui.helper.LabelContainer
    {
        public WalnutDatePicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载后，重新计算布局，确保选择框位于容器中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WalnutDatePicker_Load(object sender, EventArgs e)
        {
            var offset = this.splitContainer.Size.Height - this.dateTimePicker.Size.Height;
            if (offset > 0)
            {
                this.splitContainer.Panel2.Padding = new Padding(this.splitContainer.Panel2.Padding.Left, offset / 2, this.splitContainer.Panel2.Padding.Right, offset / 2);
            }
        }

        public String DateFormat { get { return this.dateTimePicker.CustomFormat; } set { this.dateTimePicker.CustomFormat = value; } }

        public DateTime Content { get { return this.dateTimePicker.Value; } set { this.dateTimePicker.Value = value; } }
    }
}
