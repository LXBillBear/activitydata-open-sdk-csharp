using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.city;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.city
{
    public class GetCitysRequest : BaseRequest<GetCitysResponse>
    {



        public override string GetApiMethod()
        {
            return "city/getCitys";
        }

        public override string GetAppParams()
        {
	        return "";
        }
    }
}