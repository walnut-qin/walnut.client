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
    public partial class WalnutTreeView : UserControl
    {
        public WalnutTreeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 创建族长节点
        /// </summary>
        /// <param name="name">节点标识</param>
        /// <returns>族长</returns>
        public WalnutTreeNode createPatriarchy(String name)
        {
            return new WalnutTreeNode(this.treeView);
        }
    }
}
