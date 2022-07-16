using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace walnut.client.util
{
    public static class ObjectUtil
    {
        /// <summary>
        /// 时间格式化转换器
        /// </summary>
        static IsoDateTimeConverter dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };

        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string toJson(this Object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented, dateTimeConverter);
        }

        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string toXml(this Object obj)
        {
            return JsonConvert.DeserializeXmlNode(toJson(obj)).InnerXml;
        }
    }
}
