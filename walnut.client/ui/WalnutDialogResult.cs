using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walnut.client.ui
{
    public class WalnutDialogResult
    {
        /// <summary>
        /// 用于展示的值
        /// </summary>
        public String mask { get; set; } = String.Empty;

        /// <summary>
        /// 实际选中的对象
        /// </summary>
        public Object result { get; set; } = null;
    }
}
