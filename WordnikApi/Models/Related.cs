using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class Related
    {
        public string Gram {get;set;}
        public string Label1 {get;set;}
        public string Label2 {get;set;}
        public string Label3 {get;set;}
        public string Label4 {get;set;}
        public string RelationshipType {get;set;}
        public List<string> Words { get; set; }

        public Related()
        {
            Words = new List<string>();
        }
    }
}
