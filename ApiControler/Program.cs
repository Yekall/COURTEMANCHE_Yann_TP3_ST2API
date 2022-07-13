using System;

namespace ApiControler
{

    class Program
    {
        static void Main(string[] args)
        {

            var p = new APIcontrol();
            p.GetInfo2("eee");
            p.GetInfo2("Toulouse");
        }


        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();

            return dateTime;
        }
    }
}
