using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordnikApi.Common;
using WordnikApi.Models;

namespace WordnikApi.Api
{
    public class WordApi : ApiBase
    {
        public async Task<ExampleSearchResults> GetExamples(string word, string includeDuplicates, string useCanonical, int skip, int limit)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }

            string path = string.Format("/word.json/{0}/examples", word);

            var queryParams = new Dictionary<String, String>();

            AddToQueryParamsIfNotEmpty("includeDuplicates", includeDuplicates, queryParams);
            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("skip", skip.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<ExampleSearchResults>(path, HttpMethods.GET, queryParams);
        }

        public async Task<WordObject> GetWord(string word, string useCanonical, string includeSuggestions)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}", word);

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("includeSuggestions", includeSuggestions, queryParams);

            return await ProcessResult<WordObject>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<Definition>> GetDefinitions(string word, string partOfSpeech, string sourceDictionaries, int limit, string includeRelated, string useCanonical, string includeTags)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/definitions", word);

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("partOfSpeech", partOfSpeech, queryParams);
            AddToQueryParamsIfNotEmpty("sourceDictionaries", sourceDictionaries, queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("includeRelated", includeRelated, queryParams);
            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("includeTags", includeTags, queryParams);

            return await ProcessResult<List<Definition>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<Example> GetTopExample(string word, string useCanonical)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }

            string path = string.Format("/word.json/{0}/topExample", word);
            var queryParams = new Dictionary<string, string>();
            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);

            return await ProcessResult<Example>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<Related>> GetRelatedWords(string word, string relationshipTypes, string useCanonical, int limitPerRelationshipType)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/relatedWords", word);

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("relationshipTypes", relationshipTypes, queryParams);
            AddToQueryParamsIfNotEmpty("limitPerRelationshipType", limitPerRelationshipType.ToString(), queryParams);

            return await ProcessResult<List<Related>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<TextPron>> GetTextPronunciations(string word, string sourceDictionary, string typeFormat, string useCanonical, int limit)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/pronunciations", word);

            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("sourceDictionary", sourceDictionary, queryParams);
            AddToQueryParamsIfNotEmpty("typeFormat", typeFormat, queryParams);
            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<List<TextPron>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<Syllable>> GetHyphenation(string word, string sourceDictionary, string useCanonical, int limit)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/hyphenation", word);
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("sourceDictionary", sourceDictionary, queryParams);
            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<List<Syllable>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<FrequencySummary> GetWordFrequency(string word, string useCanonical, int startYear, int endYear)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/frequency", word);
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("startYear", startYear.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("endYear", endYear.ToString(), queryParams);

            return await ProcessResult<FrequencySummary>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<Bigram>> GetPhrases(string word, int limit, int wlmi, string useCanonical)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/phrases", word);
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("wlmi", wlmi.ToString(), queryParams);
            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);

            return await ProcessResult<List<Bigram>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<string>> GetEtymologies(string word, string useCanonical)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/etymologies", word);
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);

            return await ProcessResult<List<string>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<List<AudioFile>> GetAudio(string word, string useCanonical, int limit)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/audio", word);
            var queryParams = new Dictionary<string, string>();

            AddToQueryParamsIfNotEmpty("useCanonical", useCanonical, queryParams);
            AddToQueryParamsIfNotEmpty("limit", limit.ToString(), queryParams);

            return await ProcessResult<List<AudioFile>>(path, HttpMethods.GET, queryParams);
        }

        public async Task<ScrabbleScoreResult> GetScrabbleScore(String word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException("word");
            }
            string path = string.Format("/word.json/{0}/scrabbleScore", word);

            return await ProcessResult<ScrabbleScoreResult>(path, HttpMethods.GET, null, null);
        }
    }
}
