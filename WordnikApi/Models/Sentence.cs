using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class Sentence
    {
        public bool HasScoredWords { get; set; }
        public long Id { get; set; }
        public List<ScoredWord> ScoredWords { get; set; }
        public string Display { get; set; }
        public int Rating { get; set; }
        public long DocumentMetadataId { get; set; }

        public Sentence()
        {
            ScoredWords = new List<ScoredWord>();
        }
    }
}