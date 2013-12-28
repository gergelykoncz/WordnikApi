using System;

namespace WordnikApi.Models
{
    public class AudioFile
    {
        public string AttributionText { get; set; }
        public string AttributionUrl { get; set; }
        public string AudioType { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public long Id { get; set; }
        public string FileUrl { get; set; }
        public float VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public float VoteWeightedAverage { get; set; }
        public string Word { get; set; }
    }
}
