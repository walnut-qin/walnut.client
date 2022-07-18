using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using walnut.client.util;

namespace walnut.client.net
{
    /// <summary>
    /// web接口
    /// </summary>
    public class RestTemplate
    {
        /// <summary>
        /// token
        /// </summary>
        static readonly String token = "walnut";

        /// <summary>
        /// 用户
        /// </summary>
        readonly String user;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="user"></param>
        public RestTemplate(String user)
        {
            this.user = user;
        }

        /// <summary>
        /// GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="uriVars"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public RspWrapper<T> get<T>(String url, Object[] uriVars)
        {
            // 创建Http请求
            var request = WebRequest.Create("http://172.16.100.252" + String.Format(url, uriVars));

            // 设置参数
            request.Method = "GET";
            request.Timeout = 5000;

            // 写入Header
            request.Headers.Add("Token", token);
            request.Headers.Add("FakeUser", user);

            // 获取响应
            var webResponse = request.GetResponse() as HttpWebResponse;

            // 读取响应
            using (Stream s = webResponse.GetResponseStream())
            {
                var reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd().toJson<RspWrapper<T>>();
            }
        }

        /// <summary>
        /// POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="body"></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public RspWrapper<T> post<T>(String url, Object body)
        {
            // 创建Http请求
            var request = WebRequest.Create("http://172.16.100.252" + url);

            // 设置参数
            request.Method = "POST";
            request.Timeout = 5000;

            // 写入Header
            request.Headers.Add("Token", token);

            // 构造body
            var data = body.toJson().getBytes();
            request.ContentLength = data.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            // 获取响应
            var webResponse = request.GetResponse() as HttpWebResponse;

            // 读取响应
            using (Stream s = webResponse.GetResponseStream())
            {
                var reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd().toJson<RspWrapper<T>>();
            }
        }
    }
}
