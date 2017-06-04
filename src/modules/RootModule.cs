using Nancy;
using System.Linq;

namespace net_core
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            Get("/", _ => View["index"]);
            Get("/fetch", _ => Fetch());
        } 

        private object Fetch()
        {
            return 200;
        }
    }
}
