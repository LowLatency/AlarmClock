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

            TimeSpan interval = new TimeSpan(0, 0, 1);

            while (true)
            {
                string Text = DateTime.Now.ToString();
                Console.WriteLine(Text);
                Thread.Sleep(interval);
                Console.Clear();

            }
            

            



            Console.Read();
        }
    }
}
