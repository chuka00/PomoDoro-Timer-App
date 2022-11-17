using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomoDoro_Timer_App
{
    internal class Timer
    {
        public int workTime;
        public int restTime;

        public void RunTimer()
        {

            Console.WriteLine("Kindly enter your desired worktime");
            var workTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kindly enter your desired rest period");
            var restTime = Convert.ToInt32(Console.ReadLine());

            setTimer();
        }
        public void setTimer()
        {

            for (var i = workTime + 1; i <= workTime; i--)
            {
                Thread.Sleep(1000);
                Console.Write("\rRestTime: " + i);
                if (i == 0)
                {
                    Console.Write("\rTimes Up!, get back to work!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
        public void restTimer()
        {

            for (var i = restTime - 1; i <= restTime; i--)
            {
                Thread.Sleep(1000);
                Console.Write("\rRestTime: " + i);
                if (i == 0)
                {
                    Console.Write("\rTimes Up!, get back to work!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }

        public void keepGoing()
        {
            Console.WriteLine("want to start again? Y or N");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                setTimer();
            }
            else if (answer == "N")
            {
                Environment.Exit(0);
            }
        }
    }
}

