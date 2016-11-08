using System;
using FluentAssertions;
using MessageDemo.ProcessA;
using MessageDemo.ProcessB;
using MessageDemo.ProcessC;
using Newtonsoft.Json;

namespace MessageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create process handlers representing different message endpoints   
            ProcessAHandler processAHandler = new ProcessAHandler();
            ProcessBHandler processBHandler = new ProcessBHandler();
            ProcessCHandler processCHandler = new ProcessCHandler();

            OrderDocument order = new OrderDocument(Guid.NewGuid());
            var serializedOrder = JsonConvert.SerializeObject(order);

            // Simulate sending the order and receiving the response through
            // the different endpoints
            string responseFromA = processAHandler.Handle(serializedOrder);
            string responseFromB = processBHandler.Handle(responseFromA);
            string responseFromC = processCHandler.Handle(responseFromB);

            // Validate the final response has all the expected updates from each process
            OrderDocument updatedDocument = 
                JsonConvert.DeserializeObject<OrderDocument>(responseFromC);

            updatedDocument.SupplierId.Should().Be(10);
            updatedDocument.CustomerName.Should().Be("Joe Bloggs");
            updatedDocument.CustomerAddress.Should().Be("115 Somewhere Street");

            Console.ReadLine();
        }
    }
}
