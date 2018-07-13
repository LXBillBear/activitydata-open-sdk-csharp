using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.billbear.activitydata.open.sdk.bean.shop;

namespace com.billbear.activitydata.open.sdk.response.shop
{
    public class GetShopsByLocationResponse:BaseResponse
    {
        
        [JsonProperty("data")]
	    public List<ShopActivityRestDto> Data { get; set; }               
    

    }
}
