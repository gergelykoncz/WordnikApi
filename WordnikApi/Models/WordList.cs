using System;

namespace WordnikApi.Models
{
    public class WordList
    {
        public long Id {get; set;}
        public string Permalink {get; set;}
        public string Name {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpDateTimedAt {get; set;}
        public DateTime LastActivityAt {get; set;}
        public string Username {get; set;}
        public long UserId {get; set;}
        public string Description {get; set;}
        public long NumberWordsInList {get; set;}
        public string Type {get; set;}
    }
}
