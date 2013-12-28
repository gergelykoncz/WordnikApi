using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class Definition
    {
        public string ExtendedText { get; set; }
        public string Text { get; set; }
        public string SourceDictionary { get; set; }
        public List<Citation> Citations { get; set; }
        public List<Label> Labels { get; set; }
        public float Score { get; set; }
        public List<ExampleUsage> ExampleUses { get; set; }
        public string AttributionUrl { get; set; }
        public string SeqString { get; set; }
        public string AttributionText { get; set; }
        public List<Related> RelatedWords { get; set; }
        public string Sequence { get; set; }
        public string Word { get; set; }
        public List<Note> Notes { get; set; }
        public List<TextPron> TextProns { get; set; }
        public string PartOfSpeech { get; set; }

        public Definition()
        {
            Citations = new List<Citation>();
            Labels = new List<Label>();
            ExampleUses = new List<ExampleUsage>();
            RelatedWords = new List<Related>();
            Notes = new List<Note>();
            TextProns = new List<TextPron>();
        }
    }
}
