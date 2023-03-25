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

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.NodeMouseDoubleClick != null) this.NodeMouseDoubleClick(sender, e);
        }

        public event TreeNodeMouseClickEventHandler NodeMouseDoubleClick;

        /// <summary>
        /// 创建族长节点
        /// </summary>
        /// <param name="name">节点标识</param>
        /// <returns>族长</returns>
        public WalnutTreeNode createPatriarchy()
        {
            // 构造节点
            var patriarchy = new WalnutTreeNode();

            // 建立关联
            this.treeView.Nodes.Add(patriarchy);

            return patriarchy;
        }
    }
}
