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

        private Object m_Value;
        public new Object Value
        {
            get
            {
                return this.m_Value;
            }
            set
            {
                this.m_Value = value;
                base.Value = value == null ? String.Empty : value.ToString();
            }
        }

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
                this.Value = this.Dialog.Value;
            }
        }
    }
}
