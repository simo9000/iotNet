
using iotNet.Database;
using Nancy;

namespace iotNet.Modules
{
    public class AdminModule : NancyModule
    {
        public AdminModule()
        {

            Get["/"] = parameters =>
            {
                dbConn db = new dbConn();
                db.Dispose();
                return View["index"];
            };

        }
    }
}