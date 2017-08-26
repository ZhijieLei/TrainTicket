using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using TrainService.Configs;
using TrainService.Exceptions;

namespace TrainService.NetworkHelpers
{
    public static class ApiHelper
    {
        public static T Get<T>(string apiUrl, IDictionary<string, object> getContent)
        {
            var contentStrings = getContent?.Select(content => $"{content.Key}={content.Value}") ?? new string[0];
            var completeUrl = apiUrl + "?" + string.Join("&", contentStrings);
            var webRequest = (HttpWebRequest) WebRequest.Create(completeUrl);
            webRequest.Timeout = StaticConfig.Timeout;
            webRequest.Method = "GET";
            webRequest.UserAgent= "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:54.0) Gecko/20100101 Firefox/54.0";
            webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            webRequest.Headers.Add("Accept-Language: zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            webRequest.Headers.Add("DNT: 1");
            webRequest.Headers.Add("Pragma: no-cache");
            webRequest.Headers.Add("Cache-Control: no-cache");
            var webResponse = (HttpWebResponse) webRequest.GetResponse();
            var webResponseStream = webResponse.GetResponseStream();
            if (webResponseStream == null) throw Network.LinkFailed;
            var webResponseReader = new StreamReader(webResponseStream);
            var responseJson = webResponseReader.ReadToEnd();
            webRequest.Abort();
            webResponse.Close();
            webResponseReader.Close();
            return JsonConvert.DeserializeObject<T>(responseJson, StaticConfig.JsonSerializeSettings);
            
        }

        public static T Post<T>(string apiUrl, object postContent)
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(apiUrl);
            webRequest.ContentType = StaticConfig.PostContentType;
            webRequest.Timeout = StaticConfig.Timeout;
            webRequest.Method = "POST";
            var requestJson = JsonConvert.SerializeObject(postContent, StaticConfig.JsonSerializeSettings);
            var requestJsonBytes = Encoding.UTF8.GetBytes(requestJson);
            webRequest.ContentLength = requestJsonBytes.Length;
            webRequest.GetRequestStream().Write(requestJsonBytes, 0, requestJsonBytes.Length);
            var webResponse = (HttpWebResponse) webRequest.GetResponse();
            var webResponseStream = webResponse.GetResponseStream();
            if (webResponseStream == null) throw Network.LinkFailed;
            var webResponseReader = new StreamReader(webResponseStream);
            var responseJson = webResponseReader.ReadToEnd();
            webRequest.Abort();
            webResponse.Close();
            webResponseReader.Close();
            return JsonConvert.DeserializeObject<T>(responseJson, StaticConfig.JsonSerializeSettings);
        }
    }
}