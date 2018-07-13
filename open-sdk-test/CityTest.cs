using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk;
using com.billbear.activitydata.open.sdk.request.city;
using com.billbear.activitydata.open.sdk.response.city;

namespace open_api_test
{
    class CityTest
    {

        public BillBearClient client;

        public CityTest(BillBearClient billbearClient)
        {
            this.client = billbearClient;
        }


        public GetCitysResponse getCitys(){

            GetCitysRequest request = new GetCitysRequest();

            return client.Execute(request);
        }

        
    }
}
