using ACN.Database;
using ACN.Objects;
using Nancy;
using Nancy.ModelBinding;

namespace ACN.Modules
{
    public class AdminModule : NancyModule
    {
        public AdminModule()
        {

            Get["/"] = parameters =>
            {
                dbConn db = new dbConn();
                string[] areas = this.BindTo(db.getAreaList());
                db.Dispose();
                return View["areaListView",areas];
            };

            Get["/RT_values/for/{area}"] = parameters =>
            {

            };
        }
    }
}