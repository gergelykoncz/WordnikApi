using System;
using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class Facet
    {
        private List<FacetValue> FacetValues { get; set; }
        private String Name { get; set; }

        public Facet()
        {
            FacetValues = new List<FacetValue>();
        }
    }
}
