using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutLabel : walnut.client.ui.helper.LabelContainer
    {
        public WalnutLabel()
        {
            InitializeComponent();
        }

        public String Value { get { return this.content.Text; } set { this.content.Text = value; } }
    }
}
