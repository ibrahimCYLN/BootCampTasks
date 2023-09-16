using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogIn logIn = new LogIn(); //sınıfımızı ekledik.
            GermanTime germanTime = new GermanTime();

            germanTime.GermanTimeAdd();
            logIn.Opening();
            string[] userSpace= { "ibrahim","ahmet","oguzhan" };
            string[] password = { "BCibrahim","BCahmet","BCoguzhan" };
            DateTime?[] logInTimes = { null, null,null };

            Console.Write("Enter username:");
            string enteryUserName=Console.ReadLine();
            Console.Write("Enter password:");
            string enteryPassword = Console.ReadLine();
            bool passingName = false, passingPass = false;


            for (int i = 0; i < userSpace.Length; i++) 
            {
                if (userSpace[i] == enteryUserName)
                {
                    passingName = true;
                    if (password[i] == enteryPassword) { passingPass = true; logInTimes[i] = DateTime.Now; }
                    else { break; }

                }
            }
            if (passingName == true && passingPass == true) { Console.WriteLine("welcome"); }
            else { Console.WriteLine("Wrong user or password!"); }




            Console.ReadLine();
            Console.Clear();
            Console.ReadLine();
        }
    }
}
