using System;

namespace Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化代理对象
            Buy buy = new ProxyBuy();
            //代理对象进行处理事务
            buy.BuyFun("化妆品");

            buy.BuyFun("违禁品");
        }
    }
}
