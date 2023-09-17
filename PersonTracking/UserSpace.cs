using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTracking
{
    internal class UserSpace
    {
        //kullanıcı bilgileri
        public string[] userName = { "ibrahim", "ahmet", "oguzhan" };
        public string[] password = { "BCibrahim", "BCahmet", "BCoguzhan" };
        public DateTime?[] logInTimes = { null, null, null };
        public bool[] userWorking = { false, false, false };
        public static double[] mesaiSuresi = { 0, 0, 0 };
        public static double[] molaSuresi = { 0, 0, 0 };

    }
}
