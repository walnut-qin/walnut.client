using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public class WalnutTreeNode
    {
        /// <summary>
        /// 节点实体
        /// </summary>
        private TreeNode treeNode;

        /// <summary>
        /// 父节点
        /// </summary>
        private WalnutTreeNode parent;

        /// <summary>
        /// 孩子节点
        /// </summary>
        private Dictionary<String, WalnutTreeNode> children;

        /// <summary>
        /// 显示文本
        /// </summary>
        public String Text { get { return this.treeNode.Text; } set { this.treeNode.Text = value; } }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="genealogy">家谱</param>
        public WalnutTreeNode(TreeView genealogy)
        {
            // 若空，异常
            if (genealogy == null) throw new Exception("WalnutTreeNode构造异常, genealogy为空");

            // 挂载父子节点
            this.parent = null;
            this.children = new Dictionary<String, WalnutTreeNode>();

            // 实体关联
            this.treeNode = new TreeNode();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="parent">父节点</param>
        public WalnutTreeNode(WalnutTreeNode parent)
        {
            // 若空，异常
            if (parent == null) throw new Exception("WalnutTreeNode构造异常, parent为空");

            // 挂载父子节点
            this.parent = parent;
            this.children = new Dictionary<String, WalnutTreeNode>();

            // 实体关联
            this.treeNode = new TreeNode();
            parent.treeNode.Nodes.Add(this.treeNode);
        }

        /// <summary>
        /// 找到指名的孩子
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public WalnutTreeNode getChild(String name)
        {
            // 若署名孩子已存在，则无法创建
            if (!this.children.ContainsKey(name))
            {
                return null;
            }
            return this.children[name];
        }

        /// <summary>
        /// 造孩子
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public WalnutTreeNode createChild(String name)
        {
            // 若署名孩子已存在，则不再创建
            var child = this.getChild(name);
            if (child != null)
            {
                return child;
            }

            // 创建新孩子
            child = new WalnutTreeNode(this);
            this.children.Add(name, child);

            return child;
        }

        /// <summary>
        /// 销毁某个孩子
        /// </summary>
        public void destroyChild(String name)
        {
            // 若署名孩子不存在，则不再销毁
            var child = this.getChild(name);
            if (child == null)
            {
                return;
            }

            // 若署名孩子存在，则断开与孩子的所有关联，销毁工作交给GC
            this.treeNode.Nodes.Remove(child.treeNode);
            this.children.Remove(name);
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
            this.treeNode.Nodes.Clear();
            this.children.Clear();
        }
    }
}
