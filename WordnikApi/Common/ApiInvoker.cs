using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WordnikApi.Api;

namespace WordnikApi.Common
{
    public class ApiInvoker
    {
        public async Task<string> InvokeAPI(string host, string path, string method, Dictionary<string, string> queryParams, object body, Dictionary<string, string> headerParams)
        {
            var client = new HttpClient();
            string queryString = string.Empty;

            if (queryParams != null)
            {
                queryString = generateQueryString(queryParams);
            }

            var fullPath = new Uri(string.Format("{0}{1}{2}", host, path, queryString));

            client.DefaultRequestHeaders.Add("api_key", ApiKey.Key);

            if (headerParams != null)
            {
                foreach (string key in headerParams.Keys)
                {
                    client.DefaultRequestHeaders.Add(key, headerParams[key]);
                }
            }

            HttpResponseMessage response = null;
            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody);

            switch (method)
            {
                case "GET":
                    response = await client.GetAsync(fullPath);
                    break;
                case "POST":
                    response = await client.PostAsync(fullPath, content);
                    break;
                case "PUT":
                    response = await client.PutAsync(fullPath, content);
                    break;
                case "DELETE":
                    response = await client.DeleteAsync(fullPath);
                    break;
                default:
                    throw new ApiException(500, string.Format("Unknown method type {0}", method));
            }
            return await response.Content.ReadAsStringAsync();
        }

        private string generateQueryString(Dictionary<string, string> queryParams)
        {
            var queryStringBuilder = new StringBuilder();

            foreach (string key in queryParams.Keys)
            {
                string value = queryParams[key];
                if (value != null)
                {
                    if (queryStringBuilder.ToString().Length == 0)
                    {
                        queryStringBuilder.Append("?");
                    }
                    else
                    {
                        queryStringBuilder.Append("&");
                    }
                    queryStringBuilder.AppendFormat("{0}={1}", key, value);
                }
            }
            return queryStringBuilder.ToString();
        }
    }
}