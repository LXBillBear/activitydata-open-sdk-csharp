using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.shop;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.shop
{
    public class GetShopsByLocationRequest : BaseRequest<GetShopsByLocationResponse>
    {

 
        public Double Latitude { get; set; }            
    
 
        public Double Longitude { get; set; }            
    
 
        public String BankName { get; set; }            
    
 
        public String Category { get; set; }            
    
 
        public DateTime Date { get; set; }            
    


        public override string GetApiMethod()
        {
            return "shop/getShopsByLocation";
        }

        public override string GetAppParams()
        {
		    Dictionary<String, Object> map = new Dictionary<String, Object>();
            map.Add("latitude", this.Latitude);
            map.Add("longitude", this.Longitude);
            map.Add("bankName", this.BankName);
            map.Add("category", this.Category);
            map.Add("date", this.Date);
            return Newtonsoft.Json.JsonConvert.SerializeObject(map);
        }
    }
}