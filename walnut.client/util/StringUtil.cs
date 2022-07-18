using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using Swifter.Json;

namespace walnut.client.util
{
    public static class StringUtil
    {
        /// <summary>
        /// 获取字节码
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <returns>字节码数组</returns>
        public static Byte[] getBytes(this String s)
        {
            return Encoding.UTF8.GetBytes(s);
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <returns>转换目标</returns>
        public static Decimal toDecimal(this String s)
        {
            return Decimal.Parse(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue">默认值，若转换失败，返回该值</param>
        /// <returns></returns>
        public static Decimal toDecimal(this String s, Decimal defaultValue)
        {
            try
            {
                return s.toDecimal();
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转换为枚举
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <param name="converter">转换器</param>
        /// <returns></returns>
        public static T toEnum<T>(this String s, Converter<String, T> converter) where T : System.Enum
        {
            if (converter == null)
            {
                throw new Exception("转换器不能为空");
            }
            return converter.Invoke(s);
        }

        /// <summary>
        /// 转换为枚举
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <param name="converter">转换器</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static T toEnum<T>(this String s, Converter<String, T> converter, T defaultValue) where T : System.Enum
        {
            try
            {
                return s.toEnum(converter);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <returns>转换目标</returns>
        public static DateTime toDateTime(this String s)
        {
            return DateTime.Parse(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue">默认值，若转换失败，返回该值</param>
        /// <returns></returns>
        public static DateTime toDateTime(this String s, DateTime defaultValue)
        {
            try
            {
                return s.toDateTime();
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转为数值
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <returns>转换目标</returns>
        public static T toJson<T>(this String s)
        {
            return JsonFormatter.DeserializeObject<T>(s);
        }

        /// <summary>
        /// 将json字符串转为对象
        /// </summary>
        /// <param name="s"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T toJson<T>(this string s, T defaultValue)
        {
            try
            {
                return s.toJson<T>();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// base64加密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String base64Encode(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return Convert.ToBase64String(s.getBytes());
        }

        /// <summary>
        /// base64解密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String base64Decode(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
    }
}
