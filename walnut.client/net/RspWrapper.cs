using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walnut.client.net
{
    /// <summary>
    /// 响应包装器
    /// </summary>
    public class RspWrapper<T> where T : class
    {
        /// <summary>
        /// 响应码
        /// </summary>
        public int code { get; set; } = 0;

        /// <summary>
        /// 错误原因
        /// </summary>
        public String message { get; set; } = null;

        /// <summary>
        /// 响应数据
        /// </summary>
        public T data { get; set; } = null;
    }
}
