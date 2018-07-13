using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace com.billbear.activitydata.open.sdk.response
{
    public class BaseResponse
    {
        public string url { get; set; }

        [JsonProperty("respCode")]
        public string RespCode { get; set; }

        [JsonProperty("respInfo")]
        public string RespInfo { get; set; }
    }
}
