using System.Collections.Generic;

namespace ShowAppDesktop
{
    public class JsonObject
    {
        public List<ModelItem> Items { get; set; }

        public JsonObject() { Items = new List<ModelItem>(); }
    }
}