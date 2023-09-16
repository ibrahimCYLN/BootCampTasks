using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTracking
{
    internal class GermanTime
    {
        public void GermanTimeAdd() 
        {
            // Add local time
            DateTime localTime = DateTime.Now;
            // Almanya'nın saat dilimi
            TimeZoneInfo germanyZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            //Console.WriteLine("Almanya'nın saat dilimi: " + germanyZone);
            // Almanya'nın saati
            DateTime germanyTime = TimeZoneInfo.ConvertTime(localTime, germanyZone);
            Console.WriteLine("System Time:" + germanyTime.AddHours(-1));

        }
    }
}
