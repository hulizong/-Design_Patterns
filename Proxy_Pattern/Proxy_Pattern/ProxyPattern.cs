using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    class ProxyPattern
    {
    }
    #region 抽象角色——抽象需要做的事情的方法
    public abstract class Buy
    {
        public abstract void BuyFun(string Name);
    }
    #endregion

    #region 真实角色——实现抽象的方法
    public class RealBuy : Buy
    {
        public override void BuyFun(string Name)
        {
            Console.WriteLine($"帮我购买{Name}");
        }
    }
    #endregion

    #region 代理角色——代购
    public class ProxyBuy : Buy
    {
        public RealBuy realBuy;
        public ProxyBuy()
        {
            realBuy = new RealBuy();
        }
        public override void BuyFun(string Name)
        {
           var flag= this.AllowBuy(Name);
            if (!flag)
            {
                Console.WriteLine("违禁品不允许购买"); 
            }
            else
            {
                realBuy.BuyFun(Name);
                Recording(Name);
            }
        }

        /// <summary>
        /// 代理模式中的额外操作。例如购买的东西，不可能啥东西都买。需要对购买的东西进行检查
        /// </summary>
        /// <param name="Name">购买的东西</param>
        /// <returns></returns>
        public bool AllowBuy(string Name)
        {
            if (Name!="违禁品")
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 对购买的东西进行记录
        /// </summary>
        /// <param name="Name"></param>
        public void Recording(string Name)
        {
            Console.WriteLine($"这次代购购买了{Name}");
        }
    }
    #endregion
}
