using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutInputWithDialog : walnut.client.ui.WalnutInput
    {
        public WalnutInputWithDialog()
        {
            InitializeComponent();
        }

        public WalnutDialog Dialog { get; set; }

        public Object Data { get; set; }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
            {
                return;
            }

            if (this.Dialog != null)
            {
                var result = this.Dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                this.Data = this.Dialog.getDialogResult();
                base.Content = this.Data.ToString();
            }
        }
    }
}
