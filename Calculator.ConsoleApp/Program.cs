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

            //var fromDate = Convert.ToDateTime("2019-08-31 08:59:59 pm");
            //var toDate = Convert.ToDateTime("2019-08-31 09:00:01 pm");
            // to cover the overlap
            var peakStarts = new TimeSpan(8, 59, 41);
            var peakEnds = new TimeSpan(23, 00, 19);


            decimal peakRate = 0.30M;
            decimal offPeakRate = 0.20M;

            decimal cost = 0;
            var tempDate = fromDate;
            while (tempDate <= toDate)
            {
                string before = tempDate.ToString("yyyy-MM-dd hh:mm:ss");
                var rate = "";

                if (tempDate.TimeOfDay >= peakStarts && tempDate.TimeOfDay <= peakEnds)
                {
                    cost += peakRate;
                    rate = "30 paisa";
                }
                else 
                {
                    cost += offPeakRate;
                    rate = "20 paisa";
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
