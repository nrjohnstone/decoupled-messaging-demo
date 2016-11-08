using System;

namespace MessageDemo.ProcessB
{
    /// <summary>
    /// Enrich the order message with the CustomerName information
    /// </summary>
    internal class ProcessBHandler
    {
        public string Handle(string orderMessage)
        {
            OrderAccessor accessor = new OrderAccessor(orderMessage);
            accessor.CustomerName = "Joe Bloggs";

            Console.WriteLine($"ProcessB has updated CustomerName on Order to {accessor.CustomerName}");
            return accessor.ToJsonString();
        }
    }
}