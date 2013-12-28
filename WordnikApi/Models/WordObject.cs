using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class WordObject
    {
        public long Id {get;set;}
        public string Word {get;set;}
        public string OriginalWord {get;set;}
        public List<string> Suggestions { get; set; }
        public string CanonicalForm {get;set;}
        public string Vulgar {get;set;}

        public WordObject()
        {
            Suggestions = new List<string>();
        }
    }
}