using System;
using System.Collections.Generic;
using System.Text;

namespace SMSNetCoreApp
{
    public class Constants
    {
       /// <summary>
       /// For Details Info Pls Visit: https://onnorokomsms.com
       /// For API Key Visit: https://panel.onnorokomsms.com
       /// </summary>

        //Base URL
        public static string BASE_URL = "https://api2.onnorokomsms.com/HttpSendSms.ashx";
        //API Key
        public static string API_KEY = "";
        //Uername
        public static string USERNAME = "";
        //Password
        public static string PASSWORD = "";


        //SMS Text
        public static string SMS_TEXT = "";
        //Receiver Mobile Number Single (Comma Seperated: Like- 01700000000)
        public static string MOBILE_NO_SINGLE = "";
        //Receiver Mobile Number Multiple Number (Comma Seperated: Like- 01700000000,01700000001)
        public static string MOBILE_NO_MULTIPLE = "";
        //List SMS JSON
        public static string SMS_LIST = "[{\"MobileNumber\":\"" + MOBILE_NO_SINGLE + "\",\"SmsText\":\"SMS TEXT\",\"Type\":\"TEXT\"}"
                                            + ",{\"MobileNumber\":\"01722222222\",\"SmsText\":\"SMS TEXT\",\"Type\":\"TEXT\"}"
                                            + ",{\"MobileNumber\":\"01733333333\",\"SmsText\":\"SMS TEXT\",\"Type\":\"TEXT\"}]";

        public static string RESPONSE = "";

       
    }
}
