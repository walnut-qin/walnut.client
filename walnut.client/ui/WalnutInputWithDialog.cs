﻿using System;
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

        public new Object Value { get; private set; }

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

                // 设置值
                base.Value = this.Dialog.walnutDialogResult.mask;
                this.Value = this.Dialog.walnutDialogResult.result;
            }
        }
    }
}
