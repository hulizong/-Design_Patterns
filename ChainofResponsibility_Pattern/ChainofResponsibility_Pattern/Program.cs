using System;

namespace ChainofResponsibility_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///设置请求
            SettlementRequest settlementRequest = new SettlementRequest(200, MemberType.GoldMember);

            ///初始化具体处理
            SettlementHandler NoMember = new NoMemberHandler();
            SettlementHandler Member = new MemberHandler();
            SettlementHandler GoldMember = new GoldMemberHandler();
            SettlementHandler DiamondsMember = new DiamondsMemberHandler();

            ///设置责任链
            NoMember.nextHandler = Member;
            Member.nextHandler = GoldMember;
            GoldMember.nextHandler = DiamondsMember;

            ///处理请求
            NoMember.Settlement(settlementRequest);
        }


        //static void Main(string[] args)
        //{
        //    decimal Money = 200M;
        //    var memberType = MemberType.GoldMember;

        //    //普通会员，95折计算
        //    if (memberType== MemberType.Member)
        //    {
        //        Console.WriteLine($"普通会员，95折计算,最后金额为{Money*0.95M}");
        //    }
        //    //黄金会员，9折计算
        //    else if (memberType == MemberType.GoldMember)
        //    {
        //        Console.WriteLine($"黄金会员，9折计算,最后金额为{Money*0.9M}");
        //    }
        //    //钻石会员，7折计算
        //    else if (memberType == MemberType.DiamondsMember)
        //    {
        //        Console.WriteLine($"钻石会员，7折计算,最后金额为{Money * 0.7M}");
        //    }
        //    //无会员，全额计算
        //    else
        //    {
        //        Console.WriteLine($"无会员，全额计算,最后金额为{Money}");
        //    }
        //}
    }
} 