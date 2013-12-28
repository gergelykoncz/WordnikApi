namespace WordnikApi.Models
{
    public class ScoredWord
    {
        public int Position {get;set;}
        public long Id {get;set;}
        public int DocTermCount {get;set;}
        public string Lemma {get;set;}
        public string WordType {get;set;}
        public float Score {get;set;}
        public long SentenceId {get;set;}
        public string Word {get;set;}
        public bool Stopword {get;set;}
        public double BaseWordScore {get;set;}
        public string PartOfSpeech {get;set;}
    }
}
