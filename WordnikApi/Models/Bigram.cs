namespace WordnikApi.Models
{
    public class Bigram
    {
        public long Count { get; set; }
        public string Gram1 { get; set; }
        public string Gram2 { get; set; }
        public double Mi { get; set; }
        public double Wlmi { get; set; }
    }
}
