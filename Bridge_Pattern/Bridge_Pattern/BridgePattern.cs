using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    class BridgePattern
    {
    }
    #region  抽象化角色——迭代更新的版本（包含对实现化角色对象的引用）========
    public abstract class Version
    {
        /// <summary>
        /// 实现对实现化对象的引用，通过组合实现软件迭代更新并适用于不同平台的功能
        /// </summary>
        protected PhoneType _phoneType;

        /// <summary>
        /// 构造函数注入，实现化对象的初始化
        /// </summary>
        /// <param name="phoneType"></param>
        public Version(PhoneType phoneType) 
        {
            this._phoneType = phoneType;
        }
        /// <summary>
        /// 创建软件版本
        /// </summary>
        public abstract void Create();
    }
    #endregion

    #region 实现化角色——适用于手机类型=============================================
    public abstract class PhoneType 
    {
        /// <summary>
        /// 适配手机类型
        /// </summary>
        public abstract void SetType();
    }
    #endregion

    #region 具体抽象化角色——具体实际迭代更新的版本===========
    /// <summary>
    /// 版本1.0
    /// </summary>
    public class OneVersion : Version
    {
        public OneVersion(PhoneType phoneType) :base(phoneType) 
        {
        }
        public override void Create()
        {
            Console.WriteLine("当前版本1.0");
            this._phoneType.SetType();
        }
    }
    /// <summary>
    /// 当前版本2.1
    /// </summary>
    public class TwoVersion : Version
    {
        public TwoVersion(PhoneType phoneType) : base(phoneType) { }
        public override void Create()
        {
            Console.WriteLine("当前版本2.0");
            this._phoneType.SetType();
        }
    }
    #endregion

    #region  具体实现化角色——具体实际使用类型===================
    /// <summary>
    /// 安卓系统
    /// </summary>
    public class AndroidPhoneType : PhoneType
    {
        public override void SetType()
        {
            Console.WriteLine("当前是Android类型");
        }
    }

    /// <summary>
    /// ios系统
    /// </summary>
    public class IOSPhoneType : PhoneType
    {
        public override void SetType()
        {
            Console.WriteLine("当前是IOS类型");
        }
    }
    #endregion

}
