using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.activity;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.activity
{
    public class GetActivityRequest : BaseRequest<GetActivityResponse>
    {

 
        public String Id { get; set; }            
    


        public override string GetApiMethod()
        {
            return "activity/getActivity";
        }

        public override string GetAppParams()
        {
		    Dictionary<String, Object> map = new Dictionary<String, Object>();
            map.Add("id", this.Id);
            return Newtonsoft.Json.JsonConvert.SerializeObject(map);
        }
    }
}