using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutDivider : UserControl
    {
        public WalnutDivider()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载后，重新计算布局，确保分割线位于容器中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WalnutDivider_Load(object sender, EventArgs e)
        {
            var offset = this.Size.Height - this.label.Size.Height;
            if (offset > 0)
            {
                this.Padding = new Padding(this.Padding.Left, offset / 2, this.Padding.Right, offset / 2);
            }
        }
    }
}
