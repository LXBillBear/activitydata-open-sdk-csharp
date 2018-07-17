using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.shop;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.shop
{
    public class GetShopsByActivityIdLiteRequest : BaseRequest<GetShopsByActivityIdLiteResponse>
    {

 
        public Double Latitude { get; set; }            
    
 
        public Double Longitude { get; set; }            
    
 
        public String CityId { get; set; }            
    
 
        public String ActivityId { get; set; }            
    
 
        public int PageNo { get; set; }            
    
 
        public int PageSize { get; set; }            
    


        public override string GetApiMethod()
        {
            return "shopLite/getShopsByActivityIdLite";
        }

        public override string GetAppParams()
        {
		    Dictionary<String, Object> map = new Dictionary<String, Object>();
            map.Add("latitude", this.Latitude);
            map.Add("longitude", this.Longitude);
            map.Add("cityId", this.CityId);
            map.Add("activityId", this.ActivityId);
            map.Add("pageNo", this.PageNo);
            map.Add("pageSize", this.PageSize);
            return Newtonsoft.Json.JsonConvert.SerializeObject(map);
        }
    }
}