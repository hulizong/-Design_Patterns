using System;
using System.Collections.Generic;
using System.Text;

namespace Stragety_Pattern
{
    class StragetyPattern
    {
    }
    #region   抽象策略==================
    /// <summary>
    /// 抽象策略接口
    /// </summary>
    public interface IStragetyPattern 
    {
        /// <summary>
        /// 结算接口
        /// </summary>
        void Settlement(decimal  Money);
    }
    #endregion

    #region   具体策略=======================
    /// <summary>
    /// 无会员计算方式
    /// </summary>
    public class OrdinaryStragety : IStragetyPattern
    {
        public void Settlement(decimal  Money)
        {
            Console.WriteLine($"不是会员，不进行折扣结算。应付款{Money}");
        }
    }

    /// <summary>
    ///  普通会员计算方式
    /// </summary>
    public class MemberStragety : IStragetyPattern
    {
        public void Settlement(decimal  Money)
        {
            Console.WriteLine($"普通会员，打95折结算。应付款{Money*0.9M}");
        }
    }

    /// <summary>
    /// 黄金会员计算方式
    /// </summary>
    public class GoldMemberStragety : IStragetyPattern
    {
        public void Settlement(decimal  Money)
        {
            Console.WriteLine($"黄金会员，打9折结算。应付款{Money*0.95M}");
        }
    }

    /// <summary>
    /// 钻石会员计算方式
    /// </summary>
    public class DiamondGoldMemberStragety : IStragetyPattern
    {
        public void Settlement(decimal  Money)
        {
            Console.WriteLine($"钻石会员，打8折结算。应付款{Money*0.8M}");
        }
    }
    #endregion

    #region   环境角色
    public class ContextStragety 
    {
        private IStragetyPattern _stragety;
        public ContextStragety(IStragetyPattern stragety) 
        {
            _stragety = stragety;
        }

        /// <summary>
        /// 调用结算方法
        /// </summary>
        /// <param name="Money"></param>
        public void GetSettlement(decimal  Money) 
        {
            _stragety.Settlement( Money);
        } 
    }
    #endregion
}
