using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight_Pattern
{
    class FlyweightPattern
    {
    }

    #region 抽象享元角色——抽象公共接口
    public abstract class Flyweight 
    {
        /// <summary>
        /// 表述输出的位置
        /// </summary>
        /// <param name="externalstate">外在的状态，随着环境改变而改变</param>
        public abstract void OutInput(int externalstate);
    }
    #endregion

    #region 具体享元角色——实现其具体
    public class SpecificFlyweight : Flyweight
    {
        private string Innerstate;
        /// <summary>
        /// 内部状态接收
        /// </summary>
        /// <param name="innerstate">内部状态</param>
        public SpecificFlyweight(string innerstate) 
        {
            this.Innerstate = innerstate;
        }
        /// <summary>
        /// 实现方法
        /// </summary>
        /// <param name="externalstate">外部状态</param>
        public override void OutInput(int externalstate)
        {
            Console.WriteLine($"内部状态：{Innerstate}————外部状态：{externalstate}");
        }
    }
    #endregion

    #region 享元工厂角色——对享元角色进行创建及管理的
    public class FlyweightFactory 
    {
        public Dictionary<string, SpecificFlyweight> keyValuePairs = new Dictionary<string, SpecificFlyweight>();

        public SpecificFlyweight GetFlyweight(string Key) 
        {
            SpecificFlyweight specific = null;
            if (!keyValuePairs.ContainsKey(Key))
            {
                Console.WriteLine("暂时未遇见该Key");
                keyValuePairs.Add(Key, new SpecificFlyweight(Key));
                Console.WriteLine("现已保存该Key"); 
            }
            else
            {
                 specific = keyValuePairs[Key] as SpecificFlyweight;
            }
            return specific;
        }
    }
    #endregion
}
