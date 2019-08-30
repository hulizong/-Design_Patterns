using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class AdapterPattern
    {
    }
    #region 目标角色——需要电脑usb耳机=========================
    /// <summary>
    /// 客户端需要的接口
    /// </summary>
    interface ComputerHeadsetTarget
    {
         void GetComputerHeadset();
    }
    #endregion

    #region 被适配角色——现在存在的手机耳机=====================
    /// <summary>
    /// 目前已经存在的接口
    /// </summary>
    public class Adaptee
    {
        public void PhoneHeadset() 
        {
            Console.WriteLine("我现在拥有的是手机耳机。");
        }
    }
    #endregion

    #region 对象适配器——将手机耳机转换成电脑需要的usb耳机==========
    /// <summary>
    /// 对象适配器实现
    /// </summary>
    public class ObjectAdapter : ComputerHeadsetTarget
    {
        Adaptee Adaptee = new Adaptee();
        public void GetComputerHeadset()
        {
            Adaptee.PhoneHeadset();
            Console.WriteLine("现在加入耳机Usb转换器");
            Console.WriteLine("输出：电脑使用的usb耳机");
        }
    }
    #endregion

    #region 类适配器——将手机耳机转换成电脑需要的usb耳机===========
    /// <summary>
    /// 类适配器的实现
    /// </summary>
    public class ClassAdapter : Adaptee,ComputerHeadsetTarget
    {
        public void GetComputerHeadset()
        {
            this.PhoneHeadset();
            Console.WriteLine("现在加入耳机Usb转换器");
            Console.WriteLine("输出：电脑使用的usb耳机");
        }
    }
    #endregion
}
