using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace NetDimension.Net
{
	public class HttpRequest
	{
		const string DEFAULT_USER_AGENT = @"Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/38.0.2125.111 Safari/537.36";
		private HttpWebRequest request;

		/// <summary>
		/// 获取或设置UserAgent
		/// </summary>
		public string UserAgent
		{
			get;
			set;
		}

		/// <summary>
		/// 获取或设置发送请求地址
		/// </summary>
		public string Url
		{
			get;
			set;
		}
		/// <summary>
		/// 获取或设置ContentType
		/// </summary>
		public string ContentType
		{
			get;
			set;
		}
		/// <summary>
		/// 获取或设置Method，默认：GET
		/// </summary>
		public string Method
		{
			get;
			set;
		}
		/// <summary>
		/// 获取或设置异步请求，默认：True
		/// </summary>
		public bool Async
		{
			get;
			set;
		}

		/// <summary>
		/// 获取或设置发送到服务器的数据
		/// 类型：string 或 匿名类
		/// </summary>
		public object Data
		{
			get;
			set;
		}

		/// <summary>
		/// 获取或设置执行请求前修改HttpWebRequest的参数，例如加入证书验证或修改Headers等
		/// </summary>
		public Action<HttpWebRequest> BeforeSend
		{
			get;
			set;
		}


		public HttpRequest()
		{
			request = new HttpWebRequest();

		}

		public void Send()
		{
			var uriBuilder = new UriBuilder(Url);
		}


	}
}
