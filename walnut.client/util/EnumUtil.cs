using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace walnut.client.util
{
    public static class EnumUtil
    {
        /// <summary>
        /// 获取描述域
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string getDescription(this Enum e)
        {
            FieldInfo field = e.GetType().GetField(e.ToString());
            object[] obj = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (obj != null && obj.Length > 0)
            {
                DescriptionAttribute descriptionAttribute = (System.ComponentModel.DescriptionAttribute)obj[0];
                return descriptionAttribute.Description;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
