using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一次注册登录
            FacadePattern facadePattern = new FacadePattern();
            facadePattern.LoginFirst();
             
        }
    }
}
