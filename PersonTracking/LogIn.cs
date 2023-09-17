using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonTracking
{
    internal class LogIn
    {
        public bool tryLogIn = false;
        public string whoIs;
        UserSpace userSpace = new UserSpace();
        public void Opening()
        {
            
            do
            {
                
                if (tryLogIn==false)
                { 
                Console.WriteLine("Welcome to Person Tracking System");
                tryLogIn = true;
                }
                else
                {
                    Console.WriteLine("Unavailable entering, please try again or writing exit");
                }
                //Console.WriteLine("Welcome to Person Tracking System");
                Console.Write("Who want to log in? (Employee/Other):");
                whoIs = Console.ReadLine().ToLower();
                if (whoIs=="exit")
                {
                    Environment.Exit(0);
                }

                if (whoIs == "other")
                {
                    Console.Clear();
                    Console.Write("Kullanıcı gir:");
                    string tempName = Console.ReadLine().ToLower();
                    Console.WriteLine(tempName);
                    //Console.ReadLine();
                    for (int i = 0; i < userSpace.userName.Length; i++)
                    {
                        if (userSpace.userName[i] == tempName)
                        {
                            Console.WriteLine("mesai süresi:" + UserSpace.mesaiSuresi[i]);
                           // string tl = ((UserSpace.mesaiSuresi[i] - 40) * 50).ToString("C", new CultureInfo("tr-TR"));
                            /*double mesaiUcreti= ((UserSpace.mesaiSuresi[i] - 40) * 50);
                            string tl1 = mesaiUcreti.ToString("C", new CultureInfo("tr-TR"));*/
                            if (UserSpace.mesaiSuresi[i] > 40) { Console.WriteLine("mesai ücreti" + ((UserSpace.mesaiSuresi[i] - 40) * 50).ToString("C2")); }
                            else { Console.WriteLine("Mesai yapılmamıştır"); break; }
                        }
                    }

                }
                //Console.WriteLine(whoIs);
                else { Console.Clear(); }
            }
            while (whoIs != "employee" );
            //Console.Clear();
        }

    }
}
