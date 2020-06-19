using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson24
{
    public class MyEventsAgs
    {
       public  int value { get; set; }
       public MyEventsAgs(int val)
        {
            value = val;
        }
    }
    class Program
    {
        public delegate int ResolveHandler(int i);
        public delegate void ResolveHandler2(int i);
        delegate void MyEvenHandler(object sender, MyEventsAgs e);
        static event MyEvenHandler Started1;
        static event EventHandler Started;
        static void Main(string[] args)
        {
         
           int.TryParse(Console.ReadLine(), out int result);
            ResolveHandler Result;


            Result = delegate (int i)
            {
                Console.WriteLine(i*i);
                return i * i;
            };

            Result += ((int i)=>
            {
                Console.WriteLine(i * i*i);
                return i * i*i;
            });
            Started += (sender,e) => {
                

                Console.WriteLine((int)sender);
            };
            Started?.Invoke( result, null);
            Started1 += Program_Started1;
            Started1 += (sender, ags) => {
                Console.WriteLine(ags.value+" ags");
                Console.WriteLine((int)sender+" sender");
            };
          Started1?.Invoke(result, new MyEventsAgs(result));
            Result(result);

            Console.WriteLine(ShowWorld((i)=>i*i*i*i+11,result)+" last part");
            Console.ReadLine();
        }

        private static void Program_Started1(object sender, MyEventsAgs e)
        {
            Console.WriteLine(  e.value);
        }

        public static int ShowWorld(ResolveHandler resolve, int ii)
        {
          return resolve(ii);
        }
    }
}
