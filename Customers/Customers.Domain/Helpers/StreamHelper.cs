using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace Customers.Domain.Helpers
{
    public static class StreamHelper
    {
        public static StreamContent Base64ToStream(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            return new StreamContent(new MemoryStream(bytes));
        }

        public static Stream ByteToStream(byte[] contentByte)
        {
            return new MemoryStream(contentByte);
        }
    }
}
