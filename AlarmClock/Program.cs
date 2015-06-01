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
            List<TimeSpan> AlarmsFromUser = new List<TimeSpan>();


            //User input
            Console.WriteLine("Alarm Clock v1.2\n");

            //Multiple alarm setup
            Console.WriteLine("How many alarms would you like to set?\n");
            int NumOfAlarms = int.Parse(Console.ReadLine());

            Thread.Sleep(SleepTime);
            Console.Clear();

            for (int i = 0; i < NumOfAlarms; i++)
            {
                Console.WriteLine("Alarm #{0}", i+1);
                AlarmsFromUser.Add(AlarmInput());
            }


            Console.WriteLine("Times Inputted:");

            int count = 0;
            foreach (TimeSpan element in AlarmsFromUser)
            {
                count += 1;
                Console.WriteLine("\nAlarm Input {0}:\t{1}", count, element);

            }


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

                count = 0;
                
                foreach (TimeSpan element in AlarmsFromUser)
                {
                    count += 1;
                    if (DateTime.Now.TimeOfDay >= element)
                    {
                        Console.WriteLine("\nAlarm {0}!", count);

                        Console.WriteLine(@"Time elapsed from alarm: {0:H\:mm\:ss}", DateTime.Now.Subtract(element));
                        //Console.WriteLine("Time elapsed from alarm: {0}", DateTime.Now.Subtract(Alarm1).ToString("H:mm:ss"));
                    }

                }
                

                // Was used for single alarm from v1.1
                /*
                if (DateTime.Now.TimeOfDay >= Alarm1)
                {
                    Console.WriteLine("\nAlarm1!\n");

                    Console.WriteLine(@"Time elapsed from alarm: {0:H\:mm\:ss}", DateTime.Now.Subtract(Alarm1));
                    //Console.WriteLine("Time elapsed from alarm: {0}", DateTime.Now.Subtract(Alarm1).ToString("H:mm:ss"));
                }
                */


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
            //Console.WriteLine("\nAlarm Input\n");

            //Hour input
            Console.Write("\nHour: ");
            int hr = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: {0}", hr);

            //Minute input
            Console.Write("\nMinute: ");
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
            Thread.Sleep(SleepTime);
            Thread.Sleep(SleepTime);
            Console.Clear();

            return AlarmOut;
        }
    }
}
