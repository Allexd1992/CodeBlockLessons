using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class Program
    {
        delegate void Run();
        delegate int GT(int i);
        public static Action action;
        public static Func<int, int> func;
        static void Main(string[] args)
        {
            action = Hello;
            Run run = Hello;
            func = Get;
            GT gt = Get;
            run?.Invoke();
            action?.Invoke();
            Console.WriteLine(gt?.Invoke(10));
            Console.WriteLine( func?.Invoke(10));
            Console.ReadLine();

        }
        static void Hello()
        {
            Console.WriteLine("Hell0");
        }
        static int Get(int i)
        {
            return i * i;
        }
    }
}
