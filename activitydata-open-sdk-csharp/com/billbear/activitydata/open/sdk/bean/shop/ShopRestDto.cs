using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.bean.shop
{
    public class ShopRestDto
    {
    
     
	
	    [JsonProperty("shopId")]
        public String ShopId { get; set; }               
    
     
	
	    [JsonProperty("miles")]
        public int Miles { get; set; }               
    
     
	
	    [JsonProperty("shopName")]
        public String ShopName { get; set; }               
    
     
	
	    [JsonProperty("address")]
        public String Address { get; set; }               
    
     
	
	    [JsonProperty("latitude")]
        public Double Latitude { get; set; }               
    
     
	
	    [JsonProperty("longitude")]
        public Double Longitude { get; set; }               
    
     
	
	    [JsonProperty("tel")]
        public String Tel { get; set; }               
    
    
    }
}