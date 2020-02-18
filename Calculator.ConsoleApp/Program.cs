using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int pulse = 20;

            var fromDate = Convert.ToDateTime(Console.ReadLine());
            var toDate = Convert.ToDateTime(Console.ReadLine());


            //var fromDate = Convert.ToDateTime("2019-08-31 08:59:13 am");
            //var toDate = Convert.ToDateTime("2019-08-31 09:00:39 am");

            var peakStarts = new TimeSpan(9, 0, 0);
            
            decimal peakRate = 0.30M;
            decimal offPeakRate = 0.20M;

            decimal cost = 0;
            var tempDate = fromDate;
            while (tempDate <= toDate)
            {
                string before = tempDate.ToString("yyyy-MM-dd hh:mm:ss");
                var rate = "";
                if (tempDate.AddSeconds(pulse).TimeOfDay < peakStarts)
                {
                    cost += offPeakRate;
                    rate = "20 paisa";
                }
                else
                {
                    cost += peakRate;
                    rate = "30 paisa";
                }

                tempDate = tempDate.AddSeconds(pulse);
                var after = tempDate.ToString("yyyy-MM-dd hh:mm:ss");
                Console.WriteLine(before + $" + {pulse.ToString()} seconds " + after + " = " + rate); 
            }
            
            Console.WriteLine($"{cost} taka");
            Console.ReadLine();
        }
    }
}
