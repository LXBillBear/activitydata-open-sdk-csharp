using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.activity;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.activity
{
    public class GetActivitysRequest : BaseRequest<GetActivitysResponse>
    {

 
        public String CityId { get; set; }            
    
 
        public Double Latitude { get; set; }            
    
 
        public Double Longitude { get; set; }            
    
 
        public Int64 Id { get; set; }            
    


        public override string GetApiMethod()
        {
            return "activity/getActivitys";
        }

        public override string GetAppParams()
        {
		    Dictionary<String, Object> map = new Dictionary<String, Object>();
            map.Add("cityId", this.CityId);
            map.Add("latitude", this.Latitude);
            map.Add("longitude", this.Longitude);
            map.Add("id", this.Id);
            return Newtonsoft.Json.JsonConvert.SerializeObject(map);
        }
    }
}