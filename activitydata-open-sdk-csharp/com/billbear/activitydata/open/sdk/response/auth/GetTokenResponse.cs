using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.billbear.activitydata.open.sdk.bean.auth;

namespace com.billbear.activitydata.open.sdk.response.auth
{
    public class GetTokenResponse:BaseResponse
    {
        
        [JsonProperty("data")]
	    public AuthRestDto Data { get; set; }               
    

    }
}
