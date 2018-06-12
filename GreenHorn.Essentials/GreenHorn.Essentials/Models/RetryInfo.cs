namespace GreenHorn.Essentials.Models
{
    /// <summary>
    /// Retry Info
    /// </summary>
    public class RetryInfo
    {
        /// <summary>
        /// Gets or sets the attempts.
        /// </summary>
        /// <value>
        /// The attempts.
        /// </value>
        public int Attempts { get; set; } = 0;
        /// <summary>
        /// Gets or sets the wait time.
        /// </summary>
        /// <value>
        /// The wait time.
        /// </value>
        public int WaitTime { get; set; } = 50;
        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        /// <value>
        /// The timeout.
        /// </value>
        public int Timeout { get; set; } = 30;
    }
}
