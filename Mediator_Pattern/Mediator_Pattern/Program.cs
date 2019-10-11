using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一个租客看房：");
            ///初始化中介
            HouseMediator mediator = new HouseMediator();

            ///初始化房屋信息
            SmallHouseColleague smallHouseColleague = new SmallHouseColleague( );
            TwoHouseColleague twoHouseColleague = new TwoHouseColleague( );
            ThreeHouseColleague threeHouseColleague = new ThreeHouseColleague( );

            ///中介获取房屋信息
            mediator.SetSmallHouse(smallHouseColleague);
            mediator.SetTwoHouse(twoHouseColleague);
            mediator.SetThreeHouse(threeHouseColleague); 

            ///租户A需要两居室、提供看房
            mediator.Common("两居室");

            //租户B需要四居室、暂无房源
            mediator.Common("四居室");

        }
    }
}
