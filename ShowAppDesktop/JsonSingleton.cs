using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAppDesktop
{
    class JsonSingleton
    {
        public static JsonObject Instance { get; } = new JsonObject();
    }
}