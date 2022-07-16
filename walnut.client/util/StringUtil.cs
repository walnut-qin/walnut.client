using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace walnut.client.util
{
    public static class StringUtil
    {
        /// <summary>
        /// 时间格式化转换器
        /// </summary>
        static IsoDateTimeConverter dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };

        /// <summary>
        /// 获取字节码
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <returns>字节码数组</returns>
        public static Byte[] getBytes(this String source)
        {
            return Encoding.UTF8.GetBytes(source);
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <returns>转换目标</returns>
        public static Decimal toDecimal(this String source)
        {
            return Decimal.Parse(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue">默认值，若转换失败，返回该值</param>
        /// <returns></returns>
        public static Decimal toDecimal(this String source, Decimal defaultValue)
        {
            try
            {
                return source.toDecimal();
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转换为枚举
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <param name="converter">转换器</param>
        /// <returns></returns>
        public static Enum toEnum(this String source, Converter<String, Enum> converter)
        {
            if (converter == null)
            {
                throw new Exception("转换器不能为空");
            }
            return converter.Invoke(source);
        }

        /// <summary>
        /// 转换为枚举
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <param name="converter">转换器</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Enum toEnum(this String source, Converter<String, Enum> converter, Enum defaultValue)
        {
            try
            {
                return source.toEnum(converter);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <returns>转换目标</returns>
        public static DateTime toDateTime(this String source)
        {
            return DateTime.Parse(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue">默认值，若转换失败，返回该值</param>
        /// <returns></returns>
        public static DateTime toDateTime(this String source, DateTime defaultValue)
        {
            try
            {
                return source.toDateTime();
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <returns>转换目标</returns>
        public static T toJson<T>(this String source)
        {
            return JsonConvert.DeserializeObject<T>(source, dateTimeConverter);
        }

        /// <summary>
        /// 将json字符串转为对象
        /// </summary>
        /// <param name="s"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T toJson<T>(this string source, T defaultValue)
        {
            try
            {
                return source.toJson<T>();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <returns>转换目标</returns>
        public static T toXml<T>(this String source)
        {
            // 加载xml字符串
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(source);
            String jsonString = JsonConvert.SerializeXmlNode(xmlDocument);

            // 反序列化
            return JsonConvert.DeserializeObject<T>(jsonString, dateTimeConverter);
        }

        /// <summary>
        /// 将json字符串转为对象
        /// </summary>
        /// <param name="s"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T toXml<T>(this string source, T defaultValue)
        {
            try
            {
                return source.toXml<T>();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// base64加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String base64Encode(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return string.Empty;
            }

            return Convert.ToBase64String(source.getBytes());
        }

        /// <summary>
        /// base64解密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String base64Decode(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return string.Empty;
            }

            return Encoding.UTF8.GetString(Convert.FromBase64String(source));
        }
    }
}
