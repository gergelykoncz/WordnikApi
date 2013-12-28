using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordnikApi.Common;
using WordnikApi.Models;

namespace WordnikApi.Api
{
    public class WordListsApi : ApiBase
    {
        public async Task<WordList> CreateWordList(WordList body, string auth_token)
        {
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }
            string path = "/wordLists.json";

            var headerParams = new Dictionary<string, string>();
            headerParams.Add("auth_token", auth_token);

            return await ProcessResult<WordList>(path, HttpMethods.POST, null, body, headerParams);
        }
    }
}