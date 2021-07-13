using System;

namespace Customers.Domain.Helpers
{
    public static class MemoryHelper
    {
        public static void SuspendProcessInMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
