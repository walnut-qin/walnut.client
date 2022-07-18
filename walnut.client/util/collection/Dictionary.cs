using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walnut.client.util.collection
{
    public static class DictionaryUtil
    {
        /// <summary>
        /// 获取描述域
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static V getValueOrDefault<K, V>(this Dictionary<K, V> d, K key)
        {
            try
            {
                return d[key];
            }
            catch (System.Exception)
            {
                return default(V);
            }
        }
    }
}
