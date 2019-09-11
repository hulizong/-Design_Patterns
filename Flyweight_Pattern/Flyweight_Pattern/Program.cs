using System;

namespace Flyweight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ///初始化享元工厂
            FlyweightFactory factory = new FlyweightFactory();
            while (true)
            {
                Console.WriteLine("请输入字符的位置：");
                var indexstring = Console.ReadLine();
                if (int.TryParse(indexstring, out int index))
                {
                    Console.WriteLine("请输入字符:");
                    string str = Console.ReadLine();

                    ///判断字符是否创建
                    Flyweight flyweight = factory.GetFlyweight(str);

                    //如果存在则输出信息
                    if (flyweight != null)
                    {
                        flyweight.OutInput(index);
                    }
                }
                else
                {
                    Console.WriteLine("请输入数字!");
                }
                Console.WriteLine("结束请输入N");
                if (Console.ReadLine()=="N")
                {
                    break;
                }
            }

            Console.WriteLine("已结束");
            Console.ReadLine();
        }
    }
}
