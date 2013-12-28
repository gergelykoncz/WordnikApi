using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class DefinitionSearchResults
    {
        public List<Definition> Results { get; set; }
        public int TotalResults { get; set; }
        
        public DefinitionSearchResults()
        {
            Results = new List<Definition>();
        }
    }
}