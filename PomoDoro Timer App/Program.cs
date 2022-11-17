namespace PomoDoro_Timer_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter your desired worktime");
            var workTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kindly enter your desired rest period");
            var restTime = Convert.ToInt32(Console.ReadLine());

            while (true)
            { 

                    for (var i = workTime - 1; i <= workTime; i--)
                    {
                        Thread.Sleep(1000);
                        Console.Write("\rWorkTime: " + i);
                        if (i == 0)
                        {
                            Console.Write("Time to get some rest\n");
                            restCountDown(restTime);
                        }
                    }
                    static void restCountDown(int restTime)
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
                
                
                
                    //var convertedWorkTime = Convert.ToInt32(workTime);
                    /*var restTime = Console.ReadLine();*/
                    /*var convertedRestTime = Convert.ToInt32(restTime);*/
                    //Console.CursorVisible = false;
                    var minuteTimer = new DateTime(2000, 1, 1, 0, workTime, 0);

                    for (int i = 0; i <= workTime * 60; i++)
                    {
                        Console.Write(minuteTimer.ToString("mm:ss"));
                        minuteTimer = minuteTimer.AddSeconds(-1);
                        Thread.Sleep(1000);
                        Console.Clear();
                        restCountDown();
                    }

                    static void restCountDown(int restTime)
                    {
                        var minuteTimer = new DateTime(2000, 1, 1, 0, restTime, 0);

                        for (int i = 0; i <= restTime * 60; i++)
                        {
                            Console.Write(minuteTimer.ToString("mm:ss"));
                            minuteTimer = minuteTimer.AddSeconds(-1);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
            }
    }
}