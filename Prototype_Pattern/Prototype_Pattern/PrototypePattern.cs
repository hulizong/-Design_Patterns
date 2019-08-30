using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    class PrototypePattern
    {
    }
    #region 抽象原型类===========
    public abstract class Prototype 
    {
        /// <summary>
        /// 当前自己的状态
        /// </summary>
        public abstract void Status();
        /// <summary>
        /// 当前自己在做的事情
        /// </summary>
        public abstract void Action(string things);
        /// <summary>
        /// 拷贝自身的方法
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }
    #endregion

    #region  具体原型类——读书学习 =============
    public class LearnPrototype : Prototype
    {
        public override void Status()
        {
           Console.WriteLine("当前状态：好好学习"); 
        }

        public override void Action(string things)
        {
            Console.WriteLine(things);
        }

        public override Prototype Clone()
        {
            return (LearnPrototype)this.MemberwiseClone(); 
        } 
       
    }
    #endregion

    #region  具体原型类——外出玩耍 =============
    public class PlayPrototype : Prototype
    { 
        public override void Status()
        {
            Console.WriteLine("当前状态：开心玩耍");
        }

        public override void Action(string things)
        {
            Console.WriteLine( things);
        }

        public override Prototype Clone()
        {
            return (PlayPrototype)this.MemberwiseClone();
        }
    }
    #endregion
}
