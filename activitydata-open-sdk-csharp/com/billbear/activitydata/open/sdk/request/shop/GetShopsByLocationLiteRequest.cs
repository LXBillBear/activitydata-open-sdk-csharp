using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.shop;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.shop
{
    public class GetShopsByLocationLiteRequest : BaseRequest<GetShopsByLocationLiteResponse>
    {

 
        public Double Latitude { get; set; }            
    
 
        public Double Longitude { get; set; }            
    
 
        public Int64 Id { get; set; }            
    


        public override string GetApiMethod()
        {
            return "shopLite/getShopsByLocationLite";
        }

        public override string GetAppParams()
        {
		    Dictionary<String, Object> map = new Dictionary<String, Object>();
            map.Add("latitude", this.Latitude);
            map.Add("longitude", this.Longitude);
            map.Add("id", this.Id);
            return Newtonsoft.Json.JsonConvert.SerializeObject(map);
        }
    }
}