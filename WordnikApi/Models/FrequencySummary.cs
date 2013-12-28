using System.Collections.Generic;

namespace WordnikApi.Models
{
    public class FrequencySummary
    {
        public int UnknownYearCount { get; set; }
        public long TotalCount { get; set; }
        public string FrequencyString { get; set; }
        public string Word { get; set; }
        public List<Frequency> Frequency { get; set; }

        public FrequencySummary()
        {
            Frequency = new List<Frequency>();
        }
    }
}