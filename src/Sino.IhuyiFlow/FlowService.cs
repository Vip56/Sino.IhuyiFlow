using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sino.IhuyiFlow
{
    public class FlowService : IFlowService
    {
        private string _url;
        private string _userName;
        private string _apiKey;

        public FlowService(string url, string userName, string apiKey)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException(nameof(userName));
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException(nameof(apiKey));

            _url = url;
            _userName = userName;
            _apiKey = apiKey;
        }

        public static string MD5Hash(string value)
        {
            byte[] bytes;
            using (var md5 = MD5.Create())
            {
                bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
            }
            var result = new StringBuilder();
            foreach (byte t in bytes)
            {
                result.Append(t.ToString("x2"));
            }
            return result.ToString();
        }

        public static string GetTimeStamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public async Task<CheckBalanceResponse> CheckBalanceAsync()
        {
            string timestamp = GetTimeStamp();
            string sign = MD5Hash($"apikey={_apiKey}&timestamp={timestamp}&username={_userName}");
            Dictionary<string, string> dicreuqest = new Dictionary<string, string>();
            dicreuqest.Add("action", "getbalance");
            dicreuqest.Add("sign", sign);
            dicreuqest.Add("timestamp", timestamp);
            dicreuqest.Add("username", _userName);
            CheckBalanceResponse result = new CheckBalanceResponse
            {
                Code = ResultCode.InternalError,
                Message = "请求未成功"
            };

            HttpClient client = new HttpClient();
            var content = new FormUrlEncodedContent(dicreuqest);
            var response = await client.PostAsync(_url, content);
            if(response.IsSuccessStatusCode)
            {
                string contentstr = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<CheckBalanceResponse>(contentstr);
            }
            return result;
        }

        public async Task<QueryRechargeStateResponse> QueryRechargeStateAsync(int count)
        {
            string timestamp = GetTimeStamp();
            string sign = MD5Hash($"apikey={_apiKey}&count={count}&timestamp={timestamp}&username={_userName}");
            Dictionary<string, string> dicreuqest = new Dictionary<string, string>();
            dicreuqest.Add("action", "getreports");
            dicreuqest.Add("count", count.ToString());
            dicreuqest.Add("sign", sign);
            dicreuqest.Add("timestamp", timestamp);
            dicreuqest.Add("username", _userName);
            QueryRechargeStateResponse result = new QueryRechargeStateResponse
            {
                Code = ResultCode.InternalError,
                Message = "请求未成功"
            };

            HttpClient client = new HttpClient();
            var content = new FormUrlEncodedContent(dicreuqest);
            var response = await client.PostAsync(_url, content);
            if (response.IsSuccessStatusCode)
            {
                string contentstr = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<QueryRechargeStateResponse>(contentstr);
            }
            return result;
        }

        public async Task<RechargeResponse> RechargeAsync(string mobile, string package, string orderId)
        {
            string timestamp = GetTimeStamp();
            string sign = MD5Hash($"apikey={_apiKey}&mobile={mobile}&orderid={orderId}&package={package}&timestamp={timestamp}&username={_userName}");
            Dictionary<string, string> dicreuqest = new Dictionary<string, string>();
            dicreuqest.Add("action", "recharge");
            dicreuqest.Add("username", _userName);
            dicreuqest.Add("mobile", mobile);
            dicreuqest.Add("orderid", orderId);
            dicreuqest.Add("package", package);
            dicreuqest.Add("timestamp", timestamp.ToString());
            dicreuqest.Add("sign", sign);

            RechargeResponse result = new RechargeResponse
            {
                Code = ResultCode.InternalError,
                Message = "请求未成功"
            };

            HttpClient client = new HttpClient();
            var content = new FormUrlEncodedContent(dicreuqest);
            var response = await client.PostAsync(_url, content);
            if (response.IsSuccessStatusCode)
            {
                string contentstr = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<RechargeResponse>(contentstr);
            }
            return result;
        }
    }
}
