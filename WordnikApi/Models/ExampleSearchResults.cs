using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class ExampleSearchResults
    {
        public List<Facet> Facets { get; set; }
        public List<Example> Examples { get; set; }

        public ExampleSearchResults()
        {
            Facets = new List<Facet>();
            Examples = new List<Example>();
        }
    }
}