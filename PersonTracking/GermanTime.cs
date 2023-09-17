using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTracking
{
    internal class GermanTime
    {
        public DateTime germanyTime;//Global saat tanımladık
        public void GermanTimeAdd() 
        {
            germanyTime = DateTime.UtcNow;
            germanyTime = germanyTime.AddHours(2);//gmt+2
        Console.WriteLine("System Time:" + germanyTime);

        }
    }
}
