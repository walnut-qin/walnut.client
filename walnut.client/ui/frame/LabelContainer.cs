using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui.helper
{
    public partial class LabelContainer : UserControl
    {
        public LabelContainer()
        {
            InitializeComponent();
        }

        public String Title { get { return this.label.Text; } set { this.label.Text = value; } }
    }
}
