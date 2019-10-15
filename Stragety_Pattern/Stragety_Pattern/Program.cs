using System;

namespace Stragety_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Account = 190.99M;
            ///会员计算
            ContextStragety stragety = new ContextStragety(new MemberStragety());
            stragety.GetSettlement(Account);

            ///普通结算 
             stragety = new ContextStragety(new OrdinaryStragety());
            stragety.GetSettlement(Account);
        }
    }
}
