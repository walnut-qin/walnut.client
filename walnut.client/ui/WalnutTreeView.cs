using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutTreeView : TreeView
    {
        /// <summary>
        /// 孩子节点
        /// </summary>
        public Dictionary<String, WalnutTreeNode> children { get; } = new Dictionary<string, WalnutTreeNode>();

        public WalnutTreeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 找到指名的孩子
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public WalnutTreeNode getChild(String name)
        {
            // 若署名孩子已存在，则无法创建
            if (name == null || !this.children.ContainsKey(name))
            {
                return null;
            }
            return this.children[name];
        }

        /// <summary>
        /// 找到指名的孩子
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public WalnutTreeNode getChild(int index)
        {
            if (index < 0 || index >= this.Nodes.Count)
            {
                return null;
            }
            return this.Nodes[index] as WalnutTreeNode;
        }

        /// <summary>
        /// 造孩子
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public WalnutTreeNode createChild(String name = null)
        {
            // 若署名孩子已存在，则不再创建
            var child = this.getChild(name);
            if (child != null)
            {
                return child;
            }

            // 为匿名孩子取名
            if (name == null)
            {
                name = String.Format("{0}-{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), this.children.Count.ToString());
            }

            // 创建实体
            child = new WalnutTreeNode();
            this.children.Add(name, child);
            this.Nodes.Add(child);

            return child;
        }

        /// <summary>
        /// 销毁某个孩子
        /// </summary>
        public void removeChild(String name)
        {
            // 若署名孩子不存在，则不再销毁
            var child = this.getChild(name);
            if (child == null)
            {
                return;
            }

            // 若署名孩子存在，则断开与孩子的所有关联，销毁工作交给GC
            this.children.Remove(name);
            this.Nodes.Remove(child);
        }

        /// <summary>
        /// 清空所有孩子
        /// </summary>
        public void clearChildren()
        {
            // 若无子，则结束
            if (this.children.Count <= 0)
            {
                return;
            }

            // 断开与所有孩子的所有关联，销毁工作交给GC
            this.children.Clear();
            this.Nodes.Clear();
        }
    }
}
