using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    class MediatorPattern
    {
    }

    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// 定义与同事间的交互通信 
        /// </summary>
        public abstract void Common(string type);
    }

    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
         

        /// <summary>
        /// 处理自己的事务（房东展示自己的房屋）
        /// </summary>
        public abstract void Handle();

    }

    /// <summary>
    /// 房屋中介
    /// </summary>
    public class HouseMediator : Mediator
    {
        /// <summary>
        /// 中介有所有房东的房屋信息
        /// </summary>
        private SmallHouseColleague SmallHouse;
        private TwoHouseColleague TwoHouse;
        private ThreeHouseColleague ThreeHouse;

        public void SetSmallHouse(SmallHouseColleague small) 
        {
            SmallHouse = small;
        }

        public void SetTwoHouse(TwoHouseColleague two)
        {
            TwoHouse = two;
        }
        public void SetThreeHouse(ThreeHouseColleague three)
        {
            ThreeHouse = three;
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="colleague"></param>
        public override void Common(string  type)
        { 
            switch (type)
            {
                case "单间":
                    SmallHouse.Handle();
                    Console.WriteLine("如果可以就可以租房了!");
                    break;
                case "两居室":
                    TwoHouse.Handle();
                    Console.WriteLine("如果可以就可以租房了!");
                    break;
                case "三居室":
                    ThreeHouse.Handle();
                    Console.WriteLine("如果可以就可以租房了!");
                    break;
                default: 
                    Console.WriteLine($"{type}暂时没有房源!");
                    break;
            }
        }
    }

    /// <summary>
    /// 房东（小房间）
    /// </summary>
    public class SmallHouseColleague : Colleague
    {
         

        /// <summary>
        /// 展示单间
        /// </summary>
        public override void Handle()
        {
            Console.WriteLine( "单间——便宜整洁");
        }
    }

    /// <summary>
    /// 房东（两居室）
    /// </summary>
    public class TwoHouseColleague : Colleague
    { 

        /// <summary>
        /// 展示两居室
        /// </summary>
        public override void Handle()
        {
            Console.WriteLine("两居室——合适，靠谱");
        }
    }

    /// <summary>
    /// 房东（三居室）
    /// </summary>
    public class ThreeHouseColleague : Colleague
    { 

        /// <summary>
        /// 展示三居室
        /// </summary>
        public override void Handle()
        {
            Console.WriteLine("三居室——大气，宽松");
        }
    }
}
