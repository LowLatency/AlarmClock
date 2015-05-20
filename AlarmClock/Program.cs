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

            TimeSpan interval = new TimeSpan(0, 0, 1);

            //User input
            Console.WriteLine("Alarm Clock v1.0");
            Console.WriteLine("Alarm 1");

            //Hour input
            Console.Write("Hour: ");
            double hr = double.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: {0}", hr);

            //Minute input
            Console.Write("Minute: ");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: {0}", min);

            Thread.Sleep(new TimeSpan(0, 0, 3));
            Console.Clear();


            //Time testing
            do
            {
                while (! Console.KeyAvailable)
                {
                    string Text = DateTime.Now.ToString();
                    Console.WriteLine(startTime);
                    Console.WriteLine(Text);
                    Console.WriteLine("\n\nPress ESC to exit");

                    Thread.Sleep(interval);
                    Console.Clear();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);



        }
    }
}
