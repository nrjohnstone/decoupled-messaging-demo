using System;

namespace MessageDemo
{
    internal class OrderDocument
    {
        public OrderDocument(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
        public int SupplierId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    }
}