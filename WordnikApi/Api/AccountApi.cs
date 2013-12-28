using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordnikApi.Common;
using WordnikApi.Models;

namespace WordnikApi.Api
{
    public class AccountApi : ApiBase
    {
        public async Task<AuthenticationToken> Authenticate(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("userName");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("password");
            }

            string path = string.Format("/account.json/authenticate/{0}", userName);
          
            var queryParams = new Dictionary<string, string>();
            queryParams.Add("password", password);

            return await ProcessResult<AuthenticationToken>(path, HttpMethods.GET, queryParams);
        }

        public async Task<AuthenticationToken> AuthenticatePost(string userName, string body)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("userName");
            }

            if (string.IsNullOrWhiteSpace(body))
            {
                throw new ArgumentNullException("password");
            }

            string path = string.Format("/account.json/authenticate/{0}", userName);

            return await ProcessResult<AuthenticationToken>(path, HttpMethods.POST, null, body);
        }

        public async Task<ApiTokenStatus> GetApiTokenStatus()
        {
            string path = "/account.json/apiTokenStatus";

            return await ProcessResult<ApiTokenStatus>(path, HttpMethods.GET, null);
        }

        public async Task<User> GetLoggedInUser(string authToken)
        {
            if (string.IsNullOrWhiteSpace(authToken))
            {
                throw new ArgumentNullException("authToken");
            }
            string path = "/account.json/user";

            var headerParams = new Dictionary<String, String>();
            headerParams.Add("auth_token", authToken);

            return await ProcessResult<User>(path, HttpMethods.GET, null, null, headerParams);
        }

        public async Task<List<WordList>> GetWordListsForLoggedInUser(string auth_token, int skip, int limit)
        {
            if (string.IsNullOrWhiteSpace(auth_token))
            {
                throw new ArgumentNullException("auth_token");
            }

            string path = "/account.json/wordLists";

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();

            AddToQueryParamsIfNotEmpty("skip", skip.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            headerParams.Add("auth_token", auth_token);

            return await ProcessResult<List<WordList>>(path, HttpMethods.GET, queryParams, null, headerParams);
        }
    }
}