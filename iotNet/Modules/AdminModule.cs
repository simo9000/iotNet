using ACN.Database;
using ACN.Objects;
using Nancy;
using Nancy.Json;
using Nancy.ModelBinding;
using Nancy.Responses.Negotiation;

namespace ACN.Modules
{
    public class AdminModule : NancyModule
    {
        private string responseType = null;
        private dbConn db;
        private area selectedArea;
        public AdminModule()
        {
            Get["/"] = parameters => getAreaListView();

            Get["/RtView/for/{area}"] = parameters => getRtView(parameters.area);

            Get["/Rt_values/for/{area}"] = parameters => getRtValues(parameters.area);

            After += (ctx) =>
            {
                if (responseType != null)
                    ctx.Response.ContentType = responseType;
            };
        }

        public Negotiator getAreaListView(){
            db = new dbConn();
            string[] areas = this.BindTo(db.getAreaList());
            db.Dispose();
            db = null;
            Negotiator areaListView = View["areaListView",areas];
            areas = null;
            return areaListView;
        }

        public Negotiator getRtView(string areaName){
            selectedArea = this.BindTo(new area(areaName));
            Negotiator RtView = View["RtView", selectedArea];
            selectedArea = null;
            return RtView;
        }

        public string getRtValues(string areaName){
            selectedArea = new area(areaName);
            responseType = "application/json";
            string returnVal = new JavaScriptSerializer().Serialize(selectedArea.Sensors);
            selectedArea = null;
            return returnVal;
        }
    }
}