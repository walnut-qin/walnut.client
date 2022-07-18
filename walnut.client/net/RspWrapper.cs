using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walnut.client.net
{
    /// <summary>
    /// 响应包装器
    /// </summary>
    public class RspWrapper<T>
    {
        /// <summary>
        /// 响应码
        /// </summary>
        int code { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        String message { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        T data { get; set; }
    }
}
