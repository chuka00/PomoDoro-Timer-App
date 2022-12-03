using System.Security.Cryptography.X509Certificates;

namespace PomoDoro_Timer_App
{
    internal class ApplicationOne
    {
        public void Run()
        {
            try
            {
                
                Console.WriteLine("\nWelcome \n");
                Console.WriteLine("Kindly enter your desired worktime(In minutes)");
                var workTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kindly enter your desired rest period");
                var restTime = Convert.ToInt32(Console.ReadLine());
                WorkTime();

                void WorkTime()
                {
                    var minuteTimer = new DateTime(2000, 1, 1, 0, workTime, 0);

                    for (int i = 0; i <= workTime * 60; i++)
                    {
                        Console.WriteLine("Worktime Left: ");
                        Console.Write(minuteTimer.ToString("mm:ss"));
                        minuteTimer = minuteTimer.AddSeconds(-1);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    RestTime();
                }


                void RestTime()
                {
                    var minuteTimer = new DateTime(2000, 1, 1, 0, restTime, 0);

                    for (int i = 0; i <= restTime * 60; i++)
                    {
                        Console.WriteLine("Rest Time: ");
                        Console.Write(minuteTimer.ToString("mm:ss"));
                        minuteTimer = minuteTimer.AddSeconds(-1);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Restime is over, time to get back to work\n " +
                    "Would you like to restart the application?\n press y  to restart the process or press any key to exit");
                var response = Console.ReadLine();
                if (response == "Y" || response == "y")
                {
                    Run();
                }
                else
                {
                    Environment.Exit(1);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured: " + ex.Message);
            }
        }
    }
}
