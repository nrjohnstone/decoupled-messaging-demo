using Newtonsoft.Json.Linq;

namespace MessageDemo.ProcessC
{
    /// <summary>
    /// Represents the knowledge that ProcessC has about the Order messages
    /// that it receives
    /// </summary>
    internal class OrderAccessor
    {
        private readonly string _documentJson;
        private readonly JObject _documentJObject;

        private const string CustomerAddressField = "CustomerAddress";

        public OrderAccessor(string documentJson)
        {
            _documentJson = documentJson;
            _documentJObject = JObject.Parse(documentJson);
        }

        public string CustomerAddress
        {
            get { return (string)_documentJObject[CustomerAddressField]; }
            set { _documentJObject[CustomerAddressField] = value; }
        }

        public string ToJsonString()
        {
            return _documentJObject.ToString();
        }
    }
}