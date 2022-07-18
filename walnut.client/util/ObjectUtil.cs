using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Swifter.Json;

namespace walnut.client.util
{
    public static class ObjectUtil
    {
        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string toJson(this Object obj)
        {
            return JsonFormatter.SerializeObject(obj);
        }
    }
}
