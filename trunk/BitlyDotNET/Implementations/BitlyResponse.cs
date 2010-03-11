using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BitlyDotNET.Interfaces;

namespace BitlyDotNET.Implementations
{
    public class BitlyResponse : IBitlyResponse
    {
        public StatusCode StatusCode { get; internal set; }
        public string LongUrl { get; internal set; }
        public string ShortUrl { get; internal set; }
    }
}
