using System;

namespace MessageDemo.ProcessC
{
    /// <summary>
    /// Enrich the order message with the CustomerAddress information
    /// </summary>
    internal class ProcessCHandler
    {
        public string Handle(string orderMessage)
        {
            OrderAccessor accessor = new OrderAccessor(orderMessage);
            accessor.CustomerAddress = "115 Somewhere Street";

            Console.WriteLine($"ProcessC has updated CustomerAddress on Order to {accessor.CustomerAddress}");
            return accessor.ToJsonString();
        }
    }
}