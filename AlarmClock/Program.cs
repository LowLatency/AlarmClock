using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class Program
    {
        private static readonly TimeSpan SleepTime = TimeSpan.FromSeconds(1);

        static void Main(string[] args)
        {
            var startTime = DateTime.Now;

            //User input
            Console.WriteLine("Alarm Clock v1.1");

            //Multiple alarm setup
            Console.WriteLine("How many alarms would you like to set?");
            Console.WriteLine("Number of alarms: ");
            int NumOfAlarms = int.Parse(Console.ReadLine());


            //Two second sleep time for viewing of alarm input
            Thread.Sleep(SleepTime);
            Thread.Sleep(SleepTime);
            Console.Clear();

            //Time testing
            do
            {

                Console.WriteLine("Start:\t\t{0}", startTime);

                //Console.WriteLine(startTime);

                Console.WriteLine("Current:\t{0}", DateTime.Now.ToString());

                if (DateTime.Now.TimeOfDay >= Alarm1)
                {
                    Console.WriteLine("\nAlarm1!\n");

                    Console.WriteLine(@"Time elapsed from alarm: {0:H\:mm\:ss}", DateTime.Now.Subtract(Alarm1));
                    //Console.WriteLine("Time elapsed from alarm: {0}", DateTime.Now.Subtract(Alarm1).ToString("H:mm:ss"));
                }

                Console.WriteLine("\n\nPress ESC to exit");

                Thread.Sleep(SleepTime);
                Console.Clear();

            } while (!ExitRequested());
        }

        private static bool ExitRequested()
        {
            return Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape;
        }

        private static TimeSpan AlarmInput()
        {
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
            Console.WriteLine("PM? [y/N]: ");

            if (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                hr += 12;
            }

            var AlarmOut = new TimeSpan(hr, min, 0);

            Console.WriteLine("\nAlarm Input:\t{0:c}", AlarmOut);

            return AlarmOut;
        }
    }
}
