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
        /// The wait time in Milliseconds.
        /// </value>
        public int WaitTime { get; set; } = 500;
        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        /// <value>
        /// The timeout in Milliseconds.
        /// </value>
        public int Timeout { get; set; } = 1000;
    }
}
