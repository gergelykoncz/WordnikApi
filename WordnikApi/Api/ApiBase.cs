using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordnikApi.Common;

namespace WordnikApi.Api
{
    public abstract class ApiBase
    {
        protected readonly ApiInvoker _apiInvoker;
        private string _basePath = "http://api.wordnik.com/v4";

        public ApiBase()
        {
            _apiInvoker = new ApiInvoker();
        }

        protected async virtual Task<T> ProcessResult<T>(string path, string method, Dictionary<string, string> queryParams, object body, Dictionary<string, string> headerParams)
            where T : class
        {
            try
            {
                String response = await _apiInvoker.InvokeAPI(_basePath, path, method, queryParams, body, headerParams);
                if (response != null)
                {
                    return JsonConvert.DeserializeObject<T>(response);
                }
                else
                {
                    return null;
                }
            }
            catch (ApiException ex)
            {
                if (ex.Code == 404)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        protected async Task<T> ProcessResult<T>(string path, string method, Dictionary<string, string> queryParams, object body)
            where T:class
        {
            return await ProcessResult<T>(path, method, queryParams, body, null);
        }

        protected async Task<T> ProcessResult<T>(string path, string method, Dictionary<string, string> queryParams)
            where T : class
        {
            return await ProcessResult<T>(path, method, queryParams, null, null);
        }

        protected void AddToQueryParamsIfNotEmpty(string paramName, string value, Dictionary<string, string> queryParams)
        {
            if (string.IsNullOrWhiteSpace(value) == false && value != "0")
            {
                queryParams.Add(paramName, value);
            }
        }
    }
}
