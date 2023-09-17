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
            //kullanıcı bilgileri
            string[] userSpace= { "ibrahim","ahmet","oguzhan" };
            string[] password = { "BCibrahim","BCahmet","BCoguzhan" };
            DateTime?[] logInTimes = { null, null,null };
            bool[] userWorking = { false, false, false };
            double[] mesaiSuresi= { 0, 0, 0 };

         do//sonsuz döngü
           {
                Console.Write("Enter username:");
            string enteryUserName=Console.ReadLine();
            Console.Write("Enter password:");
            string enteryPassword = Console.ReadLine();
            
                bool passingName = false, passingPass = false;//doğru giriş değişkenleri

            int userQue = 0;//kullanıcının dizi deki sırası
            for (int i = 0; i < userSpace.Length; i++) 
            {
                if (userSpace[i] == enteryUserName)
                {
                    passingName = true;
                    if (password[i] == enteryPassword) {passingPass = true; userQue = i; }
                    else { break; }
                }
            }
            /////////kullanıcı giriş kısmı
            if (passingName == true && passingPass == true) 
            { 
                Console.WriteLine("welcome");
                
                /////burada null false onlara bak
                if (logInTimes[userQue] == null)
                {
                        logInTimes[userQue] = germanTime.germanyTime;
                        Console.WriteLine("login saati" + logInTimes[userQue]);
                        userWorking[userQue] = true;
                    logInTimes[userQue] = germanTime.germanyTime;
                    Console.WriteLine("Log in time:" + logInTimes[userQue]);
                }
                else if (userWorking[userQue] == true)
                {//Çalışıyor durumda molaya çıkıyor
                    userWorking[userQue] = false;
                        germanTime.GermanTimeAdd();
                    TimeSpan fark = germanTime.germanyTime.Subtract(logInTimes[userQue].Value);
                        mesaiSuresi[userQue] = fark.TotalSeconds;
                        Console.WriteLine(logInTimes[userQue].Value);
                        Console.WriteLine(fark.TotalSeconds);
                        if (fark.TotalSeconds > 40) { Console.WriteLine("mesaiye kalıdığı süre:" + (mesaiSuresi[userQue]-40)); }
                     //mesaiUcreti[userQue] = germanTime.germanyTime.Hour();
                    //düzelt//mesaiUcreti[userQue] = DateTime.Now.AddHours(-logInTimes[userQue]);
                }
                else
                {//Moladan geliyor
                    userWorking[userQue] = true;
                }
                //TimeSpan timeSpan1 = TimeSpan.FromSeconds(1);
                //Console.WriteLine(timeSpan.ToString());
            }
            else { Console.WriteLine("Wrong user or password!"); }

            
                logIn.Opening();
          } while (true);
            

            /*Console.ReadLine();
            Console.Clear();
            Console.ReadLine();*/
        }
    }
}
