using System;
using System.Net;
using System.Threading;

namespace IPLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            mucicka();


        }

        static void mucicka()
        {
            Console.WriteLine("Click R in this window to load ip logs"); // Writes line in console
            /*
             * Function below this text is used to await for user to click 'R', so when they do it gives logs
             */
            var work = ConsoleKey.R;
            while (Console.ReadKey().Key == work)
            {

                loader();
            }
            Console.Clear();
            Console.WriteLine("Wrong key detected, try again?");
            mucicka(); // Comes back from where it started



        }
        static void loader()
        {
            WebClient network = new WebClient(); // This is WebClient, it's used for networking in application

            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(250);
            Console.Clear();





            byte[] data = network.DownloadData("https://scalled-implementat.000webhostapp.com/iplogdata.txt");
            string output = System.Text.Encoding.UTF8.GetString(data); // Makes it string
            /*
             * NOTICE:
             * 1.
             * In DownloadData input your site's domain and put /iplogdata.txt on the end
             * 2.
             * You must create iplogdata.txt in your site's FILE MANAGER.
             * Or you can IP Log someone and it will create by it's self by PHP Code
             * But if you are testing application and no one was on IPLogger yet, 
             * The application will just crash.
             */








            Console.WriteLine(output); //Writes data which is in data.txt (data.txt is text where are logs)
            Console.WriteLine("");
            Console.WriteLine("Reload Complete!");
            Console.WriteLine("Click R in this window to reload ip logs");
            var work = ConsoleKey.R;
            while (Console.ReadKey().Key == work)
            {

                loader();
            }
            Console.Clear();
            Console.WriteLine("Wrong key detected, try again?");
            mucicka();
        }

    }
}
