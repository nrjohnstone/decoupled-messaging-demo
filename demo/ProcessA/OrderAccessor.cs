using Newtonsoft.Json.Linq;

namespace MessageDemo.ProcessA
{
    /// <summary>
    /// Represents the knowledge that ProcessA has about the Order messages
    /// that it receives
    /// </summary>
    internal class OrderAccessor
    {
        private readonly string _documentJson;
        private readonly JObject _documentJObject;

        private const string SupplierIdName = "SupplierId";

        public OrderAccessor(string documentJson)
        {
            _documentJson = documentJson;
            _documentJObject = JObject.Parse(documentJson);
        }

        public int SupplierId
        {
            get { return (int)_documentJObject[SupplierIdName]; }
            set { _documentJObject[SupplierIdName] = value; }
        }

        public string ToJsonString()
        {
            return _documentJObject.ToString();
        }
    }
}