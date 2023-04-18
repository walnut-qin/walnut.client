using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace walnut.client.ui
{
    public partial class WalnutDialog : Form
    {
        public WalnutDialog()
        {
            InitializeComponent();
        }

        public WalnutDialogResult walnutDialogResult { get; protected set; }
    }
}
