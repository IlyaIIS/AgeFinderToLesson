using System;

namespace AgeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            String userName;
            Byte day;
            Int32 year, age, month = 0,dayMax;
            DateTime date = DateTime.Now;
            Int32 yearNow = date.Year, monthNow = date.Month, dayNow = date.Day;

            Console.WriteLine("Здравствуйте! Эта программа поможет определить ваш настоящий возраст.");

            Console.Write("Как вас зовут: ");
            userName = Console.ReadLine();

            Console.Write("В каком году вы роделись: ");
            year = Convert.ToInt16(Console.ReadLine());

            Console.Write("Номер вашего месяца рождения: ");
            do
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12) { Console.Write("Введите корректное число(1-12): "); }
            } while ((month < 1) || (month > 12));
            if (month == 4 || month == 6 || month == 9 || month == 11)                                            { dayMax = 30; } else
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) { dayMax = 31; } else
            if ((year % 4 != 0) || ((year % 100 == 0) && (year % 400 != 0))) { dayMax = 28; } else { dayMax = 29; }

            Console.Write("Ведите день рождения: ");
            do
            {
                day = Convert.ToByte(Console.ReadLine());
                if (day < 1 || day > dayMax) { Console.Write("Введите корректное число(1-" + dayMax + "): "); }
            } while (day < 1 || day > dayMax);

            age = yearNow - year;
            if (age < 0) age = 0;
            if (month >  monthNow)                     { age--; }  else
            if (month == monthNow) { if (day > dayNow) { age--; } }

            Console.WriteLine(userName + ", ваш возраст составляет " + age + " лет!");
        }
    }
}
