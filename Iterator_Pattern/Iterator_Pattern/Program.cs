using System;

namespace Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取迭代器对象

            IListAggregate listAggregate = new ConcreteListAggregate();
            Iterator iterator = listAggregate.GetIterator(); 
            while (iterator.IsNext())
            {
                var result = iterator.GetCurrentIndex();
                Console.WriteLine(result);
                iterator.Next();

            }
        }
    }
}
