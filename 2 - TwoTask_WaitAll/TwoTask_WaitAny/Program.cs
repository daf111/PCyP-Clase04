using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwoTask_WaitAll
{
    class Program
    {

        static void MethodA() { Thread.SpinWait(int.MaxValue); }
        static void MethodB() { Thread.SpinWait(int.MaxValue/2); }

        static void Main(string[] args)
        {
            var TaskA = Task.Factory.StartNew(MethodA);
            var TaskB = Task.Factory.StartNew(MethodB);

            Console.WriteLine("TaskA id = {0}", TaskA.Id);
            Console.WriteLine("TaskB id = {0}", TaskB.Id);

            var tasks=new Task[] {TaskA, TaskB};
            Task.WaitAll(tasks);
            Console.WriteLine("All Task are finished.");

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }
}
