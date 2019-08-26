using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{

    #region 抽象产品类  ===============
    /// <summary>
    /// 手机抽象类
    /// </summary>
    public abstract class Phone
    {
        public abstract  string CreatePhone();
    }
    /// <summary>
    /// 耳机抽象类
    /// </summary>
    public abstract class Headset
    {
        public abstract string CreateHeadset();
    }
    /// <summary>
    /// 充电器抽象类
    /// </summary>
    public abstract class Charger
    {
        public abstract string CreateCharger();
    }
    #endregion

    #region 华为具体产品类  ===========
    public class HuaweiPhone : Phone
    {
        public override string CreatePhone()
        {
            return "华为手机一号现世";
        }
    }
    public class HuaweiHeadset : Headset
    {
        public override string CreateHeadset()
        {
            return "华为手机一号原配耳机";
        }
    }
    public class HuaweiCharger : Charger
    {
        public override string CreateCharger()
        {
            return "华为手机一号原配充电器";
        }
    }
    #endregion

    #region 小米具体产品类  =========== 
    public class XiaomiPhone : Phone
    {
        public override string CreatePhone()
        {
            return "小米手机一号现世";
        }
    }
    public class XiaomiHeadset : Headset
    {
        public override string CreateHeadset()
        {
            return "小米手机一号原配耳机";
        }
    }
    public class XiaomiCharger : Charger
    {
        public override string CreateCharger()
        {
            return "小米手机一号原配充电器";
        }
    }
    #endregion

    #region 抽象工厂类  ===============
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Phone GetPhone();
        public abstract Headset GetHeadset();
        public abstract Charger GetCharger();
    }
    #endregion

    #region 华为具体工厂===============
    public class HuaweiFactory : AbstractFactory
    {

        public override Phone GetPhone()
        {
            return new HuaweiPhone();
        }

        public override Headset GetHeadset()
        {
            return new HuaweiHeadset();
        }
         
        public override Charger GetCharger()
        {
            return new HuaweiCharger();
        }
    }
    #endregion

    #region 小米具体工厂===============
    public class XiaomiFactory : AbstractFactory
    {

        public override Phone GetPhone()
        {
            return new XiaomiPhone();
        }

        public override Headset GetHeadset()
        {
            return new XiaomiHeadset();
        }

        public override Charger GetCharger()
        {
            return new XiaomiCharger();
        }
    }
    #endregion

    #region 新增魅族手机需求===========
    public class MeizuPhone : Phone
    {
        public override string CreatePhone()
        {
            return "魅族手机一号现世";
        }
    }
    public class MeizuHeadset : Headset
    {
        public override string CreateHeadset()
        {
            return "魅族手机一号原配耳机";
        }
    }
    public class MeizuCharger : Charger
    {
        public override string CreateCharger()
        {
            return "魅族手机一号原配充电器";
        }
    }
    public class MeizuFactory : AbstractFactory
    { 
        public override Phone GetPhone()
        {
            return new MeizuPhone();
        }
        public override Headset GetHeadset()
        {
            return new MeizuHeadset();
        }
        public override Charger GetCharger()
        {
            return new MeizuCharger();
        }

    }
    #endregion
}
