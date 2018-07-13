using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.bean.city
{
    public class CityRestDto
    {
    
     
	
	    [JsonProperty("cityId")]
        public String CityId { get; set; }               
    
     
	
	    [JsonProperty("cityName")]
        public String CityName { get; set; }               
    
    
    }
}