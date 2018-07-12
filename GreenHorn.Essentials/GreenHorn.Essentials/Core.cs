using GreenHorn.Essentials.Models;
using System;
using System.Threading;

namespace GreenHorn.Essentials
{
    public class Core
    {

        /// <summary>
        /// Retries the specified action based on provided RetryInfo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action.</param>
        /// <param name="info">The information.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">info</exception>
        public T Retry<T>(Func<T> action, RetryInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));
            
            Exception currentException = null;
            int currentAttempt = 0;
            
            do{
                try
                {
                    return action();
                }
                catch (Exception exception)
                {
                    currentAttempt++;
                    currentException = exception;
                }
                Thread.Sleep(TimeSpan.FromSeconds(info.WaitTime));
            }while(currentAttempt < info.Attempts);
            throw currentException;
        }
    }

}
