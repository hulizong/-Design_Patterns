using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化指挥者
            Commander commander = new Commander();
            //指定具体产品
            Builder builder = new LenovoBuilder();
            //组装构建产品
            commander.Construct(builder);
            //构建完成展示产品
            Computer computer = builder.GetComputer();
            computer.Show();


            //指定具体产品
            builder = new HPBuilder();
            //组装构建产品
            commander.Construct(builder);
            //构建完成展示产品
            computer = builder.GetComputer();
            computer.Show();

            Console.ReadLine();
        }
    }
}
