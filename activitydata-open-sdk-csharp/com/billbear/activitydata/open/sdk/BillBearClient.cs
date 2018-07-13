using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.request;
using com.billbear.activitydata.open.sdk.response;

namespace com.billbear.activitydata.open.sdk
{
    public interface BillBearClient
    {
        T Execute<T>(BaseRequest<T> request) where T : BaseResponse;
    }
}
