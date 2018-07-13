using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.billbear.activitydata.open.sdk.bean.activity;

namespace com.billbear.activitydata.open.sdk.response.activity
{
    public class GetActivityResponse:BaseResponse
    {
        
        [JsonProperty("data")]
	    public ActivityDetailRestDto Data { get; set; }               
    

    }
}
