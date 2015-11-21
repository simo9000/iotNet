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
                db = null;
                var areaListView = View["areaListView",areas];
                areas = null;
                return areaListView;
            };

            Get["/RT_values/for/{area}"] = parameters =>
            {
                area area = this.BindTo(new area(parameters.area));
                var RtView = View["RtView", area];
                area = null;
                return RtView;
            };
        }
    }
}