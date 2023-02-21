using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3_W
{
    internal class Program
    {
        static void Main(string[] args) {
            string DayOfWeek = "unknown";
            string Time = "unknown";

            Console.WriteLine("Введите номер дня недели");
            int DayOfWeekV = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите час");
            int Hour = Convert.ToInt32(Console.ReadLine());

            switch (DayOfWeekV)
            {
                case 1:
                    DayOfWeek = Convert.ToString(days_of_the_week.Monday);
                    break;
                case 2:
                    DayOfWeek = Convert.ToString(days_of_the_week.Tuesday);
                    break;
                case 3:
                    DayOfWeek = Convert.ToString(days_of_the_week.Wednesday);
                    break;
                case 4:
                    DayOfWeek = Convert.ToString(days_of_the_week.Thursday);
                    break;
                case 5:
                    DayOfWeek = Convert.ToString(days_of_the_week.Friday);
                    break;
                case 6:
                    DayOfWeek = Convert.ToString(days_of_the_week.Saturday);
                    break;
                case 7:
                    DayOfWeek = Convert.ToString(days_of_the_week.Sunday);
                    break;
                default:
                    Console.WriteLine("Дней недели всего 7");
                    break;
            }

            if (Hour >= 7 && Hour <= 12)
            {
                Time = Convert.ToString(DayTime.Morning);
            }
            else if (Hour >= 13 && Hour <= 18)
            {
                Time = Convert.ToString(DayTime.Afternoon);
            }
            else if (Hour >= 19 && Hour <= 23)
            {
                Time = Convert.ToString(DayTime.Evening);
            }
            else if(Hour >= 0 && Hour <= 6)
            {
                Time = Convert.ToString(DayTime.Night);
            }
            else
            {
                Console.WriteLine("В сутках 24 часа от 0 до 23");
            }

            Console.WriteLine($"Сейчас {DayOfWeek}, {Time}");
            Console.ReadLine();
        }
        enum days_of_the_week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }
    }
}
