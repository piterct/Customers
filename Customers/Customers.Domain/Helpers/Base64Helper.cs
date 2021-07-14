using System;

namespace Customers.Domain.Helpers
{
    public static class Base64Helper
    {
        public static string ByteToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
    }
}
