﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace HigLabo.Net
{
    public partial class HttpClient
    {
        protected Task<TResult> AsyncCall<TResult>(HttpRequestCommand command, Func<HttpWebResponse, TResult> func)
        {
            var source = new TaskCompletionSource<TResult>();
            this.GetHttpWebResponse(command
                , res => source.SetResult(func(res))
                , e => source.SetException(e.Exception));
            return source.Task;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<HttpWebResponse> GetHttpWebResponseAsync(String url)
        {
            var cm = new HttpRequestCommand(url);
            return this.GetHttpWebResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<HttpWebResponse> GetHttpWebResponseAsync(String url, HttpBodyFormUrlEncodedData data)
        {
            var cm = new HttpRequestCommand(url, data);
            return this.GetHttpWebResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<HttpWebResponse> GetHttpWebResponseAsync(String url, Byte[] data)
        {
            var cm = new HttpRequestCommand(url, data);
            return this.GetHttpWebResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Task<HttpWebResponse> GetHttpWebResponseAsync(String url, Stream stream)
        {
            var cm = new HttpRequestCommand(url, stream);
            return this.GetHttpWebResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public Task<HttpWebResponse> GetHttpWebResponseAsync(HttpRequestCommand command)
        {
            return AsyncCall<HttpWebResponse>(command, res => res);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<HttpResponse> GetResponseAsync(String url)
        {
            var cm = new HttpRequestCommand(url);
            return this.GetResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<HttpResponse> GetResponseAsync(String url, HttpBodyFormUrlEncodedData data)
        {
            var cm = new HttpRequestCommand(url, data);
            return this.GetResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<HttpResponse> GetResponseAsync(String url, Byte[] data)
        {
            var cm = new HttpRequestCommand(url, data);
            return this.GetResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Task<HttpResponse> GetResponseAsync(String url, Stream stream)
        {
            var cm = new HttpRequestCommand(url, stream);
            return this.GetResponseAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public Task<HttpResponse> GetResponseAsync(HttpRequestCommand command)
        {
            return AsyncCall<HttpResponse>(command, res => new HttpResponse(res, this.ResponseEncoding));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<String> GetBodyTextAsync(String url)
        {
            var cm = new HttpRequestCommand(url);
            return this.GetBodyTextAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<String> GetBodyTextAsync(String url, HttpBodyFormUrlEncodedData data)
        {
            var cm = new HttpRequestCommand(url, data);
            return this.GetBodyTextAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<String> GetBodyTextAsync(String url, Byte[] data)
        {
            var cm = new HttpRequestCommand(url, data);
            return this.GetBodyTextAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Task<String> GetBodyTextAsync(String url, Stream stream)
        {
            var cm = new HttpRequestCommand(url, stream);
            return this.GetBodyTextAsync(cm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public Task<String> GetBodyTextAsync(HttpRequestCommand command)
        {
            return AsyncCall<String>(command, res => new HttpResponse(res, this.ResponseEncoding).BodyText);
        }
    }
}
