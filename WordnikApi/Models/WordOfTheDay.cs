using System;
using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class WordOfTheDay
    {
        public long Id {get;set;}
        public string ParentId {get;set;}
        public string Category {get;set;}
        public string CreatedBy {get;set;}
        public DateTime CreatedAt {get;set;}
        public ContentProvider ContentProvider {get;set;}
        public string HtmlExtra {get;set;}
        public string Word {get;set;}
        public List<SimpleDefinition> Definitions { get; set; }
        public List<SimpleExample> Examples { get; set; }
        public string Note {get;set;}
        public DateTime PublishDateTime {get;set;}

        public WordOfTheDay()
        {
            Definitions = new List<SimpleDefinition>();
            Examples = new List<SimpleExample>();
        }
    }
}