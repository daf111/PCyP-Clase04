using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var TaskA = Task<int>.Factory.StartNew(() =>
            {

                return 42;
            });

            TaskA.Wait();
            Console.WriteLine(TaskA.Result);

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }
}
