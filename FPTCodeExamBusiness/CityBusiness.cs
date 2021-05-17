using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using FPTCodeExamDomain;
using Newtonsoft.Json;

namespace FPTCodeExamBusiness
{
    public class CityBusiness
    {
        public string RetrieveCityName(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8"));
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            CityDetails cityDetails = JsonConvert.DeserializeObject<CityDetails>(result);
            return cityDetails.city;
        }
    }
}
