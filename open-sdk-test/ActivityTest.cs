using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk;
using com.billbear.activitydata.open.sdk.request.city;
using com.billbear.activitydata.open.sdk.response.city;
using com.billbear.activitydata.open.sdk.response.activity;
using com.billbear.activitydata.open.sdk.request.activity;

namespace open_api_test
{
    class ActivityTest
    {

        public BillBearClient client;

        public ActivityTest(BillBearClient billbearClient)
        {
            this.client = billbearClient;
        }


        public GetActivitysResponse getActivitys()
        {

            GetActivitysRequest request = new GetActivitysRequest();

            return client.Execute(request);
        }

        public GetActivityResponse getActivity()
        {

            GetActivityRequest request = new GetActivityRequest();

            return client.Execute(request);
        }

        
    }
}
