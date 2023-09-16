using System;
using System.Collections.Generic;
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
                Console.Write("Who want to log in? (Employee/Guest):");
                whoIs = Console.ReadLine().ToLower();
                if (whoIs=="exit")
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                //Console.WriteLine(whoIs);
            }
            while (whoIs != "employee" && whoIs != "guest");
            Console.Clear();
        }

    }
}
