using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //现在获得了一个手机
            Phone phone = new HuaweiV9Phone();

            //裸机一个，先贴个膜
            Decorator membrane = new Membrane(phone);
            membrane.Write();
            Console.WriteLine();

            //还是觉得不顺眼，再加个外壳看看
            Decorator membraneShell = new Shell(membrane);
            //现在我同时有钢化膜和外壳了
            membraneShell.Write();
            Console.WriteLine( );

            //这时候我觉得还是不要外壳了。我需要同时又钢化膜和手机挂件
            Decorator membranePendant = new Pendant(membrane);
            membranePendant.Write();
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
