using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.bean.activity
{
    public class ActivityDetailRestDto
    {
    
     
	
	    [JsonProperty("id")]
        public String Id { get; set; }               
    
     
	
	    [JsonProperty("title")]
        public String Title { get; set; }               
    
     
	
	    [JsonProperty("bigImgUrl")]
        public String BigImgUrl { get; set; }               
    
     
	
	    [JsonProperty("bankName")]
        public String BankName { get; set; }               
    
     
	
	    [JsonProperty("availableTime")]
        public String AvailableTime { get; set; }               
    
     
	
	    [JsonProperty("availableCity")]
        public String AvailableCity { get; set; }               
    
     
	
	    [JsonProperty("content")]
        public String Content { get; set; }               
    
     
	
	    [JsonProperty("category")]
        public String Category { get; set; }               
    
     
	
	    [JsonProperty("subjectDescription")]
        public String SubjectDescription { get; set; }               
    
     
	
	    [JsonProperty("way")]
        public String Way { get; set; }               
    
     
	
	    [JsonProperty("note")]
        public String Note { get; set; }               
    
     
	
	    [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }               
    
    
    }
}