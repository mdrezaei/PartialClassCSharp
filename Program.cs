using System;

namespace ConsoleApp11_PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass PC = new PartialClass();//در اینجا <پی سی> یک نمونه از کلاس پارشیال <پارشیالکلاس> است
            PC.Sum();//سام در یک کلاس پارشیال است
            Console.WriteLine(PC.Minius(10, 5)); // ماینس در کلاس پارشیال دیگری است
            PC.Print();//پرینت نیز از یک کلاس پارشیال دیگر هم نام با دو کلاس دیگر هست. که همگی با <پی سی> که نمونه ای از کلاس های هم نامشان است قابل دسترسی اند
        }
    }
}
