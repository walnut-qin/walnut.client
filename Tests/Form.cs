using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.walnutComboBox.setSelectedItems(new List<string>() { "测试项1", "测试项2", "测试项3" }, "测试项2");

            this.walnutInputWithDialog.Dialog = new walnut.client.ui.WalnutDialog();

            // 创建族长
            var root = this.walnutTreeView1.createPatriarchy().setText("root");
            root.createChild().setText("node1").createChild().setText("node3");
            root.createChild().setText("node2");

            root.removeChild("0");
        }
    }
}
