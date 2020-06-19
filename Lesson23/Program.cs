using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tag = new
            {
                Value = 10.9,
                Time = DateTime.Now,
                Name = "Event"
            };
            Console.WriteLine(Tag);

            Tuple<double, DateTime, string> tuple = new Tuple<double, DateTime, string>(10.9, DateTime.Now, "Event");
            Console.WriteLine( tuple);
            var tuple2 = (Value: 10.9, Time: DateTime.Now, Name: "Event");
            
            Console.WriteLine(tuple2);
            Console.WriteLine(GetA());
            Console.ReadLine();

        }
        static (int Num, double Value, string Name)GetA()
        {
            return (Num: 1, Value: 5.66, Name: "HEL");
        }
       
        
    }
}
