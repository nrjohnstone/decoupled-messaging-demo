using System;

namespace MessageDemo.ProcessA
{
    /// <summary>
    /// Enrich the order message with the SupplierId information
    /// </summary>
    internal class ProcessAHandler
    {
        public string Handle(string orderMessage)
        {
            OrderAccessor accessor = new OrderAccessor(orderMessage);
            accessor.SupplierId = 10;

            Console.WriteLine($"ProcessA has updated SupplierId on Order to {accessor.SupplierId}");

            return accessor.ToJsonString();
        }
    }
}