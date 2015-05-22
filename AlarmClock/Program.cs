using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class StartTime
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;

            TimeSpan interval = new TimeSpan(0, 0, 0, 1);

            //User input
            Console.WriteLine("Alarm Clock v1.0");
            Console.WriteLine("\nAlarm 1\n");

            //Hour input
            Console.Write("Hour: ");
            int hr = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: {0}", hr);

            //Minute input
            Console.Write("Minute: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: {0}", min);

            //AM or PM
            Console.WriteLine("PM? [Y/n]: ");

            hr += 12;

            if (Console.ReadLine().ToUpper().Equals("N"))
            {
                hr -= 12;
            }

            
            
            TimeSpan Alarm1 = new TimeSpan(hr, min, 0);

            Console.WriteLine("\nAlarm1:\t{0:c}", Alarm1);

            Console.WriteLine("\n\nProcessing...");
            Thread.Sleep(new TimeSpan(0, 0, 0, 3));
            Console.Clear();

            //Time testing
            do
            {
                while (! Console.KeyAvailable)
                {
                    Console.WriteLine("Start:\t\t{0}", startTime);

                    //Console.WriteLine(startTime);

                    Console.WriteLine("Current:\t{0}", DateTime.Now.ToString());

                    if( DateTime.Now.TimeOfDay >= Alarm1)
                    {
                        Console.WriteLine("\nAlarm1!\n");


                        Console.WriteLine("Time elapsed from alarm: {0}", DateTime.Now.Subtract(Alarm1).ToString("H:mm:ss"));
                    }



                    Console.WriteLine("\n\nPress ESC to exit");

                    Thread.Sleep(interval);
                    Console.Clear();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);



        }
    }
}
