using System;

namespace WordnikApi.Models
{
    public class Example
    {
        public long Id {get;set;}
        public long ExampleId {get;set;}
        public String Title {get;set;}
        public String Text {get;set;}
        public ScoredWord Score {get;set;}
        public Sentence Sentence {get;set;}
        public String Word {get;set;}
        public ContentProvider Provider {get;set;}
        public int Year {get;set;}
        public float Rating {get;set;}
        public long DocumentId {get;set;}
        public String Url {get;set;}
    }
}