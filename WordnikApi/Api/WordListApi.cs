using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordnikApi.Common;
using WordnikApi.Models;

namespace WordnikApi.Api
{
    public class WordListApi : ApiBase
    {
        public async void UpdateWordList(string permalink, WordList body, string auth_token)
        {
            if (string.IsNullOrWhiteSpace(permalink))
            {
                throw new ArgumentNullException("permalink");
            }
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }

            string path = string.Format("/wordList.json/{0}", permalink);
            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", auth_token);

            await ProcessResult<object>(path, HttpMethods.PUT, null, body, headerParams);
        }

        public async void DeleteWordList(string permalink, WordList body, string auth_token)
        {
            if (string.IsNullOrWhiteSpace(permalink))
            {
                throw new ArgumentNullException("permalink");
            }
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }

            string path = string.Format("/wordList.json/{0}", permalink);
            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", auth_token);

            await ProcessResult<object>(path, HttpMethods.DELETE, null, body, headerParams);
        }

        public async Task<WordList> GetWordListByPermalink(string permalink, string auth_token)
        {
            if (string.IsNullOrWhiteSpace(permalink))
            {
                throw new ArgumentNullException("permalink");
            }
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }

            string path = string.Format("/wordList.json/{0}", permalink);
            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", auth_token);

            return await ProcessResult<WordList>(path, HttpMethods.DELETE, null, null, headerParams);
        }

        public async void AddWordsToWordList(string permalink, List<StringValue> body, string auth_token)
        {
            if (string.IsNullOrWhiteSpace(permalink))
            {
                throw new ArgumentNullException("permalink");
            }
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }

            string path = string.Format("/wordList.json/{0}/words", permalink);
            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", auth_token);

            await ProcessResult<WordList>(path, HttpMethods.DELETE, null, body, headerParams);
        }

        public async Task<List<WordListWord>> GetWordListWords(string permalink, string auth_token, string sortBy, string sortOrder, int skip, int limit)
        {
            if (string.IsNullOrWhiteSpace(permalink))
            {
                throw new ArgumentNullException("permalink");
            }
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }
            string path = string.Format("/wordList.json/{0}/words", permalink);
            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", auth_token);

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("sortBy", sortBy, queryParams);
            AddToQueryParamsIfNotEmpty("sortOrder", sortOrder, queryParams);
            AddToQueryParamsIfNotEmpty("skip", skip.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<List<WordListWord>>(path, HttpMethods.GET, queryParams, null, headerParams);
        }

        public async void DeleteWordsFromWordList(string permalink, List<StringValue> body, string auth_token)
        {

            if (string.IsNullOrWhiteSpace(permalink))
            {
                throw new ArgumentNullException("permalink");
            }
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }

            string path = string.Format("/wordList.json/{0}/deleteWords", permalink);
            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", auth_token);

            await ProcessResult<WordList>(path, HttpMethods.POST, null, body, headerParams);
        }
    }
}