using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class Note
    {
        public string NoteType { get; set; }
        private List<string> AppliesTo { get; set; }
        private string Value { get; set; }
        private int Pos { get; set; }

        public Note()
        {
            AppliesTo = new List<string>();
        }
    }
}
