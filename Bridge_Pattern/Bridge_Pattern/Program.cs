using System;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1.0版本软件 安卓系统 
            AndroidPhoneType androidPhoneType = new AndroidPhoneType();
            OneVersion oneVersion = new OneVersion(androidPhoneType);
            oneVersion.Create();

            ///2.0 版本软件  IOS系统
            IOSPhoneType iOSPhoneType = new IOSPhoneType();
            TwoVersion twoVersion = new TwoVersion(iOSPhoneType);
            twoVersion.Create();

            Console.ReadLine();
        }
    }
}
