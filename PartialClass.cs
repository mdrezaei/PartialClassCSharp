using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_PartialClass
{
    partial class PartialClass//کلاس های پارشیال به معنای تکه تکه هستند که موجب میشود ما از نام یک کلاس بار ها استفاده کنیم و کلاسی با یک نام را چندین جا ایجاد کنیم و در ان کلاس های پارشیال هم نام متد ها و پراپرتی ها و چیز های دیگری با نام های <مختلف> ایجاد و استفاده کنیم. کار برد این کلاس ها بیشتر در کارهای تیمی است. در این کلاس ها نمیتوان از نام های تکراری برای متد ها و پراپرتی ها استفاده کرد و یا دیگر اجزای درون بلاک کلاس ها چون بعد کامپایل و بیلد برنامه کلاس های پارشیال هم نام با هم ادغام و مرج میشوند و میدانیم که نمیشود در یک بلاک از نام های تکراری استفاده کرد.
    {
        public void Sum()
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+b);

        }
    }

    partial class PartialClass
    {
        public void Print()
        {
            Console.WriteLine("PRINT");
        }
    }
}
