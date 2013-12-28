using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordnikApi.Common;
using WordnikApi.Models;

namespace WordnikApi.Api
{
    public class WordsApi : ApiBase
    {
        public async Task<WordSearchResults> SearchWords(string query, string includePartOfSpeech, string excludePartOfSpeech,
            string caseSensitive, int minCorpusCount, int maxCorpusCount, int minDictionaryCount, int maxDictionaryCount,
            int minLength, int maxLength, int skip, int limit)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException("maxCorpusCount");
            }
            string path = string.Format("/words.json/search/{0}", query);

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("includePartOfSpeech", includePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("excludePartOfSpeech", excludePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("caseSensitive", caseSensitive, queryParams);
            AddToQueryParamsIfNotEmpty("minCorpusCount", minCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxCorpusCount", maxCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minDictionaryCount", minDictionaryCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxDictionaryCount", maxDictionaryCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minLength", minLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxLength", maxLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("skip", skip.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<WordSearchResults>(path, HttpMethods.GET, queryParams);
        }

        public async Task<WordOfTheDay> GetWordOfTheDay(string date)
        {
            string path = "/words.json/wordOfTheDay";

            var queryParams = new Dictionary<string, string>();
            AddToQueryParamsIfNotEmpty("date", date, queryParams);

            return await ProcessResult<WordOfTheDay>(path, HttpMethods.GET, queryParams);
        }

        public async Task<DefinitionSearchResults> ReverseDictionary(string query, string findSenseForWord, string includeSourceDictionaries, string excludeSourceDictionaries, string includePartOfSpeech,
            string excludePartOfSpeech, string expandTerms, string sortBy, string sortOrder, int minCorpusCount, int maxCorpusCount, int minLength, int maxLength, string includeTags, string skip, int limit)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException("maxCorpusCount");
            }
            string path = "/words.json/reverseDictionary";
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("query", query, queryParams);
            AddToQueryParamsIfNotEmpty("findSenseForWord", findSenseForWord, queryParams);
            AddToQueryParamsIfNotEmpty("includeSourceDictionaries", includeSourceDictionaries, queryParams);
            AddToQueryParamsIfNotEmpty("excludeSourceDictionaries", excludeSourceDictionaries, queryParams);
            AddToQueryParamsIfNotEmpty("includePartOfSpeech", includePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("excludePartOfSpeech", excludePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("minCorpusCount", minCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxCorpusCount", maxCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minLength", minLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxLength", maxLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("expandTerms", expandTerms, queryParams);
            AddToQueryParamsIfNotEmpty("includeTags", includeTags, queryParams);
            AddToQueryParamsIfNotEmpty("sortBy", sortBy, queryParams);
            AddToQueryParamsIfNotEmpty("sortOrder", sortOrder, queryParams);
            AddToQueryParamsIfNotEmpty("skip", skip, queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<DefinitionSearchResults>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<WordObject>> GetRandomWords(string includePartOfSpeech, String excludePartOfSpeech, String sortBy, String sortOrder, String hasDictionaryDef,
            int minCorpusCount, int maxCorpusCount, int minDictionaryCount, int maxDictionaryCount, int minLength, int maxLength, int limit)
        {
            string path = "/words.json/randomWords";

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("hasDictionaryDef", hasDictionaryDef, queryParams);
            AddToQueryParamsIfNotEmpty("includePartOfSpeech", includePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("excludePartOfSpeech", excludePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("minCorpusCount", minCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxCorpusCount", maxCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minDictionaryCount", minDictionaryCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxDictionaryCount", maxDictionaryCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minLength", minLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxLength", maxLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("sortBy", sortBy, queryParams);
            AddToQueryParamsIfNotEmpty("sortOrder", sortOrder, queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<List<WordObject>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<WordObject> GetRandomWord(string includePartOfSpeech, string excludePartOfSpeech, string hasDictionaryDef, int minCorpusCount, int maxCorpusCount,
            int minDictionaryCount, int maxDictionaryCount, int minLength, int maxLength)
        {
            string path = "/words.json/randomWord";
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("hasDictionaryDef", hasDictionaryDef, queryParams);
            AddToQueryParamsIfNotEmpty("includePartOfSpeech", includePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("excludePartOfSpeech", excludePartOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("minCorpusCount", minCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxCorpusCount", maxCorpusCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minDictionaryCount", minDictionaryCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxDictionaryCount", maxDictionaryCount.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("minLength", minLength.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("maxLength", maxLength.ToString(), queryParams);

            return await ProcessResult<WordObject>(path, HttpMethods.GET, queryParams);
        }
    }
}
