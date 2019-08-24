using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
   public  class Factory_Method_Pattern
    {
    }
    #region  产品 =========================
    /// <summary>
    /// 抽象手机产品类
    /// </summary>
    public abstract class Phone
    {
        public abstract string Create();
    }

    /// <summary>
    /// 具体华为手机产品类
    /// </summary>
    public class Huawei : Phone
    {
        /// <summary>
        /// 实现抽象方法
        /// </summary>
        /// <returns></returns>
        public override string Create()
        {
            return "华为一号现世";
        }
    }

    /// <summary>
    /// 具体小米手机产品类
    /// </summary>
    public class Xiaomi : Phone
    {
        /// <summary>
        /// 实现抽象方法
        /// </summary>
        /// <returns></returns>
        public override string Create()
        {
            return "小米一号现世";
        }
    }

    #endregion

    #region  工厂=========================
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// 抽象工厂类的方法，创建调用产品
        /// </summary>
        /// <returns></returns>
        public abstract Phone CreatePhone();
    }

    /// <summary>
    /// 具体华为工厂类，继承抽象工厂类
    /// </summary>
    public class HuaweiFactory : Factory
    {
        /// <summary>
        /// 实现继承方法
        /// </summary>
        /// <returns></returns>
        public override Phone CreatePhone()
        {
            return new Huawei();
        }
    }

    /// <summary>
    /// 具体小米工厂类，继承抽象工厂类
    /// </summary>
    public class XiaomiFactory : Factory
    {
        /// <summary>
        /// 实现继承方法
        /// </summary>
        /// <returns></returns>
        public override Phone CreatePhone()
        {
            return new Xiaomi();
        }
    }
    #endregion

        #region 新增魅族手机 ================
        /// <summary>
        /// 新增魅族工厂类
        /// </summary>
        public class MeizuFactory : Factory
        {
            public override Phone CreatePhone()
            {
                return new Meizu();
            }
        }

        /// <summary>
        /// 新增具体魅族手机产品类
        /// </summary>
        public class Meizu : Phone
        {
            public override string Create()
            {
                return "魅族一号现世";
            }
        }
        #endregion
}
