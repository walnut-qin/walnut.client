using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutSwitch : walnut.client.ui.helper.LabelContainer
    {
        public WalnutSwitch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载后，重新计算布局，确保开关位于容器中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WalnutSwitch_Load(object sender, EventArgs e)
        {
            var offset = this.splitContainer.Size.Height - 24;
            if (offset > 0)
            {
                this.splitContainer.Panel2.Padding = new Padding(this.splitContainer.Panel2.Padding.Left, offset / 2, this.splitContainer.Panel2.Padding.Right, offset / 2);
            }
        }

        public Boolean Checked { get { return this.toggleSwitch.Checked; } set { this.toggleSwitch.Checked = value; } }

        public String TrueText { get { return this.toggleSwitch.TrueText; } set { this.toggleSwitch.TrueText = value; } }

        public String FalseText { get { return this.toggleSwitch.FalseText; } set { this.toggleSwitch.FalseText = value; } }

        public Color TrueColor { get { return this.toggleSwitch.TrueColor; } set { this.toggleSwitch.TrueColor = value; } }

        public Color FalseColor { get { return this.toggleSwitch.FalseColor; } set { this.toggleSwitch.FalseColor = value; } }

        public helper.Switch.SwitchTypeEnum SwitchType { get { return this.toggleSwitch.SwitchType; } set { this.toggleSwitch.SwitchType = value; } }
    }
}
