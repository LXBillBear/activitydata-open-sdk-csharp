using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.billbear.activitydata.open.sdk.request;
using com.billbear.activitydata.open.sdk.response;
using com.billbear.activitydata.open.sdk.util;

namespace com.billbear.activitydata.open.sdk
{
    public class DefaultBillBearClient : BillBearClient
    {
        public const string CHARSET_UTF8 = "UTF-8";

        private String ServerUrl;
        private String Sign;
        private int ConnectTimeout = 0;
        private int ReadTimeout = 0;
        private Int64 AppId;

        public DefaultBillBearClient(String serverUrl, Int64 appId, String sign)
        {
            this.ServerUrl = serverUrl;
            this.Sign = sign;
            this.AppId = appId;
        }

        public DefaultBillBearClient(String serverUrl, Int64 appId, String sign,
                int connectTimeout, int readTimeout)
        {
            this.ServerUrl = serverUrl;
            this.Sign = sign;
            this.AppId = appId;
            this.ConnectTimeout = connectTimeout;
            this.ReadTimeout = readTimeout;
        }

        public T Execute<T>(BaseRequest<T> request) where T : BaseResponse
        {
            try
            {
                string url = buildUrl<T>(request);

                string jsonResult = HttpHelper.SendPost(url, "");

                T resp = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonResult);

                return resp;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private string buildUrl<T>(BaseRequest<T> request) where T : BaseResponse
        {
            Dictionary<string, string> sysParams = request.GetSysParams();

            sysParams.Add("sign", this.Sign);
            sysParams.Add("appId", this.AppId.ToString());
            string strAppParams = UTF8Encoding.UTF8.GetString(UTF8Encoding.UTF8.GetBytes(request.GetAppParams()));
            sysParams.Add("params", strAppParams);

            StringBuilder sb = new StringBuilder(this.ServerUrl);

            sb.Append(request.GetApiMethod());

            sb.Append("?");
            sb.Append(HttpHelper.BuildQuery(sysParams));
            return sb.ToString();
        }

    }
}
