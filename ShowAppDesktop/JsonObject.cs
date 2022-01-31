using System.Collections.Generic;

//transform into a singleton, so that every class has acces to this object
namespace ShowAppDesktop
{
    public class JsonObject
    {
        public List<ModelItem> Items { get; set; }

        public JsonObject() { Items = new List<ModelItem>(); }
    }
} 