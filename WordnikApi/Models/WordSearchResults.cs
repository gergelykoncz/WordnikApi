using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class WordSearchResults
    {
        public List<WordSearchResult> SearchResults {get;set;}
        public int TotalResults { get; set; }

        public WordSearchResults()
        {
            SearchResults = new List<WordSearchResult>();
        }
    }
}
