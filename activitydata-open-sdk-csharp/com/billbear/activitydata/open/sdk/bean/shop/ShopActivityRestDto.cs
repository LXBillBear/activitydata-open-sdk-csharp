using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.billbear.activitydata.open.sdk.bean.shop;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.bean.shop
{
    public class ShopActivityRestDto
    {
    
     
	
	    [JsonProperty("shopId")]
        public String ShopId { get; set; }               
    
     
	
	    [JsonProperty("miles")]
        public int Miles { get; set; }               
    
     
	
	    [JsonProperty("acts")]
        public List<ActivityLiteRestDto> Acts { get; set; }               
    
     
	
	    [JsonProperty("shopName")]
        public String ShopName { get; set; }               
    
     
	
	    [JsonProperty("logoSmall")]
        public String LogoSmall { get; set; }               
    
    
    }
}