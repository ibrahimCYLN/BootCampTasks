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
            UserSpace userSpace = new UserSpace();

            germanTime.GermanTimeAdd();
            logIn.Opening();
            //kullanıcı bilgileri
            /*string[] userSpace= { "ibrahim","ahmet","oguzhan" };
            string[] password = { "BCibrahim","BCahmet","BCoguzhan" };
            DateTime?[] logInTimes = { null, null,null };
            bool[] userWorking = { false, false, false };
            double[] mesaiSuresi= { 0, 0, 0 };*/

         do//sonsuz döngü
           {
            Console.Clear();
            Console.Write("Enter username:");
            string enteryUserName=Console.ReadLine();
            Console.Write("Enter password:");
            string enteryPassword = Console.ReadLine();
            
                bool passingName = false, passingPass = false;//doğru giriş değişkenleri

            int userQue = 0;//kullanıcının dizi deki sırası
            for (int i = 0; i <userSpace.userName.Length; i++) 
            {
                if (userSpace.userName[i] == enteryUserName)
                {
                    passingName = true;
                    if (userSpace.password[i] == enteryPassword) {passingPass = true; userQue = i; }
                    else { break; }
                }
            }
            /////////kullanıcı giriş kısmı
            if (passingName == true && passingPass == true) 
            { 
                Console.WriteLine("welcome");
                
                /////burada null false onlara bak
                if (userSpace.logInTimes[userQue] == null)
                {
                        /*userSpace.logInTimes[userQue] = germanTime.germanyTime;
                        Console.WriteLine("login saati" + userSpace.logInTimes[userQue]);*/
                        userSpace.userWorking[userQue] = true;
                        userSpace.logInTimes[userQue] = germanTime.germanyTime;
                        Console.WriteLine("Log in time:" + userSpace.logInTimes[userQue]);
                        Console.ReadLine();
                }
                else if (userSpace.userWorking[userQue] == true)
                {//Çalışıyor durumda molaya çıkıyor
                        userSpace.userWorking[userQue] = false;
                        germanTime.GermanTimeAdd();//saatimizi güncelledik
                        TimeSpan fark = germanTime.germanyTime.Subtract(userSpace.logInTimes[userQue].Value);
                        UserSpace.mesaiSuresi[userQue] += fark.TotalSeconds;
                        userSpace.logInTimes[userQue] = germanTime.germanyTime;//Log in time update
                        //////////////////////
                        Console.WriteLine("Total working time:"+UserSpace.mesaiSuresi[userQue]);
                        Console.WriteLine("Last working time:" + fark.TotalSeconds);
                        
                        //Console.WriteLine(userSpace.logInTimes[userQue].Value);
                        
                        if (fark.TotalSeconds > 40) { Console.WriteLine("Overtime working time:" + (UserSpace.mesaiSuresi[userQue]-40)); }
                        Console.WriteLine("Total working coast:" + ((UserSpace.mesaiSuresi[userQue] - 40) * 50).ToString("C2")+"Tl");
                    }
                else
                {//Moladan geliyor
                        userSpace.userWorking[userQue] = true;
                        germanTime.GermanTimeAdd();
                        TimeSpan fark1 = germanTime.germanyTime.Subtract(userSpace.logInTimes[userQue].Value);
                        UserSpace.molaSuresi[userQue] += fark1.TotalSeconds;
                        userSpace.logInTimes[userQue] = germanTime.germanyTime;//Log in time update

                        Console.WriteLine("Total break time:" + UserSpace.molaSuresi[userQue]);
                        Console.WriteLine("Last brek time:" + fark1.TotalSeconds);

                    }
                
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
