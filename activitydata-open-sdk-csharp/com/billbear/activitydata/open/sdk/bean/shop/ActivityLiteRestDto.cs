using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.bean.shop
{
    public class ActivityLiteRestDto
    {
    
     
	
	    [JsonProperty("id")]
        public String Id { get; set; }               
    
     
	
	    [JsonProperty("title")]
        public String Title { get; set; }               
    
     
	
	    [JsonProperty("bankName")]
        public String BankName { get; set; }               
    
     
	
	    [JsonProperty("category")]
        public String Category { get; set; }               
    
     
	
	    [JsonProperty("availableTime")]
        public String AvailableTime { get; set; }               
    
    
    }
}