using Newtonsoft.Json.Linq;

namespace MessageDemo.ProcessB
{
    /// <summary>
    /// Represents the knowledge that ProcessB has about the Order messages
    /// that it receives
    /// </summary>
    internal class OrderAccessor
    {
        private readonly string _documentJson;
        private readonly JObject _documentJObject;

        private const string CustomerNameField = "CustomerName";

        public OrderAccessor(string documentJson)
        {
            _documentJson = documentJson;
            _documentJObject = JObject.Parse(documentJson);
        }

        public string CustomerName
        {
            get { return (string)_documentJObject[CustomerNameField]; }
            set { _documentJObject[CustomerNameField] = value; }
        }

        public string ToJsonString()
        {
            return _documentJObject.ToString();
        }
    }
}