using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk;
using com.billbear.activitydata.open.sdk.request.city;
using com.billbear.activitydata.open.sdk.response.city;
using com.billbear.activitydata.open.sdk.response.activity;
using com.billbear.activitydata.open.sdk.request.activity;
using com.billbear.activitydata.open.sdk.request.shop;
using com.billbear.activitydata.open.sdk.response.shop;

namespace open_api_test
{
    class ShopTest
    {

        public BillBearClient client;

        public ShopTest(BillBearClient billbearClient)
        {
            this.client = billbearClient;
        }


        public GetShopsByLocationResponse getShopsByLocation()
        {

            GetShopsByLocationRequest request = new GetShopsByLocationRequest();

            return client.Execute(request);
        }

        public GetShopsByActivityIdResponse getShopsByActivityId()
        {

            GetShopsByActivityIdRequest request = new GetShopsByActivityIdRequest();
            request.ActivityId = "22222222";

            return client.Execute(request);
        }

        
    }
}
