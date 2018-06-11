namespace GreenHorn.Essentials.Models
{
    public class RetryInfo
    {
        public int Attempts { get; set; } = 0;
        public int WaitTime { get; set; } = 50;
        public int Timeout { get; set; } = 30;
    }
}
