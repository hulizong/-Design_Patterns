using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我现在需要电脑usb耳机");
            ///对象适配器
            ObjectAdapter objectAdapter = new ObjectAdapter();
            objectAdapter.GetComputerHeadset();

            Console.WriteLine("我现在需要电脑usb耳机");
            ///类适配器
            ClassAdapter classAdapter = new ClassAdapter();
            classAdapter.GetComputerHeadset();
            

            Console.ReadLine(); 
        }
    }
}
