using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.response.auth;

///billbear.sdk.tool
namespace com.billbear.activitydata.open.sdk.request.auth
{
    public class GetTokenRequest : BaseRequest<GetTokenResponse>
    {



        public override string GetApiMethod()
        {
            return "auth/getToken";
        }

        public override string GetAppParams()
        {
	        return "";
        }
    }
}