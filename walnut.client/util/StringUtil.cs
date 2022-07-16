using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walnut.client.util
{
    public static class StringUtil
    {
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
    }
}
