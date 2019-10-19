using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChainofResponsibility_Pattern
{
    public enum MemberType 
    {
        [Description("无会员")]
        NoMember=1,
        [Description("普通会员")]
        Member =2,
        [Description("黄金会员")]
        GoldMember =3,
        [Description("钻石会员")]
        DiamondsMember =4

    }
    class ChainofResponsibilityPattern
    {
    }

    /// <summary>
    /// 结算请求
    /// </summary>
    public class SettlementRequest
    {
        /// <summary>
        /// 金额
        /// </summary>
        public decimal _money;
        /// <summary>
        /// 会员类型
        /// </summary>
        public MemberType _memberType;
        public SettlementRequest(decimal money,MemberType memberType) 
        {
            this._money = money;
            this._memberType = memberType;
        }
    }

    /// <summary>
    /// 结算抽象处理
    /// </summary>
    public abstract class SettlementHandler 
    {
        /// <summary>
        /// 下一位接收处理者
        /// </summary>
        public SettlementHandler nextHandler;
        public abstract void Settlement(SettlementRequest settlementRequest); 
    }

    /// <summary>
    /// 无会员接收者
    /// </summary>
    public class NoMemberHandler : SettlementHandler
    {
        public override void Settlement(SettlementRequest settlementRequest)
        {
            if (settlementRequest._memberType==MemberType.NoMember)
            {
                Console.WriteLine($"无会员，不进行折扣计算。最后金额为{settlementRequest._money}");
            }
            else
            {
                nextHandler.Settlement(settlementRequest);
            }
        }
    }

    /// <summary>
    /// 普通会员接收处理者
    /// </summary>
    public class  MemberHandler : SettlementHandler
    {
        public override void Settlement(SettlementRequest settlementRequest)
        {
            if (settlementRequest._memberType == MemberType.Member)
            {
                Console.WriteLine($"普通会员，95折计算。最后金额为{settlementRequest._money*0.9M}");
            }
            else
            {
                nextHandler.Settlement(settlementRequest);
            }
        }
    }

    /// <summary>
    /// 黄金会员接收处理者
    /// </summary>
    public class GoldMemberHandler : SettlementHandler
    {
        public override void Settlement(SettlementRequest settlementRequest)
        {
            if (settlementRequest._memberType == MemberType.GoldMember)
            {
                Console.WriteLine($"黄金会员，9折计算。最后金额为{settlementRequest._money*0.9M}");
            }
            else
            {
                nextHandler.Settlement(settlementRequest);
            }
        }
    }

    /// <summary>
    /// 钻石会员接收处理者
    /// </summary>
    public class DiamondsMemberHandler : SettlementHandler
    {
        public override void Settlement(SettlementRequest settlementRequest)
        {
            if (settlementRequest._memberType == MemberType.DiamondsMember)
            {
                Console.WriteLine($"钻石会员，7折计算。最后金额为{settlementRequest._money*0.7M}");
            }
            else
            {
                nextHandler.Settlement(settlementRequest);
            }
        }
    }
}
