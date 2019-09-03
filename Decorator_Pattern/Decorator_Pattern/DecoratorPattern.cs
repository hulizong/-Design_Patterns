using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    class DecoratorPattern
    {
    }
    #region 抽象构件角色——抽象手机（抽象一个接口，准备接收新增的责任）=========
    /// <summary>
    /// 手机抽象类
    /// </summary>
    public abstract class Phone 
    {
        public abstract void Write();
    }
    #endregion
    #region 具体抽象构件角色——具体手机（实现抽象接口）===============================
    public class HuaweiV9Phone : Phone
    {
        public override void Write()
        {
            Console.WriteLine("对荣耀V9手机开始装饰");
        }
    }
    #endregion
    #region 装饰抽象角色——继承抽象构件角色，包含一个抽象构件角色对象的实例
   /// <summary>
   /// 装饰角色
   /// </summary>
    public abstract class Decorator : Phone 
    {
        public Phone _phone;
        protected Decorator(Phone phone)
        {
            this._phone = phone;
        }
        public override void Write()
        {
            if (_phone!=null)
            {
                _phone.Write();
            }
        }
    }
    #endregion
    #region 具体装饰角色——手机加上钢化膜
    /// <summary>
    /// 具体装饰角色
    /// </summary>
    public class Membrane : Decorator
    { 
        public Membrane(Phone phone) : base(phone) { }
        public override void Write()
        {
            base.Write();
            AddMembrane();
        }
        public void AddMembrane() 
        {
            Console.WriteLine("手机加上了钢化膜!");
        }
    }
    #endregion

    #region 具体装饰角色——手机加上壳
    /// <summary>
    /// 具体装饰角色
    /// </summary>
    public class Shell : Decorator
    {
        public Shell(Phone phone) : base(phone) { }
        public override void Write()
        {
            base.Write();
            AddShell();
        }
        public void AddShell()
        {
            Console.WriteLine("手机加上了壳!");
        }
    }
    #endregion

    #region 具体装饰角色——手机挂件
    /// <summary>
    /// 具体装饰角色
    /// </summary>
    public class Pendant : Decorator
    {
        public Pendant(Phone phone) : base(phone) { }
        public override void Write()
        {
            base.Write();
            AddPendant();
        }
        public void AddPendant()
        {
            Console.WriteLine("手机加上了挂件!");
        }
    }
    #endregion
}
