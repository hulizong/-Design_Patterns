using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化工厂
            Factory huaweiFactory = new HuaweiFactory();
            
            //生产具体的华为手机
            var result=huaweiFactory.CreatePhone();
            //华为手机现世
            var answer = result.Create();
            Console.WriteLine(answer);

            Factory xiaomiFactory = new XiaomiFactory();
            result = xiaomiFactory.CreatePhone();
            answer = result.Create();
            Console.WriteLine(answer);

            Factory meizuFactory = new MeizuFactory();
            result = meizuFactory.CreatePhone();
            answer = result.Create();
            Console.WriteLine(answer);

            Console.ReadLine();
        }
    }
}
