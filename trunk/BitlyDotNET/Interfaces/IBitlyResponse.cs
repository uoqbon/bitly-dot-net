using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BitlyDotNET.Interfaces;

namespace BitlyDotNET.Interfaces
{
    public interface IBitlyResponse
    {
        /// <summary>
        /// The <see cref="StatusCode">status code</see> for this request
        /// </summary>
        StatusCode StatusCode { get; }
        /// <summary>
        /// The long URL
        /// </summary>
        string LongUrl { get; }
        /// <summary>
        /// The shortened URL corresponding to <paramref name="LongUrl"/> or null if unsuccessful
        /// </summary>
        string ShortUrl { get; }
    }
}
