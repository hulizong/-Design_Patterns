using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ///华为工厂生产华为产品
            HuaweiFactory huaweiFactory = new HuaweiFactory();
            var phone = huaweiFactory.GetPhone().CreatePhone();
            var headset = huaweiFactory.GetHeadset().CreateHeadset();
            var charger = huaweiFactory.GetCharger().CreateCharger();
            Console.WriteLine("华为产品生产：" + phone + "——" + headset + "——" + charger);


            ///小米工厂生产小米产品
            XiaomiFactory xiaomiFactory = new XiaomiFactory();
            phone = xiaomiFactory.GetPhone().CreatePhone();
            headset = xiaomiFactory.GetHeadset().CreateHeadset();
            charger = xiaomiFactory.GetCharger().CreateCharger();
            Console.WriteLine("小米产品生产：" + phone + "——" + headset + "——" + charger);

            ///魅族工厂生产小米产品
            MeizuFactory meizuFactory = new MeizuFactory();
            phone = meizuFactory.GetPhone().CreatePhone();
            headset = meizuFactory.GetHeadset().CreateHeadset();
            charger = meizuFactory.GetCharger().CreateCharger();
            Console.WriteLine("魅族产品生产：" + phone + "——" + headset + "——" + charger);

            Console.ReadLine();
        }
    }
}
