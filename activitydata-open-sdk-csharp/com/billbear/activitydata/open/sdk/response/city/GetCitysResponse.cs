using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.billbear.activitydata.open.sdk.bean.city;

namespace com.billbear.activitydata.open.sdk.response.city
{
    public class GetCitysResponse:BaseResponse
    {
        
        [JsonProperty("data")]
	    public List<CityRestDto> Data { get; set; }               
    

    }
}
