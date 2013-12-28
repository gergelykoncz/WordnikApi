using System;

namespace WordnikApi.Models
{
    public class WordListWord
    {
        public long Id {get; set;}
        public string Word {get; set;}
        public string Username {get; set;}
        public long UserId {get; set;}
        public DateTime CreatedAt {get; set;}
        public long NumberCommentsOnWord {get; set;}
        public long NumberLists {get; set;}
    }
}
