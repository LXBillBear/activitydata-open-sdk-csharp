using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk;
using com.billbear.activitydata.open.sdk.request;
using com.billbear.activitydata.open.sdk.response;
using com.billbear.activitydata.open.sdk.bean;

namespace open_api_test
{
    class Program
    {
        static void Main(string[] args)
        {
           

            String url = "https://open.billbear.cn/activitydata-open-sandbox/";

            long appId = 18081818188888;//请替换

            String sign = "billbearsandbox";//请替换

            BillBearClient client = new DefaultBillBearClient(url, appId, sign);

            CityTest cityTest = new CityTest(client);

            Console.WriteLine(cityTest.getCitys().Data[0].CityName);

            ActivityTest activityTest = new ActivityTest(client);

            Console.WriteLine(activityTest.getActivitys().Data[0].BankName);

            Console.WriteLine(activityTest.getActivity().Data.EndDate);

            ShopTest shopTest = new ShopTest(client);

            Console.WriteLine(shopTest.getShopsByLocation().Data[0].ShopName);

            Console.WriteLine(shopTest.getShopsByActivityId().Data[0].Address);

            Console.ReadLine();

            //var result = WorkOrderTest.BatchGet(client);

            //var singleResult = WorkOrderTest.SingleGet(client);

            //var confirmResult = WorkOrderTest.Confirm(client);

            //var cancelResult = WorkOrderTest.Cancel(client);

            //var addResult = WorkOrderTest.Add(client);

            //var orderBatchResult = DegTest.BatchGet(client);
           
            //var orderBatchResult = DegTest.BatchGet(client);

        }
    }
}
